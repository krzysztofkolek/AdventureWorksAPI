namespace AdventureWorks.API.Route.Module.Person
{
    using System;

    public static class CustomersRoute
    {
        public static string Base {
            get { return ""; }
        }

        public static string GetCustomers
        {
            get { return String.Format("{0}{1}", GetCustomersMethod, GetCustomersParameters); }
        }

        private static String GetCustomersMethod
        {
            get
            {
                return "/getCustomers";
            }
        }
        private static String GetCustomersParameters
        {
            get
            {
                return "/{page}";
            }
        }
    }
}
