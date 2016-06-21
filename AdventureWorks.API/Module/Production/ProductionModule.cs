namespace AdventureWorks.API.Module.Production
{
    using Nancy;
    using Nancy.Security; 
    using Route.Module.Production;

    public class ProductionModule: NancyModule
    {
        public ProductionModule()
            : base(ProductionRoute.Base)
        {
            this.RequiresAuthentication();

            Get[ProductionRoute.GetProduction] = _ =>
            {
                return null;
            };


        }
    }
}
