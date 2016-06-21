namespace AdventureWorks.API.Route.Module.Production
{
    using System;

    public static class ProductionRoute
    {
        public static string Base
        {
            get { return ""; }
        }


        public static string GetProduction
        {
            get { return String.Format("{0}{1}", GeProductionMethod, GetProductionParameters); }
        }

        private static String GeProductionMethod
        {
            get
            {
                return "/getProduction";
            }
        }
        private static String GetProductionParameters
        {
            get
            {
                return "/{page}";
            }
        }
    }
}
