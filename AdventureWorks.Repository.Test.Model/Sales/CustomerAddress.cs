namespace AdventureWorks.Repository.Test.Model.Sales
{
    using Person;

	public class CustomerAddress
	{
		public Address _address{ get; set; }
		public AddressType _addressType{ get; set; }
		public Customer _customer{ get; set; }
		public System.DateTime _modifiedDate{ get; set; }
		public System.Guid _rowguid{ get; set; }
	}
}
