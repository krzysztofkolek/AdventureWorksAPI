﻿


using System;
using System.ComponentModel;
using System.Collections.Generic;

namespace AdventureWorks.EntityClasses.Production
{
    using Person;
    using Production;
    using Purchasing;

    /// <summary>Class which represents the entity 'Production.UnitMeasure'</summary>
	public partial class UnitMeasure
	{
		#region Class Member Declarations
		private ISet<BillOfMaterial> _billOfMaterials;
		private ISet<Product> _products;
		private ISet<Product> _products1;
		private ISet<ProductVendor> _productVendors;
		private System.DateTime _modifiedDate;
		private System.String _name;
		private System.String _unitMeasureCode;
		#endregion

		/// <summary>Initializes a new instance of the <see cref="UnitMeasure"/> class.</summary>
		public UnitMeasure() : base()
		{
			_billOfMaterials = new HashSet<BillOfMaterial>();
			_products = new HashSet<Product>();
			_products1 = new HashSet<Product>();
			_productVendors = new HashSet<ProductVendor>();
			OnCreated();
		}

		/// <summary>Method called from the constructor</summary>
		partial void OnCreated();

		/// <summary>Returns a hash code for this instance.</summary>
		/// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
		public override int GetHashCode()
		{
			int toReturn = base.GetHashCode();
			toReturn ^= this.UnitMeasureCode.GetHashCode();
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
			UnitMeasure toCompareWith = obj as UnitMeasure;
			return toCompareWith == null ? false : ((this.UnitMeasureCode == toCompareWith.UnitMeasureCode));
		}
		

		#region Class Property Declarations
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

		/// <summary>Gets or sets the UnitMeasureCode field. </summary>	
		public virtual System.String UnitMeasureCode
		{ 
			get { return _unitMeasureCode; }
			set { _unitMeasureCode = value; }
		}

		/// <summary>Represents the navigator which is mapped onto the association 'Production.BillOfMaterial.UnitMeasure - Production.UnitMeasure.BillOfMaterials (m:1)'</summary>
		public virtual ISet<BillOfMaterial> BillOfMaterials
		{
			get { return _billOfMaterials; }
			set { _billOfMaterials = value; }
		}
		
		/// <summary>Represents the navigator which is mapped onto the association 'Production.Product.UnitMeasure - Production.UnitMeasure.Products (m:1)'</summary>
		public virtual ISet<Product> Products
		{
			get { return _products; }
			set { _products = value; }
		}
		
		/// <summary>Represents the navigator which is mapped onto the association 'Production.Product.UnitMeasure1 - Production.UnitMeasure.Products1 (m:1)'</summary>
		public virtual ISet<Product> Products1
		{
			get { return _products1; }
			set { _products1 = value; }
		}
		
		/// <summary>Represents the navigator which is mapped onto the association 'Purchasing.ProductVendor.UnitMeasure - Production.UnitMeasure.ProductVendors (m:1)'</summary>
		public virtual ISet<ProductVendor> ProductVendors
		{
			get { return _productVendors; }
			set { _productVendors = value; }
		}
		
		#endregion
	}
}