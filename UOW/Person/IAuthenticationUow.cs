namespace AdventureWorks.UOW.Person
{
    using Model.Person;

    public interface IAuthenticationUow
    {
        AuthenticationUOWModel ValidateHashedPassword(string username, string password);
    }
}