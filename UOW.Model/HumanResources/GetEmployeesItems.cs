namespace AdventureWorks.UOW.Model.HumanResources
{
    using System;
    public class GetEmployeesItems
    {
        public int Id { get; set; }
        public String FullName { get; set; }
        public String Title { get; set; }
        public String ManagerFullName { get; set; }
        public String HireDate { get; set; }
        public String Salary { get; set; }
    }
}
