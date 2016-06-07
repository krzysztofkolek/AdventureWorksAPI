﻿


using System;
using System.ComponentModel;
using System.Collections.Generic;

namespace AdventureWorks.EntityClasses.Sales
{
    using Person;

    /// <summary>Class which represents the entity 'Sales.StoreContact'</summary>
	public partial class StoreContact
	{
		#region Class Member Declarations
		private Contact _contact;
		private ContactType _contactType;
		private Store _store;
		private System.DateTime _modifiedDate;
		private System.Guid _rowguid;
		#endregion

		/// <summary>Initializes a new instance of the <see cref="StoreContact"/> class.</summary>
		public StoreContact() : base()
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

		/// <summary>Represents the navigator which is mapped onto the association 'Sales.StoreContact.Contact - Person.Contact.StoreContacts (m:1)'</summary>
		public virtual Contact Contact
		{
			get { return _contact; }
			set { _contact = value; }
		}
		
		/// <summary>Represents the navigator which is mapped onto the association 'Sales.StoreContact.ContactType - Person.ContactType.StoreContacts (m:1)'</summary>
		public virtual ContactType ContactType
		{
			get { return _contactType; }
			set { _contactType = value; }
		}
		
		/// <summary>Represents the navigator which is mapped onto the association 'Sales.StoreContact.Store - Sales.Store.StoreContacts (m:1)'</summary>
		public virtual Store Store
		{
			get { return _store; }
			set { _store = value; }
		}
		
		#endregion
	}
}
