namespace AdventureWorks.Repository.Test.Model.Purchasing
{
    using HumanResources;
    using System;

	public class PurchaseOrderHeader
	{
		public Employee _employee{ get; set; }
		public ShipMethod _shipMethod{ get; set; }
		public Vendor _vendor{ get; set; }
		public System.Decimal _freight{ get; set; }
		public System.DateTime _modifiedDate{ get; set; }
		public System.DateTime _orderDate{ get; set; }
		public System.Int32 _purchaseOrderId{ get; set; }
		public System.Byte _revisionNumber{ get; set; }
		public Nullable<System.DateTime> _shipDate{ get; set; }
		public System.Byte _status{ get; set; }
		public System.Decimal _subTotal{ get; set; }
		public System.Decimal _taxAmt{ get; set; }
		public System.Decimal _totalDue{ get; set; }
	}
}
