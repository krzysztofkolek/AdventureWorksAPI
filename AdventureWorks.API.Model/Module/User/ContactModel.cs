namespace AdventureWorks.API.Model.Module.User
{
    using System;
    using UOW.Model.Person;

    public class ContactModel
    {
        public ContactModel()
        {
        }

        public ContactModel(ContactViewModel contactViewModel)
        {
            EmailAddress = contactViewModel.EmailAddress;
            FirstName = contactViewModel.FirstName;
            LastName = contactViewModel.LastName;
            MiddleName = contactViewModel.MiddleName;
            Phone = contactViewModel.Phone;
            Title = contactViewModel.Title;
        }

        public String EmailAddress { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String MiddleName { get; set; }
        public String Phone { get; set; }
        public String Title { get; set; }
    }
}