


using System;
using System.ComponentModel;
using System.Collections.Generic;

namespace AdventureWorks.EntityClasses.Sales
{
	/// <summary>Class which represents the entity 'Sales.Customer'</summary>
	public partial class Customer
	{
		#region Class Member Declarations
		private ISet<CustomerAddress> _customerAddresses;
		private Individual _individual;
		private ISet<SalesOrderHeader> _salesOrderHeaders;
		private SalesTerritory _salesTerritory;
		private Store _store;
		private System.String _accountNumber;
		private System.Int32 _customerId;
		private System.String _customerType;
		private System.DateTime _modifiedDate;
		private System.Guid _rowguid;
		#endregion

		/// <summary>Initializes a new instance of the <see cref="Customer"/> class.</summary>
		public Customer() : base()
		{
			_customerAddresses = new HashSet<CustomerAddress>();
			_salesOrderHeaders = new HashSet<SalesOrderHeader>();
			_accountNumber = default(System.String);
			_customerId = default(System.Int32);
			OnCreated();
		}

		/// <summary>Method called from the constructor</summary>
		partial void OnCreated();

		/// <summary>Returns a hash code for this instance.</summary>
		/// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
		public override int GetHashCode()
		{
			int toReturn = base.GetHashCode();
			toReturn ^= this.CustomerId.GetHashCode();
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
			Customer toCompareWith = obj as Customer;
			return toCompareWith == null ? false : ((this.CustomerId == toCompareWith.CustomerId));
		}
		

		#region Class Property Declarations
		/// <summary>Gets the AccountNumber field. </summary>	
		public virtual System.String AccountNumber
		{ 
			get { return _accountNumber; }
		}

		/// <summary>Gets the CustomerId field. </summary>	
		public virtual System.Int32 CustomerId
		{ 
			get { return _customerId; }
		}

		/// <summary>Gets or sets the CustomerType field. </summary>	
		public virtual System.String CustomerType
		{ 
			get { return _customerType; }
			set { _customerType = value; }
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

		/// <summary>Represents the navigator which is mapped onto the association 'Sales.CustomerAddress.Customer - Sales.Customer.CustomerAddresses (m:1)'</summary>
		public virtual ISet<CustomerAddress> CustomerAddresses
		{
			get { return _customerAddresses; }
			set { _customerAddresses = value; }
		}
		
		/// <summary>Represents the navigator which is mapped onto the association 'Sales.Individual.Customer - Sales.Customer.Individual (1:1)'</summary>
		public virtual Individual Individual
		{
			get { return _individual; }
			set { _individual = value; }
		}
		
		/// <summary>Represents the navigator which is mapped onto the association 'Sales.SalesOrderHeader.Customer - Sales.Customer.SalesOrderHeaders (m:1)'</summary>
		public virtual ISet<SalesOrderHeader> SalesOrderHeaders
		{
			get { return _salesOrderHeaders; }
			set { _salesOrderHeaders = value; }
		}
		
		/// <summary>Represents the navigator which is mapped onto the association 'Sales.Customer.SalesTerritory - Sales.SalesTerritory.Customers (m:1)'</summary>
		public virtual SalesTerritory SalesTerritory
		{
			get { return _salesTerritory; }
			set { _salesTerritory = value; }
		}
		
		/// <summary>Represents the navigator which is mapped onto the association 'Sales.Store.Customer - Sales.Customer.Store (1:1)'</summary>
		public virtual Store Store
		{
			get { return _store; }
			set { _store = value; }
		}
		
		#endregion
	}
}
