namespace AdventureWorks.API.Route.Module.HumanResources
{
    using System;

    public static class EmployeesRoute
    {
        public static String Base
        {
            get { return "/employees"; }
        }

        public static String GetEmployees
        {
            get
            {
                return String.Format("{0}{1}", GetEmployeesMethod, GetEmployeesParameters);
            }
        }


        private static String GetEmployeesMethod
        {
            get
            {
                return "/getEmployees";
            }
        }
        private static String GetEmployeesParameters
        {
            get
            {
                return "/{page}";
            }
        }
    }
}
