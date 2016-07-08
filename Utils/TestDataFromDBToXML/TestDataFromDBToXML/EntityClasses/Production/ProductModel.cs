﻿


using System;
using System.ComponentModel;
using System.Collections.Generic;

namespace AdventureWorks.EntityClasses.Production
{
    using Person;
    using Production;

    /// <summary>Class which represents the entity 'Production.ProductModel'</summary>
	public partial class ProductModel
	{
		#region Class Member Declarations
		private ISet<Product> _products;
		private ISet<ProductModelIllustration> _productModelIllustrations;
		private ISet<ProductModelProductDescriptionCulture> _productModelProductDescriptionCultures;
		private System.String _catalogDescription;
		private System.String _instructions;
		private System.DateTime _modifiedDate;
		private System.String _name;
		private System.Int32 _productModelId;
		private System.Guid _rowguid;
		#endregion

		/// <summary>Initializes a new instance of the <see cref="ProductModel"/> class.</summary>
		public ProductModel() : base()
		{
			_products = new HashSet<Product>();
			_productModelIllustrations = new HashSet<ProductModelIllustration>();
			_productModelProductDescriptionCultures = new HashSet<ProductModelProductDescriptionCulture>();
			_productModelId = default(System.Int32);
			OnCreated();
		}

		/// <summary>Method called from the constructor</summary>
		partial void OnCreated();

		/// <summary>Returns a hash code for this instance.</summary>
		/// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
		public override int GetHashCode()
		{
			int toReturn = base.GetHashCode();
			toReturn ^= this.ProductModelId.GetHashCode();
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
			ProductModel toCompareWith = obj as ProductModel;
			return toCompareWith == null ? false : ((this.ProductModelId == toCompareWith.ProductModelId));
		}
		

		#region Class Property Declarations
		/// <summary>Gets or sets the CatalogDescription field. </summary>	
		public virtual System.String CatalogDescription
		{ 
			get { return _catalogDescription; }
			set { _catalogDescription = value; }
		}

		/// <summary>Gets or sets the Instructions field. </summary>	
		public virtual System.String Instructions
		{ 
			get { return _instructions; }
			set { _instructions = value; }
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

		/// <summary>Gets the ProductModelId field. </summary>	
		public virtual System.Int32 ProductModelId
		{ 
			get { return _productModelId; }
		}

		/// <summary>Gets or sets the Rowguid field. </summary>	
		public virtual System.Guid Rowguid
		{ 
			get { return _rowguid; }
			set { _rowguid = value; }
		}

		/// <summary>Represents the navigator which is mapped onto the association 'Production.Product.ProductModel - Production.ProductModel.Products (m:1)'</summary>
		public virtual ISet<Product> Products
		{
			get { return _products; }
			set { _products = value; }
		}
		
		/// <summary>Represents the navigator which is mapped onto the association 'Production.ProductModelIllustration.ProductModel - Production.ProductModel.ProductModelIllustrations (m:1)'</summary>
		public virtual ISet<ProductModelIllustration> ProductModelIllustrations
		{
			get { return _productModelIllustrations; }
			set { _productModelIllustrations = value; }
		}
		
		/// <summary>Represents the navigator which is mapped onto the association 'Production.ProductModelProductDescriptionCulture.ProductModel - Production.ProductModel.ProductModelProductDescriptionCultures (m:1)'</summary>
		public virtual ISet<ProductModelProductDescriptionCulture> ProductModelProductDescriptionCultures
		{
			get { return _productModelProductDescriptionCultures; }
			set { _productModelProductDescriptionCultures = value; }
		}
		
		#endregion
	}
}
