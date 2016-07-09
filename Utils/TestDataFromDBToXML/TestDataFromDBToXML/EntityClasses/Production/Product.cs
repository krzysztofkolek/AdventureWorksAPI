﻿namespace AdventureWorks.EntityClasses.Production
{
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using Purchasing;
    using Sales;

    /// <summary>Class which represents the entity 'Production.Product'</summary>
	public partial class Product
	{
		#region Class Member Declarations
		private ISet<BillOfMaterial> _billOfMaterials;
		private ISet<BillOfMaterial> _billOfMaterials1;
		private ISet<ProductCostHistory> _productCostHistories;
		private ISet<ProductDocument> _productDocuments;
		private ISet<ProductInventory> _productInventories;
		private ISet<ProductListPriceHistory> _productListPriceHistories;
		private ProductModel _productModel;
		private ISet<ProductProductPhoto> _productProductPhotos;
		private ISet<ProductReview> _productReviews;
		private ProductSubcategory _productSubcategory;
		private ISet<TransactionHistory> _transactionHistories;
		private UnitMeasure _unitMeasure;
		private UnitMeasure _unitMeasure1;
		private ISet<WorkOrder> _workOrders;
		private ISet<ProductVendor> _productVendors;
		private ISet<PurchaseOrderDetail> _purchaseOrderDetails;
		private ISet<ShoppingCartItem> _shoppingCartItems;
		private ISet<SpecialOfferProduct> _specialOfferProducts;
		private System.String _class;
		private System.String _color;
		private System.Int32 _daysToManufacture;
		private Nullable<System.DateTime> _discontinuedDate;
		private System.Boolean _finishedGoodsFlag;
		private System.Decimal _listPrice;
		private System.Boolean _makeFlag;
		private System.DateTime _modifiedDate;
		private System.String _name;
		private System.Int32 _productId;
		private System.String _productLine;
		private System.String _productNumber;
		private System.Int16 _reorderPoint;
		private System.Guid _rowguid;
		private System.Int16 _safetyStockLevel;
		private Nullable<System.DateTime> _sellEndDate;
		private System.DateTime _sellStartDate;
		private System.String _size;
		private System.Decimal _standardCost;
		private System.String _style;
		private Nullable<System.Decimal> _weight;
		#endregion

		/// <summary>Initializes a new instance of the <see cref="Product"/> class.</summary>
		public Product() : base()
		{
			_billOfMaterials = new HashSet<BillOfMaterial>();
			_billOfMaterials1 = new HashSet<BillOfMaterial>();
			_productCostHistories = new HashSet<ProductCostHistory>();
			_productDocuments = new HashSet<ProductDocument>();
			_productInventories = new HashSet<ProductInventory>();
			_productListPriceHistories = new HashSet<ProductListPriceHistory>();
			_productProductPhotos = new HashSet<ProductProductPhoto>();
			_productReviews = new HashSet<ProductReview>();
			_transactionHistories = new HashSet<TransactionHistory>();
			_workOrders = new HashSet<WorkOrder>();
			_productVendors = new HashSet<ProductVendor>();
			_purchaseOrderDetails = new HashSet<PurchaseOrderDetail>();
			_shoppingCartItems = new HashSet<ShoppingCartItem>();
			_specialOfferProducts = new HashSet<SpecialOfferProduct>();
			_productId = default(System.Int32);
			OnCreated();
		}

		/// <summary>Method called from the constructor</summary>
		partial void OnCreated();

		/// <summary>Returns a hash code for this instance.</summary>
		/// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
		public override int GetHashCode()
		{
			int toReturn = base.GetHashCode();
			toReturn ^= this.ProductId.GetHashCode();
			return toReturn;
		}
	
		/// <summary>Determines whether the specified object is equal to this instance.</summary>
		/// <param name="obj">The <see cref="System.Object"/> to compare with this instance.</param>
		/// <returns><c>true</c> if the specified <see cref="System.Object"/> is equal to this instance; otherwise, <c>false</c>.</returns>
		public override bool Equals(object obj)
		{
			if(obj == null) 
			{
				return false;
			}
			Product toCompareWith = obj as Product;
			return toCompareWith == null ? false : ((this.ProductId == toCompareWith.ProductId));
		}
		

		#region Class Property Declarations
		/// <summary>Gets or sets the Class field. </summary>	
		public virtual System.String Class
		{ 
			get { return _class; }
			set { _class = value; }
		}

		/// <summary>Gets or sets the Color field. </summary>	
		public virtual System.String Color
		{ 
			get { return _color; }
			set { _color = value; }
		}

		/// <summary>Gets or sets the DaysToManufacture field. </summary>	
		public virtual System.Int32 DaysToManufacture
		{ 
			get { return _daysToManufacture; }
			set { _daysToManufacture = value; }
		}

		/// <summary>Gets or sets the DiscontinuedDate field. </summary>	
		public virtual Nullable<System.DateTime> DiscontinuedDate
		{ 
			get { return _discontinuedDate; }
			set { _discontinuedDate = value; }
		}

		/// <summary>Gets or sets the FinishedGoodsFlag field. </summary>	
		public virtual System.Boolean FinishedGoodsFlag
		{ 
			get { return _finishedGoodsFlag; }
			set { _finishedGoodsFlag = value; }
		}

		/// <summary>Gets or sets the ListPrice field. </summary>	
		public virtual System.Decimal ListPrice
		{ 
			get { return _listPrice; }
			set { _listPrice = value; }
		}

		/// <summary>Gets or sets the MakeFlag field. </summary>	
		public virtual System.Boolean MakeFlag
		{ 
			get { return _makeFlag; }
			set { _makeFlag = value; }
		}

		/// <summary>Gets or sets the ModifiedDate field. </summary>	
		public virtual System.DateTime ModifiedDate
		{ 
			get { return _modifiedDate; }
			set { _modifiedDate = value; }
		}

		/// <summary>Gets or sets the Name field. </summary>	
		public virtual System.String Name
		{ 
			get { return _name; }
			set { _name = value; }
		}

		/// <summary>Gets the ProductId field. </summary>	
		public virtual System.Int32 ProductId
		{ 
			get { return _productId; }
		}

		/// <summary>Gets or sets the ProductLine field. </summary>	
		public virtual System.String ProductLine
		{ 
			get { return _productLine; }
			set { _productLine = value; }
		}

		/// <summary>Gets or sets the ProductNumber field. </summary>	
		public virtual System.String ProductNumber
		{ 
			get { return _productNumber; }
			set { _productNumber = value; }
		}

		/// <summary>Gets or sets the ReorderPoint field. </summary>	
		public virtual System.Int16 ReorderPoint
		{ 
			get { return _reorderPoint; }
			set { _reorderPoint = value; }
		}

		/// <summary>Gets or sets the Rowguid field. </summary>	
		public virtual System.Guid Rowguid
		{ 
			get { return _rowguid; }
			set { _rowguid = value; }
		}

		/// <summary>Gets or sets the SafetyStockLevel field. </summary>	
		public virtual System.Int16 SafetyStockLevel
		{ 
			get { return _safetyStockLevel; }
			set { _safetyStockLevel = value; }
		}

		/// <summary>Gets or sets the SellEndDate field. </summary>	
		public virtual Nullable<System.DateTime> SellEndDate
		{ 
			get { return _sellEndDate; }
			set { _sellEndDate = value; }
		}

		/// <summary>Gets or sets the SellStartDate field. </summary>	
		public virtual System.DateTime SellStartDate
		{ 
			get { return _sellStartDate; }
			set { _sellStartDate = value; }
		}

		/// <summary>Gets or sets the Size field. </summary>	
		public virtual System.String Size
		{ 
			get { return _size; }
			set { _size = value; }
		}

		/// <summary>Gets or sets the StandardCost field. </summary>	
		public virtual System.Decimal StandardCost
		{ 
			get { return _standardCost; }
			set { _standardCost = value; }
		}

		/// <summary>Gets or sets the Style field. </summary>	
		public virtual System.String Style
		{ 
			get { return _style; }
			set { _style = value; }
		}

		/// <summary>Gets or sets the Weight field. </summary>	
		public virtual Nullable<System.Decimal> Weight
		{ 
			get { return _weight; }
			set { _weight = value; }
		}

		/// <summary>Represents the navigator which is mapped onto the association 'Production.BillOfMaterial.Product - Production.Product.BillOfMaterials (m:1)'</summary>
		public virtual ISet<BillOfMaterial> BillOfMaterials
		{
			get { return _billOfMaterials; }
			set { _billOfMaterials = value; }
		}
		
		/// <summary>Represents the navigator which is mapped onto the association 'Production.BillOfMaterial.Product1 - Production.Product.BillOfMaterials1 (m:1)'</summary>
		public virtual ISet<BillOfMaterial> BillOfMaterials1
		{
			get { return _billOfMaterials1; }
			set { _billOfMaterials1 = value; }
		}
		
		/// <summary>Represents the navigator which is mapped onto the association 'Production.ProductCostHistory.Product - Production.Product.ProductCostHistories (m:1)'</summary>
		public virtual ISet<ProductCostHistory> ProductCostHistories
		{
			get { return _productCostHistories; }
			set { _productCostHistories = value; }
		}
		
		/// <summary>Represents the navigator which is mapped onto the association 'Production.ProductDocument.Product - Production.Product.ProductDocuments (m:1)'</summary>
		public virtual ISet<ProductDocument> ProductDocuments
		{
			get { return _productDocuments; }
			set { _productDocuments = value; }
		}
		
		/// <summary>Represents the navigator which is mapped onto the association 'Production.ProductInventory.Product - Production.Product.ProductInventories (m:1)'</summary>
		public virtual ISet<ProductInventory> ProductInventories
		{
			get { return _productInventories; }
			set { _productInventories = value; }
		}
		
		/// <summary>Represents the navigator which is mapped onto the association 'Production.ProductListPriceHistory.Product - Production.Product.ProductListPriceHistories (m:1)'</summary>
		public virtual ISet<ProductListPriceHistory> ProductListPriceHistories
		{
			get { return _productListPriceHistories; }
			set { _productListPriceHistories = value; }
		}
		
		/// <summary>Represents the navigator which is mapped onto the association 'Production.Product.ProductModel - Production.ProductModel.Products (m:1)'</summary>
		public virtual ProductModel ProductModel
		{
			get { return _productModel; }
			set { _productModel = value; }
		}
		
		/// <summary>Represents the navigator which is mapped onto the association 'Production.ProductProductPhoto.Product - Production.Product.ProductProductPhotos (m:1)'</summary>
		public virtual ISet<ProductProductPhoto> ProductProductPhotos
		{
			get { return _productProductPhotos; }
			set { _productProductPhotos = value; }
		}
		
		/// <summary>Represents the navigator which is mapped onto the association 'Production.ProductReview.Product - Production.Product.ProductReviews (m:1)'</summary>
		public virtual ISet<ProductReview> ProductReviews
		{
			get { return _productReviews; }
			set { _productReviews = value; }
		}
		
		/// <summary>Represents the navigator which is mapped onto the association 'Production.Product.ProductSubcategory - Production.ProductSubcategory.Products (m:1)'</summary>
		public virtual ProductSubcategory ProductSubcategory
		{
			get { return _productSubcategory; }
			set { _productSubcategory = value; }
		}
		
		/// <summary>Represents the navigator which is mapped onto the association 'Production.TransactionHistory.Product - Production.Product.TransactionHistories (m:1)'</summary>
		public virtual ISet<TransactionHistory> TransactionHistories
		{
			get { return _transactionHistories; }
			set { _transactionHistories = value; }
		}
		
		/// <summary>Represents the navigator which is mapped onto the association 'Production.Product.UnitMeasure - Production.UnitMeasure.Products (m:1)'</summary>
		public virtual UnitMeasure UnitMeasure
		{
			get { return _unitMeasure; }
			set { _unitMeasure = value; }
		}
		
		/// <summary>Represents the navigator which is mapped onto the association 'Production.Product.UnitMeasure1 - Production.UnitMeasure.Products1 (m:1)'</summary>
		public virtual UnitMeasure UnitMeasure1
		{
			get { return _unitMeasure1; }
			set { _unitMeasure1 = value; }
		}
		
		/// <summary>Represents the navigator which is mapped onto the association 'Production.WorkOrder.Product - Production.Product.WorkOrders (m:1)'</summary>
		public virtual ISet<WorkOrder> WorkOrders
		{
			get { return _workOrders; }
			set { _workOrders = value; }
		}
		
		/// <summary>Represents the navigator which is mapped onto the association 'Purchasing.ProductVendor.Product - Production.Product.ProductVendors (m:1)'</summary>
		public virtual ISet<ProductVendor> ProductVendors
		{
			get { return _productVendors; }
			set { _productVendors = value; }
		}
		
		/// <summary>Represents the navigator which is mapped onto the association 'Purchasing.PurchaseOrderDetail.Product - Production.Product.PurchaseOrderDetails (m:1)'</summary>
		public virtual ISet<PurchaseOrderDetail> PurchaseOrderDetails
		{
			get { return _purchaseOrderDetails; }
			set { _purchaseOrderDetails = value; }
		}
		
		/// <summary>Represents the navigator which is mapped onto the association 'Sales.ShoppingCartItem.Product - Production.Product.ShoppingCartItems (m:1)'</summary>
		public virtual ISet<ShoppingCartItem> ShoppingCartItems
		{
			get { return _shoppingCartItems; }
			set { _shoppingCartItems = value; }
		}
		
		/// <summary>Represents the navigator which is mapped onto the association 'Sales.SpecialOfferProduct.Product - Production.Product.SpecialOfferProducts (m:1)'</summary>
		public virtual ISet<SpecialOfferProduct> SpecialOfferProducts
		{
			get { return _specialOfferProducts; }
			set { _specialOfferProducts = value; }
		}
		
		#endregion
	}
}