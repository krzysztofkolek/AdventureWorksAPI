namespace AdventureWorks.Repository.Test.Model.Purchasing
{
    using Person;

	public class VendorAddress
	{
		public Address _address{ get; set; }
		public AddressType _addressType{ get; set; }
		public Vendor _vendor{ get; set; }
		public System.DateTime _modifiedDate{ get; set; }
	}
}
