namespace AdventureWorks.Repository.Test.Model.Purchasing
{
    using Person;
    using Production;
    using System;

	public class ProductVendor
	{
		public Product Product{ get; set; }
		public UnitMeasure UnitMeasure{ get; set; }
		public Vendor Vendor{ get; set; }
		public System.Int32 AverageLeadTime{ get; set; }
		public Nullable<System.Decimal> LastReceiptCost{ get; set; }
		public Nullable<System.DateTime> LastReceiptDate{ get; set; }
		public System.Int32 MaxOrderQty{ get; set; }
		public System.Int32 MinOrderQty{ get; set; }
		public System.DateTime ModifiedDate{ get; set; }
		public Nullable<System.Int32> OnOrderQty{ get; set; }
		public System.Decimal StandardPrice{ get; set; }
	}
}
