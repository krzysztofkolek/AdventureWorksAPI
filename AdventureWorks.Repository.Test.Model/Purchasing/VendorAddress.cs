namespace AdventureWorks.Repository.Test.Model.Purchasing
{
    using Person;

	public class VendorAddress
	{
		public Address Address{ get; set; }
		public AddressType AddressType{ get; set; }
		public Vendor Vendor{ get; set; }
		public System.DateTime ModifiedDate{ get; set; }
	}
}
