﻿


using System;
using System.ComponentModel;
using System.Collections.Generic;

namespace AdventureWorks.EntityClasses.Sales
{
	/// <summary>Class which represents the entity 'Sales.SpecialOffer'</summary>
	public partial class SpecialOffer
	{
		#region Class Member Declarations
		private ISet<SpecialOfferProduct> _specialOfferProducts;
		private System.String _category;
		private System.String _description;
		private System.Decimal _discountPct;
		private System.DateTime _endDate;
		private Nullable<System.Int32> _maxQty;
		private System.Int32 _minQty;
		private System.DateTime _modifiedDate;
		private System.Guid _rowguid;
		private System.Int32 _specialOfferId;
		private System.DateTime _startDate;
		private System.String _type;
		#endregion

		/// <summary>Initializes a new instance of the <see cref="SpecialOffer"/> class.</summary>
		public SpecialOffer() : base()
		{
			_specialOfferProducts = new HashSet<SpecialOfferProduct>();
			_specialOfferId = default(System.Int32);
			OnCreated();
		}

		/// <summary>Method called from the constructor</summary>
		partial void OnCreated();

		/// <summary>Returns a hash code for this instance.</summary>
		/// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
		public override int GetHashCode()
		{
			int toReturn = base.GetHashCode();
			toReturn ^= this.SpecialOfferId.GetHashCode();
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
			SpecialOffer toCompareWith = obj as SpecialOffer;
			return toCompareWith == null ? false : ((this.SpecialOfferId == toCompareWith.SpecialOfferId));
		}
		

		#region Class Property Declarations
		/// <summary>Gets or sets the Category field. </summary>	
		public virtual System.String Category
		{ 
			get { return _category; }
			set { _category = value; }
		}

		/// <summary>Gets or sets the Description field. </summary>	
		public virtual System.String Description
		{ 
			get { return _description; }
			set { _description = value; }
		}

		/// <summary>Gets or sets the DiscountPct field. </summary>	
		public virtual System.Decimal DiscountPct
		{ 
			get { return _discountPct; }
			set { _discountPct = value; }
		}

		/// <summary>Gets or sets the EndDate field. </summary>	
		public virtual System.DateTime EndDate
		{ 
			get { return _endDate; }
			set { _endDate = value; }
		}

		/// <summary>Gets or sets the MaxQty field. </summary>	
		public virtual Nullable<System.Int32> MaxQty
		{ 
			get { return _maxQty; }
			set { _maxQty = value; }
		}

		/// <summary>Gets or sets the MinQty field. </summary>	
		public virtual System.Int32 MinQty
		{ 
			get { return _minQty; }
			set { _minQty = value; }
		}

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

		/// <summary>Gets the SpecialOfferId field. </summary>	
		public virtual System.Int32 SpecialOfferId
		{ 
			get { return _specialOfferId; }
		}

		/// <summary>Gets or sets the StartDate field. </summary>	
		public virtual System.DateTime StartDate
		{ 
			get { return _startDate; }
			set { _startDate = value; }
		}

		/// <summary>Gets or sets the Type field. </summary>	
		public virtual System.String Type
		{ 
			get { return _type; }
			set { _type = value; }
		}

		/// <summary>Represents the navigator which is mapped onto the association 'Sales.SpecialOfferProduct.SpecialOffer - Sales.SpecialOffer.SpecialOfferProducts (m:1)'</summary>
		public virtual ISet<SpecialOfferProduct> SpecialOfferProducts
		{
			get { return _specialOfferProducts; }
			set { _specialOfferProducts = value; }
		}
		
		#endregion
	}
}
