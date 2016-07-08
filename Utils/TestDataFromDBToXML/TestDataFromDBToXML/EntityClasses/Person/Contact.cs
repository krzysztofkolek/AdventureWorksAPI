


using System;
using System.ComponentModel;
using System.Collections.Generic;

namespace AdventureWorks.EntityClasses.Person
{
    using HumanResources;
    using Purchasing;
    using Sales;

    /// <summary>Class which represents the entity 'Person.Contact'</summary>
	public partial class Contact
	{
		#region Class Member Declarations
		private ISet<Employee> _employees;
		private ISet<VendorContact> _vendorContacts;
		private ISet<ContactCreditCard> _contactCreditCards;
		private ISet<Individual> _individuals;
		private ISet<SalesOrderHeader> _salesOrderHeaders;
		private ISet<StoreContact> _storeContacts;
		private System.String _additionalContactInfo;
		private System.Int32 _contactId;
		private System.String _emailAddress;
		private System.Int32 _emailPromotion;
		private System.String _firstName;
		private System.String _lastName;
		private System.String _middleName;
		private System.DateTime _modifiedDate;
		private System.Boolean _nameStyle;
		private System.String _passwordHash;
		private System.String _passwordSalt;
		private System.String _phone;
		private System.Guid _rowguid;
		private System.String _suffix;
		private System.String _title;
		#endregion

		/// <summary>Initializes a new instance of the <see cref="Contact"/> class.</summary>
		public Contact() : base()
		{
			_employees = new HashSet<Employee>();
			_vendorContacts = new HashSet<VendorContact>();
			_contactCreditCards = new HashSet<ContactCreditCard>();
			_individuals = new HashSet<Individual>();
			_salesOrderHeaders = new HashSet<SalesOrderHeader>();
			_storeContacts = new HashSet<StoreContact>();
			_contactId = default(System.Int32);
			OnCreated();
		}

		/// <summary>Method called from the constructor</summary>
		partial void OnCreated();

		/// <summary>Returns a hash code for this instance.</summary>
		/// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
		public override int GetHashCode()
		{
			int toReturn = base.GetHashCode();
			toReturn ^= this.ContactId.GetHashCode();
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
			Contact toCompareWith = obj as Contact;
			return toCompareWith == null ? false : ((this.ContactId == toCompareWith.ContactId));
		}
		

		#region Class Property Declarations
		/// <summary>Gets or sets the AdditionalContactInfo field. </summary>	
		public virtual System.String AdditionalContactInfo
		{ 
			get { return _additionalContactInfo; }
			set { _additionalContactInfo = value; }
		}

		/// <summary>Gets the ContactId field. </summary>	
		public virtual System.Int32 ContactId
		{ 
			get { return _contactId; }
		}

		/// <summary>Gets or sets the EmailAddress field. </summary>	
		public virtual System.String EmailAddress
		{ 
			get { return _emailAddress; }
			set { _emailAddress = value; }
		}

		/// <summary>Gets or sets the EmailPromotion field. </summary>	
		public virtual System.Int32 EmailPromotion
		{ 
			get { return _emailPromotion; }
			set { _emailPromotion = value; }
		}

		/// <summary>Gets or sets the FirstName field. </summary>	
		public virtual System.String FirstName
		{ 
			get { return _firstName; }
			set { _firstName = value; }
		}

		/// <summary>Gets or sets the LastName field. </summary>	
		public virtual System.String LastName
		{ 
			get { return _lastName; }
			set { _lastName = value; }
		}

		/// <summary>Gets or sets the MiddleName field. </summary>	
		public virtual System.String MiddleName
		{ 
			get { return _middleName; }
			set { _middleName = value; }
		}

		/// <summary>Gets or sets the ModifiedDate field. </summary>	
		public virtual System.DateTime ModifiedDate
		{ 
			get { return _modifiedDate; }
			set { _modifiedDate = value; }
		}

		/// <summary>Gets or sets the NameStyle field. </summary>	
		public virtual System.Boolean NameStyle
		{ 
			get { return _nameStyle; }
			set { _nameStyle = value; }
		}

		/// <summary>Gets or sets the PasswordHash field. </summary>	
		public virtual System.String PasswordHash
		{ 
			get { return _passwordHash; }
			set { _passwordHash = value; }
		}

		/// <summary>Gets or sets the PasswordSalt field. </summary>	
		public virtual System.String PasswordSalt
		{ 
			get { return _passwordSalt; }
			set { _passwordSalt = value; }
		}

		/// <summary>Gets or sets the Phone field. </summary>	
		public virtual System.String Phone
		{ 
			get { return _phone; }
			set { _phone = value; }
		}

		/// <summary>Gets or sets the Rowguid field. </summary>	
		public virtual System.Guid Rowguid
		{ 
			get { return _rowguid; }
			set { _rowguid = value; }
		}

		/// <summary>Gets or sets the Suffix field. </summary>	
		public virtual System.String Suffix
		{ 
			get { return _suffix; }
			set { _suffix = value; }
		}

		/// <summary>Gets or sets the Title field. </summary>	
		public virtual System.String Title
		{ 
			get { return _title; }
			set { _title = value; }
		}

		/// <summary>Represents the navigator which is mapped onto the association 'HumanResources.Employee.Contact - Person.Contact.Employees (m:1)'</summary>
		public virtual ISet<Employee> Employees
		{
			get { return _employees; }
			set { _employees = value; }
		}
		
		/// <summary>Represents the navigator which is mapped onto the association 'Purchasing.VendorContact.Contact - Person.Contact.VendorContacts (m:1)'</summary>
		public virtual ISet<VendorContact> VendorContacts
		{
			get { return _vendorContacts; }
			set { _vendorContacts = value; }
		}
		
		/// <summary>Represents the navigator which is mapped onto the association 'Sales.ContactCreditCard.Contact - Person.Contact.ContactCreditCards (m:1)'</summary>
		public virtual ISet<ContactCreditCard> ContactCreditCards
		{
			get { return _contactCreditCards; }
			set { _contactCreditCards = value; }
		}
		
		/// <summary>Represents the navigator which is mapped onto the association 'Sales.Individual.Contact - Person.Contact.Individuals (m:1)'</summary>
		public virtual ISet<Individual> Individuals
		{
			get { return _individuals; }
			set { _individuals = value; }
		}
		
		/// <summary>Represents the navigator which is mapped onto the association 'Sales.SalesOrderHeader.Contact - Person.Contact.SalesOrderHeaders (m:1)'</summary>
		public virtual ISet<SalesOrderHeader> SalesOrderHeaders
		{
			get { return _salesOrderHeaders; }
			set { _salesOrderHeaders = value; }
		}
		
		/// <summary>Represents the navigator which is mapped onto the association 'Sales.StoreContact.Contact - Person.Contact.StoreContacts (m:1)'</summary>
		public virtual ISet<StoreContact> StoreContacts
		{
			get { return _storeContacts; }
			set { _storeContacts = value; }
		}
		
		#endregion
	}
}
