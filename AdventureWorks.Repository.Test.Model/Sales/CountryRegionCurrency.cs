namespace AdventureWorks.Repository.Test.Model.Sales
{
    using Person;

	public class CountryRegionCurrency
	{
		public CountryRegion CountryRegion{ get; set; }
		public Currency Currency{ get; set; }
		public System.DateTime ModifiedDate{ get; set; }
	}
}
