﻿


using System;
using System.ComponentModel;
using System.Collections.Generic;

namespace AdventureWorks.EntityClasses.Sales
{
	/// <summary>Class which represents the entity 'Sales.Store'</summary>
	public partial class Store
	{
		#region Class Member Declarations
		private Customer _customer;
		private SalesPerson _salesPerson;
		private ISet<StoreContact> _storeContacts;
		private System.Int32 _customerId;
		private System.String _demographics;
		private System.DateTime _modifiedDate;
		private System.String _name;
		private System.Guid _rowguid;
		#endregion

		/// <summary>Initializes a new instance of the <see cref="Store"/> class.</summary>
		public Store() : base()
		{
			_storeContacts = new HashSet<StoreContact>();
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
			return object.ReferenceEquals(this, obj);
		}
		

		#region Class Property Declarations
		/// <summary>Gets or sets the CustomerId field. </summary>	
		public virtual System.Int32 CustomerId
		{ 
			get { return _customerId; }
			set { _customerId = value; }
		}

		/// <summary>Gets or sets the Demographics field. </summary>	
		public virtual System.String Demographics
		{ 
			get { return _demographics; }
			set { _demographics = value; }
		}

		/// <summary>Gets or sets the ModifiedDate field. </summary>	
		public virtual System.DateTime ModifiedDate
		{ 
			get { return _modifiedDate; }
			set { _modifiedDate = value; }
		}

		/// <summary>Gets or sets the Name field. </summary>	
		public virtual System.String Name
		{ 
			get { return _name; }
			set { _name = value; }
		}

		/// <summary>Gets or sets the Rowguid field. </summary>	
		public virtual System.Guid Rowguid
		{ 
			get { return _rowguid; }
			set { _rowguid = value; }
		}

		/// <summary>Represents the navigator which is mapped onto the association 'Sales.Store.Customer - Sales.Customer.Store (1:1)'</summary>
		public virtual Customer Customer
		{
			get { return _customer; }
			set { _customer = value; }
		}
		
		/// <summary>Represents the navigator which is mapped onto the association 'Sales.Store.SalesPerson - Sales.SalesPerson.Stores (m:1)'</summary>
		public virtual SalesPerson SalesPerson
		{
			get { return _salesPerson; }
			set { _salesPerson = value; }
		}
		
		/// <summary>Represents the navigator which is mapped onto the association 'Sales.StoreContact.Store - Sales.Store.StoreContacts (m:1)'</summary>
		public virtual ISet<StoreContact> StoreContacts
		{
			get { return _storeContacts; }
			set { _storeContacts = value; }
		}
		
		#endregion
	}
}
