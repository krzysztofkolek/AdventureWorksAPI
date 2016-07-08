﻿


using System;
using System.ComponentModel;
using System.Collections.Generic;

namespace AdventureWorks.EntityClasses.Production
{
    using Person;
    using Production;

    /// <summary>Class which represents the entity 'Production.ProductProductPhoto'</summary>
	public partial class ProductProductPhoto
	{
		#region Class Member Declarations
		private Product _product;
		private ProductPhoto _productPhoto;
		private System.DateTime _modifiedDate;
		private System.Boolean _primary;
		#endregion

		/// <summary>Initializes a new instance of the <see cref="ProductProductPhoto"/> class.</summary>
		public ProductProductPhoto() : base()
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
		/// <summary>Gets or sets the ModifiedDate field. </summary>	
		public virtual System.DateTime ModifiedDate
		{ 
			get { return _modifiedDate; }
			set { _modifiedDate = value; }
		}

		/// <summary>Gets or sets the Primary field. </summary>	
		public virtual System.Boolean Primary
		{ 
			get { return _primary; }
			set { _primary = value; }
		}

		/// <summary>Represents the navigator which is mapped onto the association 'Production.ProductProductPhoto.Product - Production.Product.ProductProductPhotos (m:1)'</summary>
		public virtual Product Product
		{
			get { return _product; }
			set { _product = value; }
		}
		
		/// <summary>Represents the navigator which is mapped onto the association 'Production.ProductProductPhoto.ProductPhoto - Production.ProductPhoto.ProductProductPhotos (m:1)'</summary>
		public virtual ProductPhoto ProductPhoto
		{
			get { return _productPhoto; }
			set { _productPhoto = value; }
		}
		
		#endregion
	}
}
