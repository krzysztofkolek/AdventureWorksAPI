namespace AdventureWorks.API.Module.Sales
{
    using Nancy;
    using Nancy.Security;
    using Route.Module.Sales;

    class SalesModule: NancyModule
    {
        public SalesModule()
            : base(SalesRoute.Base)
        {
            this.RequiresAuthentication();

            Get[SalesRoute.GetSales] = _ =>
            {
                return null;
            };
        }
    }
}
