namespace AdventureWorks.Repository.Test.Model.Sales
{
	public class SalesPersonQuotaHistory
	{
		public SalesPerson SalesPerson{ get; set; }
		public System.DateTime ModifiedDate{ get; set; }
		public System.DateTime QuotaDate{ get; set; }
		public System.Guid Rowguid{ get; set; }
		public System.Decimal SalesQuota{ get; set; }
	}
}
