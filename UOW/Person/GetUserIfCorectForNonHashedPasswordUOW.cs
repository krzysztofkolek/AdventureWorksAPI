namespace AdventureWorks.UOW.Person
{
    using System;
    using EntityClasses.Person;
    using Main;
    using Model.Person;
    using Repository.dbo;

    public class GetUserIfCorectForNonHashedPasswordUOW : BaseUOW<AuthenticationUOWModel>
    {
        private ContactRepository<Contact> _contactRepository = new ContactRepository<Contact>();

        private String _userName { get; set; }
        private String _password { get; set; }

        public GetUserIfCorectForNonHashedPasswordUOW SetUserName(string username)
        {
            _userName = username;
            return this;
        }

        public GetUserIfCorectForNonHashedPasswordUOW SetPassword(string password)
        {
            _password = password;
            return this;
        }

        public override AuthenticationUOWModel GetResult()
        {
            return AuthenticationUOW.ValidateNonHashedPassword(_userName, _password);
        }
    }
}
