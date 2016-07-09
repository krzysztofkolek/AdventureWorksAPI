namespace AdventureWorks.Repository.Test.Model.HumanResources
{
    using System;

    public class EmployeeDepartmentHistory
    {
        public Department Department { get; set; }
        public Employee Employee { get; set; }
        public Shift Shift { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public System.DateTime StartDate { get; set; }


    }
}
