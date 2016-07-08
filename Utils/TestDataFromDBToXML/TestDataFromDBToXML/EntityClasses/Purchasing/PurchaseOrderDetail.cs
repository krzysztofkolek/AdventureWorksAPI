﻿


using System;
using System.ComponentModel;
using System.Collections.Generic;

namespace AdventureWorks.EntityClasses.Purchasing
{
    using Person;
    using Production;

    /// <summary>Class which represents the entity 'Purchasing.PurchaseOrderDetail'</summary>
	public partial class PurchaseOrderDetail
	{
		#region Class Member Declarations
		private Product _product;
		private PurchaseOrderHeader _purchaseOrderHeader;
		private System.DateTime _dueDate;
		private System.Decimal _lineTotal;
		private System.DateTime _modifiedDate;
		private System.Int16 _orderQty;
		private System.Int32 _purchaseOrderDetailId;
		private System.Decimal _receivedQty;
		private System.Decimal _rejectedQty;
		private System.Decimal _stockedQty;
		private System.Decimal _unitPrice;
		#endregion

		/// <summary>Initializes a new instance of the <see cref="PurchaseOrderDetail"/> class.</summary>
		public PurchaseOrderDetail() : base()
		{
			_lineTotal = default(System.Decimal);
			_purchaseOrderDetailId = default(System.Int32);
			_stockedQty = default(System.Decimal);
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
		/// <summary>Gets or sets the DueDate field. </summary>	
		public virtual System.DateTime DueDate
		{ 
			get { return _dueDate; }
			set { _dueDate = value; }
		}

		/// <summary>Gets the LineTotal field. </summary>	
		public virtual System.Decimal LineTotal
		{ 
			get { return _lineTotal; }
		}

		/// <summary>Gets or sets the ModifiedDate field. </summary>	
		public virtual System.DateTime ModifiedDate
		{ 
			get { return _modifiedDate; }
			set { _modifiedDate = value; }
		}

		/// <summary>Gets or sets the OrderQty field. </summary>	
		public virtual System.Int16 OrderQty
		{ 
			get { return _orderQty; }
			set { _orderQty = value; }
		}

		/// <summary>Gets the PurchaseOrderDetailId field. </summary>	
		public virtual System.Int32 PurchaseOrderDetailId
		{ 
			get { return _purchaseOrderDetailId; }
		}

		/// <summary>Gets or sets the ReceivedQty field. </summary>	
		public virtual System.Decimal ReceivedQty
		{ 
			get { return _receivedQty; }
			set { _receivedQty = value; }
		}

		/// <summary>Gets or sets the RejectedQty field. </summary>	
		public virtual System.Decimal RejectedQty
		{ 
			get { return _rejectedQty; }
			set { _rejectedQty = value; }
		}

		/// <summary>Gets the StockedQty field. </summary>	
		public virtual System.Decimal StockedQty
		{ 
			get { return _stockedQty; }
		}

		/// <summary>Gets or sets the UnitPrice field. </summary>	
		public virtual System.Decimal UnitPrice
		{ 
			get { return _unitPrice; }
			set { _unitPrice = value; }
		}

		/// <summary>Represents the navigator which is mapped onto the association 'Purchasing.PurchaseOrderDetail.Product - Production.Product.PurchaseOrderDetails (m:1)'</summary>
		public virtual Product Product
		{
			get { return _product; }
			set { _product = value; }
		}
		
		/// <summary>Represents the navigator which is mapped onto the association 'Purchasing.PurchaseOrderDetail.PurchaseOrderHeader - Purchasing.PurchaseOrderHeader.PurchaseOrderDetails (m:1)'</summary>
		public virtual PurchaseOrderHeader PurchaseOrderHeader
		{
			get { return _purchaseOrderHeader; }
			set { _purchaseOrderHeader = value; }
		}
		
		#endregion
	}
}
