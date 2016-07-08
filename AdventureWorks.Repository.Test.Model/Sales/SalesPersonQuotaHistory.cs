namespace AdventureWorks.Repository.Test.Model.Sales
{
	public class SalesPersonQuotaHistory
	{
		public SalesPerson _salesPerson{ get; set; }
		public System.DateTime _modifiedDate{ get; set; }
		public System.DateTime _quotaDate{ get; set; }
		public System.Guid _rowguid{ get; set; }
		public System.Decimal _salesQuota{ get; set; }
	}
}
