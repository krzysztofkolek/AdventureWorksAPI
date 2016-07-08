namespace AdventureWorks.Repository.Test.Model.HumanResources
{

    using Person;
    using Sales;
    using System;

    public class Employee
    {
        public Employee _employeeNav{ get; set; }
        public Contact _contact{ get; set; }
        public SalesPerson _salesPerson{ get; set; }
        public DateTime _birthDate{ get; set; }
        public Boolean _currentFlag{ get; set; }
        public Int32 _employeeId{ get; set; }
        public String _gender{ get; set; }
        public DateTime _hireDate{ get; set; }
        public String _loginId{ get; set; }
        public String _maritalStatus{ get; set; }
        public DateTime _modifiedDate{ get; set; }
        public String _nationalIdnumber{ get; set; }
        public Guid _rowguid{ get; set; }
        public Boolean _salariedFlag{ get; set; }
        public Int16 _sickLeaveHours{ get; set; }
        public String _title{ get; set; }
        public Int16 _vacationHours{ get; set; }
    }
}
