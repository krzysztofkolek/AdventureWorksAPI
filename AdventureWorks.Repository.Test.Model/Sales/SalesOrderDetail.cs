namespace AdventureWorks.Repository.Test.Model.Sales
{
	public class SalesOrderDetail
	{
		public SalesOrderHeader SalesOrderHeader{ get; set; }
		public SpecialOfferProduct SpecialOfferProduct{ get; set; }
		public System.String CarrierTrackingNumber{ get; set; }
		public System.Decimal LineTotal{ get; set; }
		public System.DateTime ModifiedDate{ get; set; }
		public System.Int16 OrderQty{ get; set; }
		public System.Guid Rowguid{ get; set; }
		public System.Int32 SalesOrderDetailId{ get; set; }
		public System.Decimal UnitPrice{ get; set; }
		public System.Decimal UnitPriceDiscount{ get; set; }
	}
}
