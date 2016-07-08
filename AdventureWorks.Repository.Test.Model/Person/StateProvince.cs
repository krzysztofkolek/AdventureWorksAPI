
namespace AdventureWorks.Repository.Test.Model.Person
{
    using Sales;

	public class StateProvince
	{
		public CountryRegion _countryRegion{ get; set; }
		public SalesTerritory _salesTerritory{ get; set; }
		public System.Boolean _isOnlyStateProvinceFlag{ get; set; }
		public System.DateTime _modifiedDate{ get; set; }
		public System.String _name{ get; set; }
		public System.Guid _rowguid{ get; set; }
		public System.String _stateProvinceCode{ get; set; }
		public System.Int32 _stateProvinceId{ get; set; }
	}
}
