namespace AdventureWorks.Repository.Test.Model.HumanResources
{
    using Person;

    public class EmployeeAddress
    {
        public Employee Employee{ get; set; }
        public Address Address{ get; set; }
        public System.DateTime NodifiedDate{ get; set; }
        public System.Guid Rowguid{ get; set; }
    }
}
