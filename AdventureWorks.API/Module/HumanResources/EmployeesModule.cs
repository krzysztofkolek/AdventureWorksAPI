namespace AdventureWorks.API.Module.HumanResources
{
    using Nancy;
    using Nancy.Security;
    using Route.Module.HumanResources;
    using UOW.HumanResources;

    public class EmployeesModule : NancyModule
    {
        private GetEmployeesUOW _getEmployeesUow { get; set; }

        public EmployeesModule(GetEmployeesUOW getEmployeesUow)
            : base(EmployeesRoute.Base)
        {
            this.RequiresAuthentication();

            _getEmployeesUow = getEmployeesUow;
            
            Get[EmployeesRoute.GetEmployees] = _ =>
            {
                int page = int.Parse(Request.Query["page"].Value);
                return _getEmployeesUow.SetPage(page)
                                       .GetResult();
            };


        }
    }
}
