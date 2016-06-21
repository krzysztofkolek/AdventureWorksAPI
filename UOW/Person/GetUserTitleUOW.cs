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
        private ContactRepository<Contact> _contactRepository;
        private EmployeeRepository<Employee> _employeeRepository;
        private UserTitleViewModelBuilder _userTitleViewModelBuilder;

        private String _userName { get; set; }


        public GetUserTitleUOW(EmployeeRepository<Employee> employeeRepository, ContactRepository<Contact> contactRepository, UserTitleViewModelBuilder userTitleViewModelBuilder)
        {
            _contactRepository = contactRepository;
            _employeeRepository = employeeRepository;
            _userTitleViewModelBuilder = userTitleViewModelBuilder;
        }

        public GetUserTitleUOW SetUserName(string username)
        {
            _userName = username;
            return this;
        }

        public override UserTitleViewModel GetResult()
        {
            var userContact = _contactRepository.SearchFor(x => x.EmailAddress.Equals(_userName)).FirstOrDefault();
            var userEmployee = _employeeRepository.SearchFor(x => x.Contact.ContactId.Equals(userContact.ContactId)).FirstOrDefault();

            return _userTitleViewModelBuilder.SetTitle(userEmployee.Title)
                                             .Build();
        }
    }
}
