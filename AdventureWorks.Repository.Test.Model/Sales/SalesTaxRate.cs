namespace AdventureWorks.Repository.Test.Model.Sales
{
    using Person;

	public class SalesTaxRate
	{
		public StateProvince StateProvince{ get; set; }
		public System.DateTime ModifiedDate{ get; set; }
		public System.String Name{ get; set; }
		public System.Guid Rowguid{ get; set; }
		public System.Int32 SalesTaxRateId{ get; set; }
		public System.Decimal TaxRate{ get; set; }
		public System.Byte TaxType{ get; set; }
	}
}
