namespace AdventureWorks.API.Shared.Auth
{
    using Nancy.Security;
    using UOW.Person;

    public class UserDatabase
    {
        public static IUserIdentity ValidateUser(string userName, string password)
        {
            return new CustomUserIdentity(new GetUserIfCorectForHashedPasswordUOW().GetResult());
        }
    }
}
