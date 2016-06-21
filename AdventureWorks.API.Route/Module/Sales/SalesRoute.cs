namespace AdventureWorks.API.Route.Module.Sales
{
    using System;

    public static class SalesRoute
    {
        public static string Base
        {
            get { return ""; }
        }

        public static string GetSales
        {
            get { return String.Format("{0}{1}", GeSalesMethod, GetSalesParameters); }
        }

        private static String GeSalesMethod
        {
            get
            {
                return "/getSales";
            }
        }
        private static String GetSalesParameters
        {
            get
            {
                return "/{page}";
            }
        }
    }
}
