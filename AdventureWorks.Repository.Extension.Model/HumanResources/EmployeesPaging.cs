namespace AdventureWorks.Repository.Extension.Model.HumanResources
{
    using System;

    public class EmployeesPaging
    {
        public int Id { get; set; }
        public String FullName { get; set; }
        public String Title { get; set; }
        public String ManagerFullName { get; set; }
        public String HireDate { get; set; }
        public String Salary { get; set; }
    }
}
