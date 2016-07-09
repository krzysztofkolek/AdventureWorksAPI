namespace AdventureWorks.Repository.Test.Model.Purchasing
{
    using HumanResources;
    using System;

	public class PurchaseOrderHeader
	{
		public Employee Employee{ get; set; }
		public ShipMethod ShipMethod{ get; set; }
		public Vendor Vendor{ get; set; }
		public System.Decimal Freight{ get; set; }
		public System.DateTime ModifiedDate{ get; set; }
		public System.DateTime OrderDate{ get; set; }
		public System.Int32 PurchaseOrderId{ get; set; }
		public System.Byte RevisionNumber{ get; set; }
		public Nullable<System.DateTime> ShipDate{ get; set; }
		public System.Byte Status{ get; set; }
		public System.Decimal SubTotal{ get; set; }
		public System.Decimal TaxAmt{ get; set; }
		public System.Decimal TotalDue{ get; set; }
	}
}
