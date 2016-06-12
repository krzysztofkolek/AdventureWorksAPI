namespace AdventureWorks.API.Model.Module.User
{
    using Auth;
    using Base;
    using UOW.Model.Person;

    public class GetUserInformationModel : BaseAuthModel, IBuilder<GetUserInformationModel>
    {
        public EmployeeModel EmployeeVM { get; set; }
        public ContactModel ContactVM { get; set; }
        private UserInformationViewModel _userInformationViewModel { get; set; }

        public GetUserInformationModel()
        {
        }

        public GetUserInformationModel(UserInformationViewModel userInformationViewModel)
        {
            _userInformationViewModel = userInformationViewModel;
            Build();
        }

        public GetUserInformationModel Build()
        {
            if (_userInformationViewModel.EmployeeVM != null)
            {
                EmployeeVM = new EmployeeModel(_userInformationViewModel.EmployeeVM);
            }
            if (_userInformationViewModel.ContactVM != null)
            {
                ContactVM = new ContactModel(_userInformationViewModel.ContactVM);
            }
            return this;
        }
    }
}
