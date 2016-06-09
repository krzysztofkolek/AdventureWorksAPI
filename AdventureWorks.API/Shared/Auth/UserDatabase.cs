namespace AdventureWorks.API.Shared.Auth
{
    using Nancy.Security;
    using UOW.Person;

    public class UserDatabase
    {
        private GetUserIfCorectForHashedPasswordUow _getUserIfCorectForHashedPasswordUow { get; set; }

        public UserDatabase(GetUserIfCorectForHashedPasswordUow getUserIfCorectForHashedPasswordUow)
        {
            _getUserIfCorectForHashedPasswordUow = getUserIfCorectForHashedPasswordUow;
        }

        public IUserIdentity ValidateUser(string userName, string password)
        {
            var user = _getUserIfCorectForHashedPasswordUow.SetUserName(userName)
                                                           .SetPassword(password)
                                                           .GetResult();
            if (user != null)
            {
                return new CustomUserIdentity(user);
            }
            return null;
        }
    }
}
