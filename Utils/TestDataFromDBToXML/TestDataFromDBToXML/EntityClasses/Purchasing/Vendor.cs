


using System;
using System.ComponentModel;
using System.Collections.Generic;

namespace AdventureWorks.EntityClasses.Purchasing
{
	/// <summary>Class which represents the entity 'Purchasing.Vendor'</summary>
	public partial class Vendor
	{
		#region Class Member Declarations
		private ISet<ProductVendor> _productVendors;
		private ISet<PurchaseOrderHeader> _purchaseOrderHeaders;
		private ISet<VendorAddress> _vendorAddresses;
		private ISet<VendorContact> _vendorContacts;
		private System.String _accountNumber;
		private System.Boolean _activeFlag;
		private System.Byte _creditRating;
		private System.DateTime _modifiedDate;
		private System.String _name;
		private System.Boolean _preferredVendorStatus;
		private System.String _purchasingWebServiceUrl;
		private System.Int32 _vendorId;
		#endregion

		/// <summary>Initializes a new instance of the <see cref="Vendor"/> class.</summary>
		public Vendor() : base()
		{
			_productVendors = new HashSet<ProductVendor>();
			_purchaseOrderHeaders = new HashSet<PurchaseOrderHeader>();
			_vendorAddresses = new HashSet<VendorAddress>();
			_vendorContacts = new HashSet<VendorContact>();
			_vendorId = default(System.Int32);
			OnCreated();
		}

		/// <summary>Method called from the constructor</summary>
		partial void OnCreated();

		/// <summary>Returns a hash code for this instance.</summary>
		/// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
		public override int GetHashCode()
		{
			int toReturn = base.GetHashCode();
			toReturn ^= this.VendorId.GetHashCode();
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
			Vendor toCompareWith = obj as Vendor;
			return toCompareWith == null ? false : ((this.VendorId == toCompareWith.VendorId));
		}
		

		#region Class Property Declarations
		/// <summary>Gets or sets the AccountNumber field. </summary>	
		public virtual System.String AccountNumber
		{ 
			get { return _accountNumber; }
			set { _accountNumber = value; }
		}

		/// <summary>Gets or sets the ActiveFlag field. </summary>	
		public virtual System.Boolean ActiveFlag
		{ 
			get { return _activeFlag; }
			set { _activeFlag = value; }
		}

		/// <summary>Gets or sets the CreditRating field. </summary>	
		public virtual System.Byte CreditRating
		{ 
			get { return _creditRating; }
			set { _creditRating = value; }
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

		/// <summary>Gets or sets the PreferredVendorStatus field. </summary>	
		public virtual System.Boolean PreferredVendorStatus
		{ 
			get { return _preferredVendorStatus; }
			set { _preferredVendorStatus = value; }
		}

		/// <summary>Gets or sets the PurchasingWebServiceUrl field. </summary>	
		public virtual System.String PurchasingWebServiceUrl
		{ 
			get { return _purchasingWebServiceUrl; }
			set { _purchasingWebServiceUrl = value; }
		}

		/// <summary>Gets the VendorId field. </summary>	
		public virtual System.Int32 VendorId
		{ 
			get { return _vendorId; }
		}

		/// <summary>Represents the navigator which is mapped onto the association 'Purchasing.ProductVendor.Vendor - Purchasing.Vendor.ProductVendors (m:1)'</summary>
		public virtual ISet<ProductVendor> ProductVendors
		{
			get { return _productVendors; }
			set { _productVendors = value; }
		}
		
		/// <summary>Represents the navigator which is mapped onto the association 'Purchasing.PurchaseOrderHeader.Vendor - Purchasing.Vendor.PurchaseOrderHeaders (m:1)'</summary>
		public virtual ISet<PurchaseOrderHeader> PurchaseOrderHeaders
		{
			get { return _purchaseOrderHeaders; }
			set { _purchaseOrderHeaders = value; }
		}
		
		/// <summary>Represents the navigator which is mapped onto the association 'Purchasing.VendorAddress.Vendor - Purchasing.Vendor.VendorAddresses (m:1)'</summary>
		public virtual ISet<VendorAddress> VendorAddresses
		{
			get { return _vendorAddresses; }
			set { _vendorAddresses = value; }
		}
		
		/// <summary>Represents the navigator which is mapped onto the association 'Purchasing.VendorContact.Vendor - Purchasing.Vendor.VendorContacts (m:1)'</summary>
		public virtual ISet<VendorContact> VendorContacts
		{
			get { return _vendorContacts; }
			set { _vendorContacts = value; }
		}
		
		#endregion
	}
}
