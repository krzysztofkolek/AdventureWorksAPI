namespace AdventureWorks.Repository.Test.Model.Purchasing
{
    using Person;
    using Production;
    using System;

	public class ProductVendor
	{
		public Product _product{ get; set; }
		public UnitMeasure _unitMeasure{ get; set; }
		public Vendor _vendor{ get; set; }
		public System.Int32 _averageLeadTime{ get; set; }
		public Nullable<System.Decimal> _lastReceiptCost{ get; set; }
		public Nullable<System.DateTime> _lastReceiptDate{ get; set; }
		public System.Int32 _maxOrderQty{ get; set; }
		public System.Int32 _minOrderQty{ get; set; }
		public System.DateTime _modifiedDate{ get; set; }
		public Nullable<System.Int32> _onOrderQty{ get; set; }
		public System.Decimal _standardPrice{ get; set; }
	}
}
