﻿


using System;
using System.ComponentModel;
using System.Collections.Generic;

namespace AdventureWorks.EntityClasses.Purchasing
{
    using Person;

    /// <summary>Class which represents the entity 'Purchasing.VendorContact'</summary>
	public partial class VendorContact
	{
		#region Class Member Declarations
		private Contact _contact;
		private ContactType _contactType;
		private Vendor _vendor;
		private System.DateTime _modifiedDate;
		#endregion

		/// <summary>Initializes a new instance of the <see cref="VendorContact"/> class.</summary>
		public VendorContact() : base()
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

		/// <summary>Represents the navigator which is mapped onto the association 'Purchasing.VendorContact.Contact - Person.Contact.VendorContacts (m:1)'</summary>
		public virtual Contact Contact
		{
			get { return _contact; }
			set { _contact = value; }
		}
		
		/// <summary>Represents the navigator which is mapped onto the association 'Purchasing.VendorContact.ContactType - Person.ContactType.VendorContacts (m:1)'</summary>
		public virtual ContactType ContactType
		{
			get { return _contactType; }
			set { _contactType = value; }
		}
		
		/// <summary>Represents the navigator which is mapped onto the association 'Purchasing.VendorContact.Vendor - Purchasing.Vendor.VendorContacts (m:1)'</summary>
		public virtual Vendor Vendor
		{
			get { return _vendor; }
			set { _vendor = value; }
		}
		
		#endregion
	}
}
