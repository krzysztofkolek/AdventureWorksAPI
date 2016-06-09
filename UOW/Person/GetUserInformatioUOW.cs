namespace AdventureWorks.UOW.Person
{
    using System;
    using System.Linq;
    using Builder;
    using EntityClasses.HumanResources;
    using EntityClasses.Person;
    using Main;
    using Model.Person;
    using Repository.dbo;

    public class GetUserInformatioUOW : BaseUOW<UserInformationViewModel>
    {
        private ContactRepository<Contact> _contactRepository;
        private EmployeeRepository<Employee> _employeeRepository;
        private UserInformationViewModelBuilder _userInformationViewModelBuilder;

        private String _userName { get; set; }


        public GetUserInformatioUOW(EmployeeRepository<Employee> employeeRepository, ContactRepository<Contact> contactRepository, UserInformationViewModelBuilder userInformationViewModelBuilder)
        {
            _contactRepository = contactRepository;
            _employeeRepository = employeeRepository;
            _userInformationViewModelBuilder = userInformationViewModelBuilder;
        }
        
        public GetUserInformatioUOW SetUserName(string username)
        {
            _userName = username;
            return this;
        }

        public override UserInformationViewModel GetResult()
        {
            var userContact = _contactRepository.SearchFor(x => x.EmailAddress.Equals(_userName)).FirstOrDefault();
            var userEmployee = _employeeRepository.SearchFor(x => x.Contact.ContactId.Equals(userContact.ContactId)).FirstOrDefault();

            return _userInformationViewModelBuilder.SetContact(userContact)
                                                   .SetEmployee(userEmployee)
                                                   .Build();
        }
    }
}
