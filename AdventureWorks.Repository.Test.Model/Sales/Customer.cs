namespace AdventureWorks.Repository.Test.Model.Sales
{
	public class Customer
	{
		public Individual _individual{ get; set; }
		public SalesTerritory _salesTerritory{ get; set; }
		public Store _store{ get; set; }
		public System.String _accountNumber{ get; set; }
		public System.Int32 _customerId{ get; set; }
		public System.String _customerType{ get; set; }
		public System.DateTime _modifiedDate{ get; set; }
		public System.Guid _rowguid{ get; set; }
	}
}
