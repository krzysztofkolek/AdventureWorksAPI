namespace AdventureWorks.API.Module.User
{
    using Nancy;
    using Nancy.Security;
    using Route.Module.User;
    using UOW.Person;

    public class GetUserTitleModule : NancyModule
    {
        private GetUserTitleUOW _getUserTitleUow { get; set; }

        public GetUserTitleModule(GetUserTitleUOW userInformatioUow)
            : base(UserTitleRoute.Base)
        {
            this.RequiresAuthentication();

            _getUserTitleUow = userInformatioUow;

            Get[UserTitleRoute.GetUserTitle] = _ =>
            {
                return _getUserTitleUow.SetUserName(Context.CurrentUser.UserName)
                                       .GetResult();
            };
        }
    }
}
