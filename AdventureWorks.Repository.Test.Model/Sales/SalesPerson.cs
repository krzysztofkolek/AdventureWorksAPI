namespace AdventureWorks.Repository.Test.Model.Sales
{
    using HumanResources;
    using System;

	public class SalesPerson
	{
		public Employee Employee{ get; set; }
		public SalesTerritory SalesTerritory{ get; set; }
		public System.Decimal Bonus{ get; set; }
		public System.Decimal CommissionPct{ get; set; }
		public System.DateTime ModifiedDate{ get; set; }
		public System.Guid Rowguid{ get; set; }
		public System.Decimal SalesLastYear{ get; set; }
		public System.Int32 SalesPersonId{ get; set; }
		public Nullable<System.Decimal> SalesQuota{ get; set; }
		public System.Decimal SalesYtd{ get; set; }
	}
}
