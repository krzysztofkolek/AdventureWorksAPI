namespace AdventureWorks.Repository.Test.Model.Sales
{
	public class Store
	{
		public Customer Customer{ get; set; }
		public SalesPerson SalesPerson{ get; set; }
		public System.Int32 CustomerId{ get; set; }
		public System.String Demographics{ get; set; }
		public System.DateTime ModifiedDate{ get; set; }
		public System.String Name{ get; set; }
		public System.Guid Rowguid{ get; set; }
	}
}
