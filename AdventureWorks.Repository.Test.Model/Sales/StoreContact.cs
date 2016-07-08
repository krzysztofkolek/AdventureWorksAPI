namespace AdventureWorks.Repository.Test.Model.Sales
{
    using Person;

    public class StoreContact
    {
        public Contact _contact { get; set; }
        public ContactType _contactType { get; set; }
        public Store _store { get; set; }
        public System.DateTime _modifiedDate { get; set; }
        public System.Guid _rowguid { get; set; }
    }
}
