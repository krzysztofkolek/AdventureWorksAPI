


using System;
using System.ComponentModel;
using System.Collections.Generic;

namespace AdventureWorks.EntityClasses.Person
{
    using Purchasing;
    using Sales;

    /// <summary>Class which represents the entity 'Person.AddressType'</summary>
	public partial class AddressType
	{
		#region Class Member Declarations
		private ISet<VendorAddress> _vendorAddresses;
		private ISet<CustomerAddress> _customerAddresses;
		private System.Int32 _addressTypeId;
		private System.DateTime _modifiedDate;
		private System.String _name;
		private System.Guid _rowguid;
		#endregion

		/// <summary>Initializes a new instance of the <see cref="AddressType"/> class.</summary>
		public AddressType() : base()
		{
			_vendorAddresses = new HashSet<VendorAddress>();
			_customerAddresses = new HashSet<CustomerAddress>();
			_addressTypeId = default(System.Int32);
			OnCreated();
		}

		/// <summary>Method called from the constructor</summary>
		partial void OnCreated();

		/// <summary>Returns a hash code for this instance.</summary>
		/// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
		public override int GetHashCode()
		{
			int toReturn = base.GetHashCode();
			toReturn ^= this.AddressTypeId.GetHashCode();
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
			AddressType toCompareWith = obj as AddressType;
			return toCompareWith == null ? false : ((this.AddressTypeId == toCompareWith.AddressTypeId));
		}
		

		#region Class Property Declarations
		/// <summary>Gets the AddressTypeId field. </summary>	
		public virtual System.Int32 AddressTypeId
		{ 
			get { return _addressTypeId; }
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

		/// <summary>Represents the navigator which is mapped onto the association 'Purchasing.VendorAddress.AddressType - Person.AddressType.VendorAddresses (m:1)'</summary>
		public virtual ISet<VendorAddress> VendorAddresses
		{
			get { return _vendorAddresses; }
			set { _vendorAddresses = value; }
		}
		
		/// <summary>Represents the navigator which is mapped onto the association 'Sales.CustomerAddress.AddressType - Person.AddressType.CustomerAddresses (m:1)'</summary>
		public virtual ISet<CustomerAddress> CustomerAddresses
		{
			get { return _customerAddresses; }
			set { _customerAddresses = value; }
		}
		
		#endregion
	}
}
