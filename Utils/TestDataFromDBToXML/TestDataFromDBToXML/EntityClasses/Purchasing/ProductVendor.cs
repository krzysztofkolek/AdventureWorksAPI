﻿


using System;
using System.ComponentModel;
using System.Collections.Generic;

namespace AdventureWorks.EntityClasses.Purchasing
{
    using Person;
    using Production;

    /// <summary>Class which represents the entity 'Purchasing.ProductVendor'</summary>
	public partial class ProductVendor
	{
		#region Class Member Declarations
		private Product _product;
		private UnitMeasure _unitMeasure;
		private Vendor _vendor;
		private System.Int32 _averageLeadTime;
		private Nullable<System.Decimal> _lastReceiptCost;
		private Nullable<System.DateTime> _lastReceiptDate;
		private System.Int32 _maxOrderQty;
		private System.Int32 _minOrderQty;
		private System.DateTime _modifiedDate;
		private Nullable<System.Int32> _onOrderQty;
		private System.Decimal _standardPrice;
		#endregion

		/// <summary>Initializes a new instance of the <see cref="ProductVendor"/> class.</summary>
		public ProductVendor() : base()
		{
			OnCreated();
		}

		/// <summary>Method called from the constructor</summary>
		partial void OnCreated();

		/// <summary>Returns a hash code for this instance.</summary>
		/// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
		public override int GetHashCode()
		{
			int toReturn = base.GetHashCode();
			return toReturn;
		}
	
		/// <summary>Determines whether the specified object is equal to this instance.</summary>
		/// <param name="obj">The <see cref="System.Object"/> to compare with this instance.</param>
		/// <returns><c>true</c> if the specified <see cref="System.Object"/> is equal to this instance; otherwise, <c>false</c>.</returns>
		public override bool Equals(object obj)
		{
			return object.ReferenceEquals(this, obj);
		}
		

		#region Class Property Declarations
		/// <summary>Gets or sets the AverageLeadTime field. </summary>	
		public virtual System.Int32 AverageLeadTime
		{ 
			get { return _averageLeadTime; }
			set { _averageLeadTime = value; }
		}

		/// <summary>Gets or sets the LastReceiptCost field. </summary>	
		public virtual Nullable<System.Decimal> LastReceiptCost
		{ 
			get { return _lastReceiptCost; }
			set { _lastReceiptCost = value; }
		}

		/// <summary>Gets or sets the LastReceiptDate field. </summary>	
		public virtual Nullable<System.DateTime> LastReceiptDate
		{ 
			get { return _lastReceiptDate; }
			set { _lastReceiptDate = value; }
		}

		/// <summary>Gets or sets the MaxOrderQty field. </summary>	
		public virtual System.Int32 MaxOrderQty
		{ 
			get { return _maxOrderQty; }
			set { _maxOrderQty = value; }
		}

		/// <summary>Gets or sets the MinOrderQty field. </summary>	
		public virtual System.Int32 MinOrderQty
		{ 
			get { return _minOrderQty; }
			set { _minOrderQty = value; }
		}

		/// <summary>Gets or sets the ModifiedDate field. </summary>	
		public virtual System.DateTime ModifiedDate
		{ 
			get { return _modifiedDate; }
			set { _modifiedDate = value; }
		}

		/// <summary>Gets or sets the OnOrderQty field. </summary>	
		public virtual Nullable<System.Int32> OnOrderQty
		{ 
			get { return _onOrderQty; }
			set { _onOrderQty = value; }
		}

		/// <summary>Gets or sets the StandardPrice field. </summary>	
		public virtual System.Decimal StandardPrice
		{ 
			get { return _standardPrice; }
			set { _standardPrice = value; }
		}

		/// <summary>Represents the navigator which is mapped onto the association 'Purchasing.ProductVendor.Product - Production.Product.ProductVendors (m:1)'</summary>
		public virtual Product Product
		{
			get { return _product; }
			set { _product = value; }
		}
		
		/// <summary>Represents the navigator which is mapped onto the association 'Purchasing.ProductVendor.UnitMeasure - Production.UnitMeasure.ProductVendors (m:1)'</summary>
		public virtual UnitMeasure UnitMeasure
		{
			get { return _unitMeasure; }
			set { _unitMeasure = value; }
		}
		
		/// <summary>Represents the navigator which is mapped onto the association 'Purchasing.ProductVendor.Vendor - Purchasing.Vendor.ProductVendors (m:1)'</summary>
		public virtual Vendor Vendor
		{
			get { return _vendor; }
			set { _vendor = value; }
		}
		
		#endregion
	}
}
