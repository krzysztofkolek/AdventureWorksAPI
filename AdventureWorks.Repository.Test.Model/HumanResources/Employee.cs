namespace AdventureWorks.Repository.Test.Model.HumanResources
{

    using Person;
    using Sales;
    using System;

    public class Employee
    {
        public Employee EmployeeNav { get; set; }
        public Contact Contact { get; set; }
        public SalesPerson SalesPerson { get; set; }
        public DateTime BirthDate { get; set; }
        public Boolean CurrentFlag { get; set; }
        public Int32 EmployeeId { get; set; }
        public String Gender { get; set; }
        public DateTime HireDate { get; set; }
        public String LoginId { get; set; }
        public String MaritalStatus { get; set; }
        public DateTime ModifiedDate { get; set; }
        public String NationalIdnumber { get; set; }
        public Guid Rowguid { get; set; }
        public Boolean SalariedFlag { get; set; }
        public Int16 SickLeaveHours { get; set; }
        public String Title { get; set; }
        public Int16 VacationHours { get; set; }
    }
}
