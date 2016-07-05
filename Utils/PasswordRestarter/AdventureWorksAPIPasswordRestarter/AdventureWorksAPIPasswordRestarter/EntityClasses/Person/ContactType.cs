


using System;
using System.ComponentModel;
using System.Collections.Generic;

namespace AdventureWorks.EntityClasses.Person
{
    using Purchasing;
    using Sales;

    /// <summary>Class which represents the entity 'Person.ContactType'</summary>
	public partial class ContactType
	{
		#region Class Member Declarations
		private ISet<VendorContact> _vendorContacts;
		private ISet<StoreContact> _storeContacts;
		private System.Int32 _contactTypeId;
		private System.DateTime _modifiedDate;
		private System.String _name;
		#endregion

		/// <summary>Initializes a new instance of the <see cref="ContactType"/> class.</summary>
		public ContactType() : base()
		{
			_vendorContacts = new HashSet<VendorContact>();
			_storeContacts = new HashSet<StoreContact>();
			_contactTypeId = default(System.Int32);
			OnCreated();
		}

		/// <summary>Method called from the constructor</summary>
		partial void OnCreated();

		/// <summary>Returns a hash code for this instance.</summary>
		/// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
		public override int GetHashCode()
		{
			int toReturn = base.GetHashCode();
			toReturn ^= this.ContactTypeId.GetHashCode();
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
			ContactType toCompareWith = obj as ContactType;
			return toCompareWith == null ? false : ((this.ContactTypeId == toCompareWith.ContactTypeId));
		}
		

		#region Class Property Declarations
		/// <summary>Gets the ContactTypeId field. </summary>	
		public virtual System.Int32 ContactTypeId
		{ 
			get { return _contactTypeId; }
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

		/// <summary>Represents the navigator which is mapped onto the association 'Purchasing.VendorContact.ContactType - Person.ContactType.VendorContacts (m:1)'</summary>
		public virtual ISet<VendorContact> VendorContacts
		{
			get { return _vendorContacts; }
			set { _vendorContacts = value; }
		}
		
		/// <summary>Represents the navigator which is mapped onto the association 'Sales.StoreContact.ContactType - Person.ContactType.StoreContacts (m:1)'</summary>
		public virtual ISet<StoreContact> StoreContacts
		{
			get { return _storeContacts; }
			set { _storeContacts = value; }
		}
		
		#endregion
	}
}
