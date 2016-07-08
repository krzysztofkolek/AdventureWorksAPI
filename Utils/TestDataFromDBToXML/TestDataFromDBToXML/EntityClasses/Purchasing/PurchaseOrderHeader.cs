﻿


using System;
using System.ComponentModel;
using System.Collections.Generic;

namespace AdventureWorks.EntityClasses.Purchasing
{
    using HumanResources;

    /// <summary>Class which represents the entity 'Purchasing.PurchaseOrderHeader'</summary>
	public partial class PurchaseOrderHeader
	{
		#region Class Member Declarations
		private Employee _employee;
		private ISet<PurchaseOrderDetail> _purchaseOrderDetails;
		private ShipMethod _shipMethod;
		private Vendor _vendor;
		private System.Decimal _freight;
		private System.DateTime _modifiedDate;
		private System.DateTime _orderDate;
		private System.Int32 _purchaseOrderId;
		private System.Byte _revisionNumber;
		private Nullable<System.DateTime> _shipDate;
		private System.Byte _status;
		private System.Decimal _subTotal;
		private System.Decimal _taxAmt;
		private System.Decimal _totalDue;
		#endregion

		/// <summary>Initializes a new instance of the <see cref="PurchaseOrderHeader"/> class.</summary>
		public PurchaseOrderHeader() : base()
		{
			_purchaseOrderDetails = new HashSet<PurchaseOrderDetail>();
			_purchaseOrderId = default(System.Int32);
			_totalDue = default(System.Decimal);
			OnCreated();
		}

		/// <summary>Method called from the constructor</summary>
		partial void OnCreated();

		/// <summary>Returns a hash code for this instance.</summary>
		/// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
		public override int GetHashCode()
		{
			int toReturn = base.GetHashCode();
			toReturn ^= this.PurchaseOrderId.GetHashCode();
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
			PurchaseOrderHeader toCompareWith = obj as PurchaseOrderHeader;
			return toCompareWith == null ? false : ((this.PurchaseOrderId == toCompareWith.PurchaseOrderId));
		}
		

		#region Class Property Declarations
		/// <summary>Gets or sets the Freight field. </summary>	
		public virtual System.Decimal Freight
		{ 
			get { return _freight; }
			set { _freight = value; }
		}

		/// <summary>Gets or sets the ModifiedDate field. </summary>	
		public virtual System.DateTime ModifiedDate
		{ 
			get { return _modifiedDate; }
			set { _modifiedDate = value; }
		}

		/// <summary>Gets or sets the OrderDate field. </summary>	
		public virtual System.DateTime OrderDate
		{ 
			get { return _orderDate; }
			set { _orderDate = value; }
		}

		/// <summary>Gets the PurchaseOrderId field. </summary>	
		public virtual System.Int32 PurchaseOrderId
		{ 
			get { return _purchaseOrderId; }
		}

		/// <summary>Gets or sets the RevisionNumber field. </summary>	
		public virtual System.Byte RevisionNumber
		{ 
			get { return _revisionNumber; }
			set { _revisionNumber = value; }
		}

		/// <summary>Gets or sets the ShipDate field. </summary>	
		public virtual Nullable<System.DateTime> ShipDate
		{ 
			get { return _shipDate; }
			set { _shipDate = value; }
		}

		/// <summary>Gets or sets the Status field. </summary>	
		public virtual System.Byte Status
		{ 
			get { return _status; }
			set { _status = value; }
		}

		/// <summary>Gets or sets the SubTotal field. </summary>	
		public virtual System.Decimal SubTotal
		{ 
			get { return _subTotal; }
			set { _subTotal = value; }
		}

		/// <summary>Gets or sets the TaxAmt field. </summary>	
		public virtual System.Decimal TaxAmt
		{ 
			get { return _taxAmt; }
			set { _taxAmt = value; }
		}

		/// <summary>Gets the TotalDue field. </summary>	
		public virtual System.Decimal TotalDue
		{ 
			get { return _totalDue; }
		}

		/// <summary>Represents the navigator which is mapped onto the association 'Purchasing.PurchaseOrderHeader.Employee - HumanResources.Employee.PurchaseOrderHeaders (m:1)'</summary>
		public virtual Employee Employee
		{
			get { return _employee; }
			set { _employee = value; }
		}
		
		/// <summary>Represents the navigator which is mapped onto the association 'Purchasing.PurchaseOrderDetail.PurchaseOrderHeader - Purchasing.PurchaseOrderHeader.PurchaseOrderDetails (m:1)'</summary>
		public virtual ISet<PurchaseOrderDetail> PurchaseOrderDetails
		{
			get { return _purchaseOrderDetails; }
			set { _purchaseOrderDetails = value; }
		}
		
		/// <summary>Represents the navigator which is mapped onto the association 'Purchasing.PurchaseOrderHeader.ShipMethod - Purchasing.ShipMethod.PurchaseOrderHeaders (m:1)'</summary>
		public virtual ShipMethod ShipMethod
		{
			get { return _shipMethod; }
			set { _shipMethod = value; }
		}
		
		/// <summary>Represents the navigator which is mapped onto the association 'Purchasing.PurchaseOrderHeader.Vendor - Purchasing.Vendor.PurchaseOrderHeaders (m:1)'</summary>
		public virtual Vendor Vendor
		{
			get { return _vendor; }
			set { _vendor = value; }
		}
		
		#endregion
	}
}
