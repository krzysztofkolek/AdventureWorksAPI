namespace AdventureWorks.API.Model.Module.Auth
{
    using System;
    using System.Collections.Generic;

    public class BaseAuthModel
    {
        public String Token { get; set; }
        public List<String> Claims { get; set; }
    }
}