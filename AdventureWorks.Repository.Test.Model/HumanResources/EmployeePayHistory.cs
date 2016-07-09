namespace AdventureWorks.Repository.Test.Model.HumanResources
{

    public class EmployeePayHistory
    {
        public Employee Employee { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public System.Byte PayFrequency { get; set; }
        public System.Decimal Rate { get; set; }
        public System.DateTime RateChangeDate { get; set; }
    }
}
