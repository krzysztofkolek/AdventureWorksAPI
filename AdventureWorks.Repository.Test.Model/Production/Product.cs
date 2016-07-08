namespace AdventureWorks.Repository.Test.Model.Production
{
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using Purchasing;
    using Sales;

	public class Product
	{
		public ProductModel _productModel{ get; set; }		
		public ProductSubcategory _productSubcategory{ get; set; }
		public UnitMeasure _unitMeasure{ get; set; }
		public UnitMeasure _unitMeasure1{ get; set; }
		public System.String _class{ get; set; }
		public System.String _color{ get; set; }
		public System.Int32 _daysToManufacture{ get; set; }
		public Nullable<System.DateTime> _discontinuedDate{ get; set; }
		public System.Boolean _finishedGoodsFlag{ get; set; }
		public System.Decimal _listPrice{ get; set; }
		public System.Boolean _makeFlag{ get; set; }
		public System.DateTime _modifiedDate{ get; set; }
		public System.String _name{ get; set; }
		public System.Int32 _productId{ get; set; }
		public System.String _productLine{ get; set; }
		public System.String _productNumber{ get; set; }
		public System.Int16 _reorderPoint{ get; set; }
		public System.Guid _rowguid{ get; set; }
		public System.Int16 _safetyStockLevel{ get; set; }
		public Nullable<System.DateTime> _sellEndDate{ get; set; }
		public System.DateTime _sellStartDate{ get; set; }
		public System.String _size{ get; set; }
		public System.Decimal _standardCost{ get; set; }
		public System.String _style{ get; set; }
		public Nullable<System.Decimal> _weight{ get; set; }
	}
}
