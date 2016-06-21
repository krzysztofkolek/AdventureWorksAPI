namespace AdventureWorks.API.Module.HumanResources
{
    using Nancy;
    using Nancy.Security;
    using Route.Module.HumanResources;

    public class EmployeesModule : NancyModule
    {
        public EmployeesModule()
            : base(EmployeesRoute.Base)
        {
            this.RequiresAuthentication();
            
            Get[EmployeesRoute.GetEmployees] = _ =>
            {
                return null;
            };


        }
    }
}
