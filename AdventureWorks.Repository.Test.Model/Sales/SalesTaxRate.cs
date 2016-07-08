namespace AdventureWorks.Repository.Test.Model.Sales
{
    using Person;

	public class SalesTaxRate
	{
		public StateProvince _stateProvince{ get; set; }
		public System.DateTime _modifiedDate{ get; set; }
		public System.String _name{ get; set; }
		public System.Guid _rowguid{ get; set; }
		public System.Int32 _salesTaxRateId{ get; set; }
		public System.Decimal _taxRate{ get; set; }
		public System.Byte _taxType{ get; set; }
	}
}
