namespace AdventureWorks.EntityClasses.Person
{
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using HumanResources;
    using Purchasing;
    using Sales;

    /// <summary>Class which represents the entity 'Person.Address'</summary>
	public partial class Address
	{
		#region Class Member Declarations
		private ISet<EmployeeAddress> _employeeAddresses;
		private StateProvince _stateProvince;
		private ISet<VendorAddress> _vendorAddresses;
		private ISet<CustomerAddress> _customerAddresses;
		private ISet<SalesOrderHeader> _salesOrderHeaders;
		private ISet<SalesOrderHeader> _salesOrderHeaders1;
		private System.Int32 _addressId;
		private System.String _addressLine1;
		private System.String _addressLine2;
		private System.String _city;
		private System.DateTime _modifiedDate;
		private System.String _postalCode;
		private System.Guid _rowguid;
		#endregion

		/// <summary>Initializes a new instance of the <see cref="Address"/> class.</summary>
		public Address() : base()
		{
			_employeeAddresses = new HashSet<EmployeeAddress>();
			_vendorAddresses = new HashSet<VendorAddress>();
			_customerAddresses = new HashSet<CustomerAddress>();
			_salesOrderHeaders = new HashSet<SalesOrderHeader>();
			_salesOrderHeaders1 = new HashSet<SalesOrderHeader>();
			_addressId = default(System.Int32);
			OnCreated();
		}

		/// <summary>Method called from the constructor</summary>
		partial void OnCreated();

		/// <summary>Returns a hash code for this instance.</summary>
		/// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
		public override int GetHashCode()
		{
			int toReturn = base.GetHashCode();
			toReturn ^= this.AddressId.GetHashCode();
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
			Address toCompareWith = obj as Address;
			return toCompareWith == null ? false : ((this.AddressId == toCompareWith.AddressId));
		}
		

		#region Class Property Declarations
		/// <summary>Gets the AddressId field. </summary>	
		public virtual System.Int32 AddressId
		{ 
			get { return _addressId; }
		}

		/// <summary>Gets or sets the AddressLine1 field. </summary>	
		public virtual System.String AddressLine1
		{ 
			get { return _addressLine1; }
			set { _addressLine1 = value; }
		}

		/// <summary>Gets or sets the AddressLine2 field. </summary>	
		public virtual System.String AddressLine2
		{ 
			get { return _addressLine2; }
			set { _addressLine2 = value; }
		}

		/// <summary>Gets or sets the City field. </summary>	
		public virtual System.String City
		{ 
			get { return _city; }
			set { _city = value; }
		}

		/// <summary>Gets or sets the ModifiedDate field. </summary>	
		public virtual System.DateTime ModifiedDate
		{ 
			get { return _modifiedDate; }
			set { _modifiedDate = value; }
		}

		/// <summary>Gets or sets the PostalCode field. </summary>	
		public virtual System.String PostalCode
		{ 
			get { return _postalCode; }
			set { _postalCode = value; }
		}

		/// <summary>Gets or sets the Rowguid field. </summary>	
		public virtual System.Guid Rowguid
		{ 
			get { return _rowguid; }
			set { _rowguid = value; }
		}

		/// <summary>Represents the navigator which is mapped onto the association 'HumanResources.EmployeeAddress.Address - Person.Address.EmployeeAddresses (m:1)'</summary>
		public virtual ISet<EmployeeAddress> EmployeeAddresses
		{
			get { return _employeeAddresses; }
			set { _employeeAddresses = value; }
		}
		
		/// <summary>Represents the navigator which is mapped onto the association 'Person.Address.StateProvince - Person.StateProvince.Addresses (m:1)'</summary>
		public virtual StateProvince StateProvince
		{
			get { return _stateProvince; }
			set { _stateProvince = value; }
		}
		
		/// <summary>Represents the navigator which is mapped onto the association 'Purchasing.VendorAddress.Address - Person.Address.VendorAddresses (m:1)'</summary>
		public virtual ISet<VendorAddress> VendorAddresses
		{
			get { return _vendorAddresses; }
			set { _vendorAddresses = value; }
		}
		
		/// <summary>Represents the navigator which is mapped onto the association 'Sales.CustomerAddress.Address - Person.Address.CustomerAddresses (m:1)'</summary>
		public virtual ISet<CustomerAddress> CustomerAddresses
		{
			get { return _customerAddresses; }
			set { _customerAddresses = value; }
		}
		
		/// <summary>Represents the navigator which is mapped onto the association 'Sales.SalesOrderHeader.Address - Person.Address.SalesOrderHeaders (m:1)'</summary>
		public virtual ISet<SalesOrderHeader> SalesOrderHeaders
		{
			get { return _salesOrderHeaders; }
			set { _salesOrderHeaders = value; }
		}
		
		/// <summary>Represents the navigator which is mapped onto the association 'Sales.SalesOrderHeader.Address1 - Person.Address.SalesOrderHeaders1 (m:1)'</summary>
		public virtual ISet<SalesOrderHeader> SalesOrderHeaders1
		{
			get { return _salesOrderHeaders1; }
			set { _salesOrderHeaders1 = value; }
		}
		
		#endregion
	}
}
