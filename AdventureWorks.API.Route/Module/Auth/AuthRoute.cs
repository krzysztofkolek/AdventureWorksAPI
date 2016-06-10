namespace AdventureWorks.API.Route.Module.Auth
{
    using System;

    public static class AuthRoute
    {
        public static String Base {
            get { return "/auth"; }
        }

        public static String LoginPost
        {
            get { return "/"; }
        }

        public static String RegisterPost
        {
            get { return "/"; }
        }

    }
}
