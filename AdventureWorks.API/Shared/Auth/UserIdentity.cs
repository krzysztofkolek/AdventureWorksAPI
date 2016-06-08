namespace AdventureWorks.API.Shared.Auth
{
    using System.Collections.Generic;
    using Nancy.Security;
    using UOW.Model.Person;

    public class CustomUserIdentity : IUserIdentity
    {
        private IEnumerable<string> _claims;
        private string _userName;

        public CustomUserIdentity(AuthenticationUOWModel dbResult)
        {
            _claims = dbResult.Claims;
            _userName = dbResult.UserName;
        }

        public IEnumerable<string> Claims
        {
            get { return _claims; }
        }

        public string UserName
        {
            get { return _userName; }
        }
    }
}
