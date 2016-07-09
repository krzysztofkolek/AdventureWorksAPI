namespace AdventureWorks.Repository.Test.Model.Sales
{
	public class Customer
	{
		public Individual Individual{ get; set; }
		public SalesTerritory SalesTerritory{ get; set; }
		public Store Store{ get; set; }
		public System.String AccountNumber{ get; set; }
		public System.Int32 CustomerId{ get; set; }
		public System.String CustomerType{ get; set; }
		public System.DateTime ModifiedDate{ get; set; }
		public System.Guid Rowguid{ get; set; }
	}
}
