namespace AdventureWorks.Repository.Test.Model.Sales
{
    using Person;

	public class CustomerAddress
	{
		public Address Address{ get; set; }
		public AddressType AddressType{ get; set; }
		public Customer Customer{ get; set; }
		public System.DateTime ModifiedDate{ get; set; }
		public System.Guid Rowguid{ get; set; }
	}
}
