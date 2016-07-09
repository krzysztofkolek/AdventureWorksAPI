﻿


using System;
using System.ComponentModel;
using System.Collections.Generic;

namespace AdventureWorks.EntityClasses.Production
{
    using Person;
    using Production;

    /// <summary>Class which represents the entity 'Production.ProductReview'</summary>
	public partial class ProductReview
	{
		#region Class Member Declarations
		private Product _product;
		private System.String _comments;
		private System.String _emailAddress;
		private System.DateTime _modifiedDate;
		private System.Int32 _productReviewId;
		private System.Int32 _rating;
		private System.DateTime _reviewDate;
		private System.String _reviewerName;
		#endregion

		/// <summary>Initializes a new instance of the <see cref="ProductReview"/> class.</summary>
		public ProductReview() : base()
		{
			_productReviewId = default(System.Int32);
			OnCreated();
		}

		/// <summary>Method called from the constructor</summary>
		partial void OnCreated();

		/// <summary>Returns a hash code for this instance.</summary>
		/// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
		public override int GetHashCode()
		{
			int toReturn = base.GetHashCode();
			toReturn ^= this.ProductReviewId.GetHashCode();
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
			ProductReview toCompareWith = obj as ProductReview;
			return toCompareWith == null ? false : ((this.ProductReviewId == toCompareWith.ProductReviewId));
		}
		

		#region Class Property Declarations
		/// <summary>Gets or sets the Comments field. </summary>	
		public virtual System.String Comments
		{ 
			get { return _comments; }
			set { _comments = value; }
		}

		/// <summary>Gets or sets the EmailAddress field. </summary>	
		public virtual System.String EmailAddress
		{ 
			get { return _emailAddress; }
			set { _emailAddress = value; }
		}

		/// <summary>Gets or sets the ModifiedDate field. </summary>	
		public virtual System.DateTime ModifiedDate
		{ 
			get { return _modifiedDate; }
			set { _modifiedDate = value; }
		}

		/// <summary>Gets the ProductReviewId field. </summary>	
		public virtual System.Int32 ProductReviewId
		{ 
			get { return _productReviewId; }
		}

		/// <summary>Gets or sets the Rating field. </summary>	
		public virtual System.Int32 Rating
		{ 
			get { return _rating; }
			set { _rating = value; }
		}

		/// <summary>Gets or sets the ReviewDate field. </summary>	
		public virtual System.DateTime ReviewDate
		{ 
			get { return _reviewDate; }
			set { _reviewDate = value; }
		}

		/// <summary>Gets or sets the ReviewerName field. </summary>	
		public virtual System.String ReviewerName
		{ 
			get { return _reviewerName; }
			set { _reviewerName = value; }
		}

		/// <summary>Represents the navigator which is mapped onto the association 'Production.ProductReview.Product - Production.Product.ProductReviews (m:1)'</summary>
		public virtual Product Product
		{
			get { return _product; }
			set { _product = value; }
		}
		
		#endregion
	}
}