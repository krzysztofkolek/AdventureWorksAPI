namespace AdventureWorks.Repository.Test.Model.Sales
{
    using Person;

	public class SalesTerritory
	{
		public System.Decimal CostLastYear{ get; set; }
		public System.Decimal CostYtd{ get; set; }
		public System.String CountryRegionCode{ get; set; }
		public System.String _group{ get; set; }
		public System.DateTime ModifiedDate{ get; set; }
		public System.String Name{ get; set; }
		public System.Guid Rowguid{ get; set; }
		public System.Decimal SalesLastYear{ get; set; }
		public System.Decimal SalesYtd{ get; set; }
		public System.Int32 TerritoryId{ get; set; }
	}
}
