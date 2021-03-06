﻿


using System;
using System.ComponentModel;
using System.Collections.Generic;

namespace AdventureWorks.EntityClasses.Production
{
    using Person;
    using Production;

    /// <summary>Class which represents the entity 'Production.TransactionHistory'</summary>
	public partial class TransactionHistory
	{
		#region Class Member Declarations
		private Product _product;
		private System.Decimal _actualCost;
		private System.DateTime _modifiedDate;
		private System.Int32 _quantity;
		private System.Int32 _referenceOrderId;
		private System.Int32 _referenceOrderLineId;
		private System.DateTime _transactionDate;
		private System.Int32 _transactionId;
		private System.String _transactionType;
		#endregion

		/// <summary>Initializes a new instance of the <see cref="TransactionHistory"/> class.</summary>
		public TransactionHistory() : base()
		{
			_transactionId = default(System.Int32);
			OnCreated();
		}

		/// <summary>Method called from the constructor</summary>
		partial void OnCreated();

		/// <summary>Returns a hash code for this instance.</summary>
		/// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
		public override int GetHashCode()
		{
			int toReturn = base.GetHashCode();
			toReturn ^= this.TransactionId.GetHashCode();
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
			TransactionHistory toCompareWith = obj as TransactionHistory;
			return toCompareWith == null ? false : ((this.TransactionId == toCompareWith.TransactionId));
		}
		

		#region Class Property Declarations
		/// <summary>Gets or sets the ActualCost field. </summary>	
		public virtual System.Decimal ActualCost
		{ 
			get { return _actualCost; }
			set { _actualCost = value; }
		}

		/// <summary>Gets or sets the ModifiedDate field. </summary>	
		public virtual System.DateTime ModifiedDate
		{ 
			get { return _modifiedDate; }
			set { _modifiedDate = value; }
		}

		/// <summary>Gets or sets the Quantity field. </summary>	
		public virtual System.Int32 Quantity
		{ 
			get { return _quantity; }
			set { _quantity = value; }
		}

		/// <summary>Gets or sets the ReferenceOrderId field. </summary>	
		public virtual System.Int32 ReferenceOrderId
		{ 
			get { return _referenceOrderId; }
			set { _referenceOrderId = value; }
		}

		/// <summary>Gets or sets the ReferenceOrderLineId field. </summary>	
		public virtual System.Int32 ReferenceOrderLineId
		{ 
			get { return _referenceOrderLineId; }
			set { _referenceOrderLineId = value; }
		}

		/// <summary>Gets or sets the TransactionDate field. </summary>	
		public virtual System.DateTime TransactionDate
		{ 
			get { return _transactionDate; }
			set { _transactionDate = value; }
		}

		/// <summary>Gets the TransactionId field. </summary>	
		public virtual System.Int32 TransactionId
		{ 
			get { return _transactionId; }
		}

		/// <summary>Gets or sets the TransactionType field. </summary>	
		public virtual System.String TransactionType
		{ 
			get { return _transactionType; }
			set { _transactionType = value; }
		}

		/// <summary>Represents the navigator which is mapped onto the association 'Production.TransactionHistory.Product - Production.Product.TransactionHistories (m:1)'</summary>
		public virtual Product Product
		{
			get { return _product; }
			set { _product = value; }
		}
		
		#endregion
	}
}
