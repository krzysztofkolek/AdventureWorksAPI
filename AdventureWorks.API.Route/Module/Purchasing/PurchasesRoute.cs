namespace AdventureWorks.API.Route.Module.Purchasing
{
    using System;

    public static class PurchasesRoute
    {
        public static string Base
        {
            get { return ""; }
        } 

        public static string GetPurchase
        {
            get { return String.Format("{0}{1}", GePurchaseMethod, GetPurchaseParameters); }
        }

        private static String GePurchaseMethod
        {
            get
            {
                return "/getPurchase";
            }
        }
        private static String GetPurchaseParameters
        {
            get
            {
                return "/{page}";
            }
        }
    }
}
