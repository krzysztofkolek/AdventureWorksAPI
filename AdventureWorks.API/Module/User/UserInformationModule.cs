namespace AdventureWorks.API.Module.User
{
    using Nancy;
    using Nancy.Security;
    using UOW.Person;

    public class UserInformationModule : NancyModule
    {
        private GetUserInformatioUOW _userInformatioUow { get; set; }
        
        public UserInformationModule(GetUserInformatioUOW userInformatioUow)
            : base("/userInformation")
        {
            this.RequiresAuthentication();

            _userInformatioUow = userInformatioUow;

            Get["/"] = _ =>
            {
                return _userInformatioUow.SetUserName(this.Context.CurrentUser.UserName)
                                         .GetResult();
            };
        }
    }
}
