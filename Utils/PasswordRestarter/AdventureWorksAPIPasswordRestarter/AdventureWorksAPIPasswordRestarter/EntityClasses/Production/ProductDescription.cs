﻿


using System;
using System.ComponentModel;
using System.Collections.Generic;

namespace AdventureWorks.EntityClasses.Production
{
	/// <summary>Class which represents the entity 'Production.ProductDescription'</summary>
	public partial class ProductDescription
	{
		#region Class Member Declarations
		private ISet<ProductModelProductDescriptionCulture> _productModelProductDescriptionCultures;
		private System.String _description;
		private System.DateTime _modifiedDate;
		private System.Int32 _productDescriptionId;
		private System.Guid _rowguid;
		#endregion

		/// <summary>Initializes a new instance of the <see cref="ProductDescription"/> class.</summary>
		public ProductDescription() : base()
		{
			_productModelProductDescriptionCultures = new HashSet<ProductModelProductDescriptionCulture>();
			_productDescriptionId = default(System.Int32);
			OnCreated();
		}

		/// <summary>Method called from the constructor</summary>
		partial void OnCreated();

		/// <summary>Returns a hash code for this instance.</summary>
		/// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
		public override int GetHashCode()
		{
			int toReturn = base.GetHashCode();
			toReturn ^= this.ProductDescriptionId.GetHashCode();
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
			ProductDescription toCompareWith = obj as ProductDescription;
			return toCompareWith == null ? false : ((this.ProductDescriptionId == toCompareWith.ProductDescriptionId));
		}
		

		#region Class Property Declarations
		/// <summary>Gets or sets the Description field. </summary>	
		public virtual System.String Description
		{ 
			get { return _description; }
			set { _description = value; }
		}

		/// <summary>Gets or sets the ModifiedDate field. </summary>	
		public virtual System.DateTime ModifiedDate
		{ 
			get { return _modifiedDate; }
			set { _modifiedDate = value; }
		}

		/// <summary>Gets the ProductDescriptionId field. </summary>	
		public virtual System.Int32 ProductDescriptionId
		{ 
			get { return _productDescriptionId; }
		}

		/// <summary>Gets or sets the Rowguid field. </summary>	
		public virtual System.Guid Rowguid
		{ 
			get { return _rowguid; }
			set { _rowguid = value; }
		}

		/// <summary>Represents the navigator which is mapped onto the association 'Production.ProductModelProductDescriptionCulture.ProductDescription - Production.ProductDescription.ProductModelProductDescriptionCultures (m:1)'</summary>
		public virtual ISet<ProductModelProductDescriptionCulture> ProductModelProductDescriptionCultures
		{
			get { return _productModelProductDescriptionCultures; }
			set { _productModelProductDescriptionCultures = value; }
		}
		
		#endregion
	}
}