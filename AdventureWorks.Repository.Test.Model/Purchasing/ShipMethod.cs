namespace AdventureWorks.Repository.Test.Model.Purchasing
{
    using Sales;

	public class ShipMethod
	{
		public System.DateTime ModifiedDate{ get; set; }
		public System.String Name{ get; set; }
		public System.Guid Rowguid{ get; set; }
		public System.Decimal ShipBase{ get; set; }
		public System.Int32 ShipMethodId{ get; set; }
		public System.Decimal ShipRate{ get; set; }
	}
}
