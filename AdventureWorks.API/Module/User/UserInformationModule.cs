namespace AdventureWorks.API.Module.User
{
    using Model.Module.User;
    using Nancy;
    using Nancy.Security;
    using Route.Module.User;
    using UOW.Person;

    public class UserInformationModule : NancyModule
    {
        private GetUserInformatioUOW _userInformatioUow { get; set; }
        
        public UserInformationModule(GetUserInformatioUOW userInformatioUow)
            : base(UserInformationRoute.Base)
        {
            this.RequiresAuthentication();

            _userInformatioUow = userInformatioUow;

            Get[UserInformationRoute.GetUserInformation] = _ =>
            {
                return new GetUserInformationModel(
                            _userInformatioUow.SetUserName(this.Context.CurrentUser.UserName)
                                              .GetResult());
            };
        }
    }
}
