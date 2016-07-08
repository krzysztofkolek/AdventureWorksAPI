namespace AdventureWorks.Repository.Test.Model.Sales
{
    using HumanResources;
    using System;

	public class SalesPerson
	{
		public Employee _employee{ get; set; }
		public SalesTerritory _salesTerritory{ get; set; }
		public System.Decimal _bonus{ get; set; }
		public System.Decimal _commissionPct{ get; set; }
		public System.DateTime _modifiedDate{ get; set; }
		public System.Guid _rowguid{ get; set; }
		public System.Decimal _salesLastYear{ get; set; }
		public System.Int32 _salesPersonId{ get; set; }
		public Nullable<System.Decimal> _salesQuota{ get; set; }
		public System.Decimal _salesYtd{ get; set; }
	}
}
