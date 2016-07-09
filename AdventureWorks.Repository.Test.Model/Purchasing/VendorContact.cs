namespace AdventureWorks.Repository.Test.Model.Purchasing
{
    using Person;

	public class VendorContact
	{
		public Contact Contact{ get; set; }
		public ContactType ContactType{ get; set; }
		public Vendor Vendor{ get; set; }
		public System.DateTime ModifiedDate{ get; set; }
	}
}
