﻿


using System;
using System.ComponentModel;
using System.Collections.Generic;

namespace AdventureWorks.EntityClasses.Sales
{
    using Person;
    using Purchasing;

    /// <summary>Class which represents the entity 'Sales.SalesOrderHeader'</summary>
	public partial class SalesOrderHeader
	{
		#region Class Member Declarations
		private Address _address;
		private Address _address1;
		private Contact _contact;
		private ShipMethod _shipMethod;
		private CreditCard _creditCard;
		private CurrencyRate _currencyRate;
		private Customer _customer;
		private ISet<SalesOrderDetail> _salesOrderDetails;
		private ISet<SalesOrderHeaderSalesReason> _salesOrderHeaderSalesReasons;
		private SalesPerson _salesPerson;
		private SalesTerritory _salesTerritory;
		private System.String _accountNumber;
		private System.String _comment;
		private System.String _creditCardApprovalCode;
		private System.DateTime _dueDate;
		private System.Decimal _freight;
		private System.DateTime _modifiedDate;
		private System.Boolean _onlineOrderFlag;
		private System.DateTime _orderDate;
		private System.String _purchaseOrderNumber;
		private System.Byte _revisionNumber;
		private System.Guid _rowguid;
		private System.Int32 _salesOrderId;
		private System.String _salesOrderNumber;
		private Nullable<System.DateTime> _shipDate;
		private System.Byte _status;
		private System.Decimal _subTotal;
		private System.Decimal _taxAmt;
		private System.Decimal _totalDue;
		#endregion

		/// <summary>Initializes a new instance of the <see cref="SalesOrderHeader"/> class.</summary>
		public SalesOrderHeader() : base()
		{
			_salesOrderDetails = new HashSet<SalesOrderDetail>();
			_salesOrderHeaderSalesReasons = new HashSet<SalesOrderHeaderSalesReason>();
			_salesOrderId = default(System.Int32);
			_salesOrderNumber = default(System.String);
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
			toReturn ^= this.SalesOrderId.GetHashCode();
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
			SalesOrderHeader toCompareWith = obj as SalesOrderHeader;
			return toCompareWith == null ? false : ((this.SalesOrderId == toCompareWith.SalesOrderId));
		}
		

		#region Class Property Declarations
		/// <summary>Gets or sets the AccountNumber field. </summary>	
		public virtual System.String AccountNumber
		{ 
			get { return _accountNumber; }
			set { _accountNumber = value; }
		}

		/// <summary>Gets or sets the Comment field. </summary>	
		public virtual System.String Comment
		{ 
			get { return _comment; }
			set { _comment = value; }
		}

		/// <summary>Gets or sets the CreditCardApprovalCode field. </summary>	
		public virtual System.String CreditCardApprovalCode
		{ 
			get { return _creditCardApprovalCode; }
			set { _creditCardApprovalCode = value; }
		}

		/// <summary>Gets or sets the DueDate field. </summary>	
		public virtual System.DateTime DueDate
		{ 
			get { return _dueDate; }
			set { _dueDate = value; }
		}

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

		/// <summary>Gets or sets the OnlineOrderFlag field. </summary>	
		public virtual System.Boolean OnlineOrderFlag
		{ 
			get { return _onlineOrderFlag; }
			set { _onlineOrderFlag = value; }
		}

		/// <summary>Gets or sets the OrderDate field. </summary>	
		public virtual System.DateTime OrderDate
		{ 
			get { return _orderDate; }
			set { _orderDate = value; }
		}

		/// <summary>Gets or sets the PurchaseOrderNumber field. </summary>	
		public virtual System.String PurchaseOrderNumber
		{ 
			get { return _purchaseOrderNumber; }
			set { _purchaseOrderNumber = value; }
		}

		/// <summary>Gets or sets the RevisionNumber field. </summary>	
		public virtual System.Byte RevisionNumber
		{ 
			get { return _revisionNumber; }
			set { _revisionNumber = value; }
		}

		/// <summary>Gets or sets the Rowguid field. </summary>	
		public virtual System.Guid Rowguid
		{ 
			get { return _rowguid; }
			set { _rowguid = value; }
		}

		/// <summary>Gets the SalesOrderId field. </summary>	
		public virtual System.Int32 SalesOrderId
		{ 
			get { return _salesOrderId; }
		}

		/// <summary>Gets the SalesOrderNumber field. </summary>	
		public virtual System.String SalesOrderNumber
		{ 
			get { return _salesOrderNumber; }
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

		/// <summary>Represents the navigator which is mapped onto the association 'Sales.SalesOrderHeader.Address - Person.Address.SalesOrderHeaders (m:1)'</summary>
		public virtual Address Address
		{
			get { return _address; }
			set { _address = value; }
		}
		
		/// <summary>Represents the navigator which is mapped onto the association 'Sales.SalesOrderHeader.Address1 - Person.Address.SalesOrderHeaders1 (m:1)'</summary>
		public virtual Address Address1
		{
			get { return _address1; }
			set { _address1 = value; }
		}
		
		/// <summary>Represents the navigator which is mapped onto the association 'Sales.SalesOrderHeader.Contact - Person.Contact.SalesOrderHeaders (m:1)'</summary>
		public virtual Contact Contact
		{
			get { return _contact; }
			set { _contact = value; }
		}
		
		/// <summary>Represents the navigator which is mapped onto the association 'Sales.SalesOrderHeader.ShipMethod - Purchasing.ShipMethod.SalesOrderHeaders (m:1)'</summary>
		public virtual ShipMethod ShipMethod
		{
			get { return _shipMethod; }
			set { _shipMethod = value; }
		}
		
		/// <summary>Represents the navigator which is mapped onto the association 'Sales.SalesOrderHeader.CreditCard - Sales.CreditCard.SalesOrderHeaders (m:1)'</summary>
		public virtual CreditCard CreditCard
		{
			get { return _creditCard; }
			set { _creditCard = value; }
		}
		
		/// <summary>Represents the navigator which is mapped onto the association 'Sales.SalesOrderHeader.CurrencyRate - Sales.CurrencyRate.SalesOrderHeaders (m:1)'</summary>
		public virtual CurrencyRate CurrencyRate
		{
			get { return _currencyRate; }
			set { _currencyRate = value; }
		}
		
		/// <summary>Represents the navigator which is mapped onto the association 'Sales.SalesOrderHeader.Customer - Sales.Customer.SalesOrderHeaders (m:1)'</summary>
		public virtual Customer Customer
		{
			get { return _customer; }
			set { _customer = value; }
		}
		
		/// <summary>Represents the navigator which is mapped onto the association 'Sales.SalesOrderDetail.SalesOrderHeader - Sales.SalesOrderHeader.SalesOrderDetails (m:1)'</summary>
		public virtual ISet<SalesOrderDetail> SalesOrderDetails
		{
			get { return _salesOrderDetails; }
			set { _salesOrderDetails = value; }
		}
		
		/// <summary>Represents the navigator which is mapped onto the association 'Sales.SalesOrderHeaderSalesReason.SalesOrderHeader - Sales.SalesOrderHeader.SalesOrderHeaderSalesReasons (m:1)'</summary>
		public virtual ISet<SalesOrderHeaderSalesReason> SalesOrderHeaderSalesReasons
		{
			get { return _salesOrderHeaderSalesReasons; }
			set { _salesOrderHeaderSalesReasons = value; }
		}
		
		/// <summary>Represents the navigator which is mapped onto the association 'Sales.SalesOrderHeader.SalesPerson - Sales.SalesPerson.SalesOrderHeaders (m:1)'</summary>
		public virtual SalesPerson SalesPerson
		{
			get { return _salesPerson; }
			set { _salesPerson = value; }
		}
		
		/// <summary>Represents the navigator which is mapped onto the association 'Sales.SalesOrderHeader.SalesTerritory - Sales.SalesTerritory.SalesOrderHeaders (m:1)'</summary>
		public virtual SalesTerritory SalesTerritory
		{
			get { return _salesTerritory; }
			set { _salesTerritory = value; }
		}
		
		#endregion
	}
}
