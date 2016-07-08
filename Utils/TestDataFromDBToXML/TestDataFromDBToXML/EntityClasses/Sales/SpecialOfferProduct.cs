﻿


using System;
using System.ComponentModel;
using System.Collections.Generic;

namespace AdventureWorks.EntityClasses.Sales
{
    using Person;
    using Production;

    /// <summary>Class which represents the entity 'Sales.SpecialOfferProduct'</summary>
	public partial class SpecialOfferProduct
	{
		#region Class Member Declarations
		private Product _product;
		private ISet<SalesOrderDetail> _salesOrderDetails;
		private SpecialOffer _specialOffer;
		private System.DateTime _modifiedDate;
		private System.Guid _rowguid;
		#endregion

		/// <summary>Initializes a new instance of the <see cref="SpecialOfferProduct"/> class.</summary>
		public SpecialOfferProduct() : base()
		{
			_salesOrderDetails = new HashSet<SalesOrderDetail>();
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

		/// <summary>Gets or sets the Rowguid field. </summary>	
		public virtual System.Guid Rowguid
		{ 
			get { return _rowguid; }
			set { _rowguid = value; }
		}

		/// <summary>Represents the navigator which is mapped onto the association 'Sales.SpecialOfferProduct.Product - Production.Product.SpecialOfferProducts (m:1)'</summary>
		public virtual Product Product
		{
			get { return _product; }
			set { _product = value; }
		}
		
		/// <summary>Represents the navigator which is mapped onto the association 'Sales.SalesOrderDetail.SpecialOfferProduct - Sales.SpecialOfferProduct.SalesOrderDetails (m:1)'</summary>
		public virtual ISet<SalesOrderDetail> SalesOrderDetails
		{
			get { return _salesOrderDetails; }
			set { _salesOrderDetails = value; }
		}
		
		/// <summary>Represents the navigator which is mapped onto the association 'Sales.SpecialOfferProduct.SpecialOffer - Sales.SpecialOffer.SpecialOfferProducts (m:1)'</summary>
		public virtual SpecialOffer SpecialOffer
		{
			get { return _specialOffer; }
			set { _specialOffer = value; }
		}
		
		#endregion
	}
}
