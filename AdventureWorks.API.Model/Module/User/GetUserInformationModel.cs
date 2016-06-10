namespace AdventureWorks.API.Model.Module.User
{
    using Auth;

    public class GetUserInformationModel : BaseAuthModel
    {
        public EmployeeModel EmployeeVM { get; set; }
        public ContactModel ContactVM { get; set; }
    }
}
