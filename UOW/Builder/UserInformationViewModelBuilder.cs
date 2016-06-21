namespace AdventureWorks.UOW.Builder
{
    using EntityClasses.HumanResources;
    using EntityClasses.Person;
    using Model.Person;

    public class UserInformationViewModelBuilder : Builder<UserInformationViewModel>
    {
        private Contact _contact { get; set; }
        private Employee _employee { get; set; }

        public UserInformationViewModelBuilder SetContact(Contact contact)
        {
            _contact = contact;
            return this;
        }

        public UserInformationViewModelBuilder SetEmployee(Employee employee)
        {
            _employee = employee;
            return this;
        }

        public override UserInformationViewModel Build()
        {
            var model = new UserInformationViewModel();

            if (_contact != null)
            {
                model.ContactVM = new ContactViewModel();
                model.ContactVM.EmailAddress = _contact.EmailAddress;
                model.ContactVM.FirstName = _contact.FirstName;
                model.ContactVM.LastName = _contact.LastName;
                model.ContactVM.MiddleName = _contact.MiddleName;
                model.ContactVM.Phone = _contact.Phone;
                model.ContactVM.Title = _contact.Title;
            }

            if (_employee != null)
            {
                model.EmployeeVM = new EmployeeViewModel();
                model.EmployeeVM.BirthDate = _employee.BirthDate;
                model.EmployeeVM.Gender = _employee.Gender;
                model.EmployeeVM.HireDate = _employee.HireDate;
            }

            return model;
        }
    }
}