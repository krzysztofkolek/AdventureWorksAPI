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

    public class GetUserTitleUOW : BaseUOW<UserTitleViewModel>
    {
        private readonly ContactRepository<Contact> _contactRepository;
        private readonly EmployeeRepository<Employee> _employeeRepository;
        private readonly UserTitleViewModelBuilder _userTitleViewModelBuilder;


        public GetUserTitleUOW(EmployeeRepository<Employee> employeeRepository,
            ContactRepository<Contact> contactRepository, UserTitleViewModelBuilder userTitleViewModelBuilder)
        {
            _contactRepository = contactRepository;
            _employeeRepository = employeeRepository;
            _userTitleViewModelBuilder = userTitleViewModelBuilder;
        }

        private String _userName { get; set; }

        public GetUserTitleUOW SetUserName(string username)
        {
            _userName = username;
            return this;
        }

        public override UserTitleViewModel GetResult()
        {
            Contact userContact = _contactRepository.SearchFor(x => x.EmailAddress.Equals(_userName)).FirstOrDefault();
            Employee userEmployee =
                _employeeRepository.SearchFor(x => x.Contact.ContactId.Equals(userContact.ContactId)).FirstOrDefault();

            return _userTitleViewModelBuilder.SetTitle(userEmployee.Title)
                .Build();
        }
    }
}