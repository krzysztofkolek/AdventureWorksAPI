namespace AdventureWorks.UOW.Model.Person
{
    using System.Collections.Generic;

    public class AuthenticationUOWModel
    {
        public string UserName { get; set; }
        public IEnumerable<string> Claims { get; set; }
    }
}