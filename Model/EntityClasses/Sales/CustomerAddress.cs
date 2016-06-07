﻿


using System;
using System.ComponentModel;
using System.Collections.Generic;

namespace AdventureWorks.EntityClasses.Sales
{
    using Person;

    /// <summary>Class which represents the entity 'Sales.CustomerAddress'</summary>
	public partial class CustomerAddress
	{
		#region Class Member Declarations
		private Address _address;
		private AddressType _addressType;
		private Customer _customer;
		private System.DateTime _modifiedDate;
		private System.Guid _rowguid;
		#endregion

		/// <summary>Initializes a new instance of the <see cref="CustomerAddress"/> class.</summary>
		public CustomerAddress() : base()
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

		/// <summary>Represents the navigator which is mapped onto the association 'Sales.CustomerAddress.Address - Person.Address.CustomerAddresses (m:1)'</summary>
		public virtual Address Address
		{
			get { return _address; }
			set { _address = value; }
		}
		
		/// <summary>Represents the navigator which is mapped onto the association 'Sales.CustomerAddress.AddressType - Person.AddressType.CustomerAddresses (m:1)'</summary>
		public virtual AddressType AddressType
		{
			get { return _addressType; }
			set { _addressType = value; }
		}
		
		/// <summary>Represents the navigator which is mapped onto the association 'Sales.CustomerAddress.Customer - Sales.Customer.CustomerAddresses (m:1)'</summary>
		public virtual Customer Customer
		{
			get { return _customer; }
			set { _customer = value; }
		}
		
		#endregion
	}
}
