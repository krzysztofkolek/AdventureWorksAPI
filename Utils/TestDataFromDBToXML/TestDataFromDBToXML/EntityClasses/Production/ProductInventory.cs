﻿


using System;
using System.ComponentModel;
using System.Collections.Generic;

namespace AdventureWorks.EntityClasses.Production
{
    using Person;
    using Production;

    /// <summary>Class which represents the entity 'Production.ProductInventory'</summary>
	public partial class ProductInventory
	{
		#region Class Member Declarations
		private Location _location;
		private Product _product;
		private System.Byte _bin;
		private System.DateTime _modifiedDate;
		private System.Int16 _quantity;
		private System.Guid _rowguid;
		private System.String _shelf;
		#endregion

		/// <summary>Initializes a new instance of the <see cref="ProductInventory"/> class.</summary>
		public ProductInventory() : base()
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
		/// <summary>Gets or sets the Bin field. </summary>	
		public virtual System.Byte Bin
		{ 
			get { return _bin; }
			set { _bin = value; }
		}

		/// <summary>Gets or sets the ModifiedDate field. </summary>	
		public virtual System.DateTime ModifiedDate
		{ 
			get { return _modifiedDate; }
			set { _modifiedDate = value; }
		}

		/// <summary>Gets or sets the Quantity field. </summary>	
		public virtual System.Int16 Quantity
		{ 
			get { return _quantity; }
			set { _quantity = value; }
		}

		/// <summary>Gets or sets the Rowguid field. </summary>	
		public virtual System.Guid Rowguid
		{ 
			get { return _rowguid; }
			set { _rowguid = value; }
		}

		/// <summary>Gets or sets the Shelf field. </summary>	
		public virtual System.String Shelf
		{ 
			get { return _shelf; }
			set { _shelf = value; }
		}

		/// <summary>Represents the navigator which is mapped onto the association 'Production.ProductInventory.Location - Production.Location.ProductInventories (m:1)'</summary>
		public virtual Location Location
		{
			get { return _location; }
			set { _location = value; }
		}
		
		/// <summary>Represents the navigator which is mapped onto the association 'Production.ProductInventory.Product - Production.Product.ProductInventories (m:1)'</summary>
		public virtual Product Product
		{
			get { return _product; }
			set { _product = value; }
		}
		
		#endregion
	}
}
