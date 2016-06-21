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
    using Repository.HumanResources;

    public class GetUserInformatioUOW : BaseUOW<UserInformationViewModel>
    {
        private readonly ContactRepository<Contact> _contactRepository;
        private readonly EmployeeRepository<Employee> _employeeRepository;
        private readonly UserInformationViewModelBuilder _userInformationViewModelBuilder;


        public GetUserInformatioUOW(EmployeeRepository<Employee> employeeRepository,
            ContactRepository<Contact> contactRepository,
            UserInformationViewModelBuilder userInformationViewModelBuilder)
        {
            _contactRepository = contactRepository;
            _employeeRepository = employeeRepository;
            _userInformationViewModelBuilder = userInformationViewModelBuilder;
        }

        private String _userName { get; set; }

        public GetUserInformatioUOW SetUserName(string username)
        {
            _userName = username;
            return this;
        }

        public override UserInformationViewModel GetResult()
        {
            Contact userContact = _contactRepository.SearchFor(x => x.EmailAddress.Equals(_userName)).FirstOrDefault();
            Employee userEmployee =
                _employeeRepository.SearchFor(x => x.Contact.ContactId.Equals(userContact.ContactId)).FirstOrDefault();

            return _userInformationViewModelBuilder.SetContact(userContact)
                .SetEmployee(userEmployee)
                .Build();
        }
    }
}