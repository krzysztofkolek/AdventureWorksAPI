namespace AdventureWorks.Repository.Test.Model.Sales
{
	public class SalesOrderDetail
	{
		public SalesOrderHeader _salesOrderHeader{ get; set; }
		public SpecialOfferProduct _specialOfferProduct{ get; set; }
		public System.String _carrierTrackingNumber{ get; set; }
		public System.Decimal _lineTotal{ get; set; }
		public System.DateTime _modifiedDate{ get; set; }
		public System.Int16 _orderQty{ get; set; }
		public System.Guid _rowguid{ get; set; }
		public System.Int32 _salesOrderDetailId{ get; set; }
		public System.Decimal _unitPrice{ get; set; }
		public System.Decimal _unitPriceDiscount{ get; set; }
	}
}
