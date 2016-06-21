namespace AdventureWorks.API.Model.Module.HumanResources
{
    using System;

    public class HREmployee
    {
        public String FullName { get; set; }
        public String Title { get; set; }
        public String ManagerFullName { get; set; }
        public String HireDate { get; set; }
        public String Salary { get; set; }
    }
}