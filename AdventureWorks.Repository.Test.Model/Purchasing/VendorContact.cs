namespace AdventureWorks.Repository.Test.Model.Purchasing
{
    using Person;

	public class VendorContact
	{
		public Contact _contact{ get; set; }
		public ContactType _contactType{ get; set; }
		public Vendor _vendor{ get; set; }
		public System.DateTime _modifiedDate{ get; set; }
	}
}
