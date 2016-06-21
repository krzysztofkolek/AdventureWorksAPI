namespace AdventureWorks.API.Module.Person
{
    using Nancy;
    using Nancy.Security;
    using Route.Module.Person;

    public class CustomersModule: NancyModule
    {
        public CustomersModule()
            : base(CustomersRoute.Base)
        {
            this.RequiresAuthentication();

            Get[CustomersRoute.GetCustomers] = _ =>
            {
                return null;
            };


        }
    }
}
