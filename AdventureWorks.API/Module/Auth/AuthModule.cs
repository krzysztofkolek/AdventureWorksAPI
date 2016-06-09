namespace AdventureWorks.API.Module.Auth
{
    using Nancy;
    using Nancy.Authentication.Token;
    using Nancy.Security;
    using Shared.Auth;  

    public class AuthModule : NancyModule
    {
        private UserDatabase _userDatabase { get; set; }


        public AuthModule(ITokenizer tokenizer, UserDatabase userDatabase)
            : base("/auth")
        {
            _userDatabase = userDatabase;
            Post["/"] = x =>
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
