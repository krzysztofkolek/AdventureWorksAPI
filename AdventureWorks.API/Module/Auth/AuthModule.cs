namespace AdventureWorks.API.Module.Auth
{
    using Nancy;
    using Nancy.Authentication.Token;
    using Nancy.Security;
    using Route.Module.Auth;
    using Shared.Auth;  

    public class AuthModule : NancyModule
    {
        private UserDatabase _userDatabase { get; set; }


        public AuthModule(ITokenizer tokenizer, UserDatabase userDatabase)
            : base(AuthRoute.Base)
        {
            _userDatabase = userDatabase;

            // Login
            Post[AuthRoute.LoginPost] = _ =>
            {
                var userName = (string)this.Request.Form.UserName;
                var password = (string)this.Request.Form.Password;

                var userIdentity = _userDatabase.ValidateUser(userName, password);

                if (userIdentity == null)
                {
                    return HttpStatusCode.Unauthorized;
                }

                var token = tokenizer.Tokenize(userIdentity, Context);

                return new
                {
                    Token = token,
                };
            };

            // Register
            Put[AuthRoute.RegisterPost] = _ =>
            {
                return null;
            };

            Get["/validation"] = _ =>
            {
                this.RequiresAuthentication();
                return "Yay! You are authenticated!";
            };

            Get["/admin"] = _ =>
            {
                this.RequiresClaims(new[] { "admin" });
                return "Yay! You are authorized!";
            };
        }
    }
}
