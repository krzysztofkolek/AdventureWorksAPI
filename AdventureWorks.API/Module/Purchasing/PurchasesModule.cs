

namespace AdventureWorks.API.Module.Purchasing
{
    using Nancy;
    using Nancy.Security;
    using Route.Module.Purchasing;

    class PurchasesModule: NancyModule
    {
        public PurchasesModule()
            : base(PurchasesRoute.Base)
        {
            this.RequiresAuthentication();

            Get[PurchasesRoute.GetPurchase] = _ =>
            {
                return null;
            };
        }
    }
}
