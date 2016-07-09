namespace AdventureWorks.Repository.Test.Model.Sales
{
    using Person;

    public class StoreContact
    {
        public Contact Contact { get; set; }
        public ContactType ContactType { get; set; }
        public Store Store { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public System.Guid Rowguid { get; set; }
    }
}
