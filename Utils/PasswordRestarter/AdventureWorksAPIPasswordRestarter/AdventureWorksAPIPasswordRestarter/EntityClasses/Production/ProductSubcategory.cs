﻿


using System;
using System.ComponentModel;
using System.Collections.Generic;

namespace AdventureWorks.EntityClasses.Production
{
    using Person;
    using Production;

    /// <summary>Class which represents the entity 'Production.ProductSubcategory'</summary>
	public partial class ProductSubcategory
	{
		#region Class Member Declarations
		private ISet<Product> _products;
		private ProductCategory _productCategory;
		private System.DateTime _modifiedDate;
		private System.String _name;
		private System.Int32 _productSubcategoryId;
		private System.Guid _rowguid;
		#endregion

		/// <summary>Initializes a new instance of the <see cref="ProductSubcategory"/> class.</summary>
		public ProductSubcategory() : base()
		{
			_products = new HashSet<Product>();
			_productSubcategoryId = default(System.Int32);
			OnCreated();
		}

		/// <summary>Method called from the constructor</summary>
		partial void OnCreated();

		/// <summary>Returns a hash code for this instance.</summary>
		/// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
		public override int GetHashCode()
		{
			int toReturn = base.GetHashCode();
			toReturn ^= this.ProductSubcategoryId.GetHashCode();
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
			ProductSubcategory toCompareWith = obj as ProductSubcategory;
			return toCompareWith == null ? false : ((this.ProductSubcategoryId == toCompareWith.ProductSubcategoryId));
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

		/// <summary>Gets the ProductSubcategoryId field. </summary>	
		public virtual System.Int32 ProductSubcategoryId
		{ 
			get { return _productSubcategoryId; }
		}

		/// <summary>Gets or sets the Rowguid field. </summary>	
		public virtual System.Guid Rowguid
		{ 
			get { return _rowguid; }
			set { _rowguid = value; }
		}

		/// <summary>Represents the navigator which is mapped onto the association 'Production.Product.ProductSubcategory - Production.ProductSubcategory.Products (m:1)'</summary>
		public virtual ISet<Product> Products
		{
			get { return _products; }
			set { _products = value; }
		}
		
		/// <summary>Represents the navigator which is mapped onto the association 'Production.ProductSubcategory.ProductCategory - Production.ProductCategory.ProductSubcategories (m:1)'</summary>
		public virtual ProductCategory ProductCategory
		{
			get { return _productCategory; }
			set { _productCategory = value; }
		}
		
		#endregion
	}
}