
namespace AdventureWorks.UOW.Person
{
    using System;
    using Main;
    using Model.Person;

    public class GetUserIfCorectForHashedPasswordUow : BaseUOW<AuthenticationUOWModel>
    {
        private AuthenticationUOW _authenticationUow;

        private String _userName { get; set; }
        private String _password { get; set; }


        public GetUserIfCorectForHashedPasswordUow(AuthenticationUOW authenticationUow)
        {
            _authenticationUow = authenticationUow;
        }


        public GetUserIfCorectForHashedPasswordUow SetUserName(string username)
        {
            _userName = username;
            return this;
        }

        public GetUserIfCorectForHashedPasswordUow SetPassword(string password)
        {
            _password = password;
            return this;
        }

        public override AuthenticationUOWModel GetResult()
        {
            return _authenticationUow.ValidateHashedPassword(_userName, _password);
        }
    }
}
