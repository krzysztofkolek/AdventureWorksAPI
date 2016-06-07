﻿


using System;
using System.ComponentModel;
using System.Collections.Generic;

namespace AdventureWorks.EntityClasses.Sales
{
	/// <summary>Class which represents the entity 'Sales.SalesPersonQuotaHistory'</summary>
	public partial class SalesPersonQuotaHistory
	{
		#region Class Member Declarations
		private SalesPerson _salesPerson;
		private System.DateTime _modifiedDate;
		private System.DateTime _quotaDate;
		private System.Guid _rowguid;
		private System.Decimal _salesQuota;
		#endregion

		/// <summary>Initializes a new instance of the <see cref="SalesPersonQuotaHistory"/> class.</summary>
		public SalesPersonQuotaHistory() : base()
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

		/// <summary>Gets or sets the QuotaDate field. </summary>	
		public virtual System.DateTime QuotaDate
		{ 
			get { return _quotaDate; }
			set { _quotaDate = value; }
		}

		/// <summary>Gets or sets the Rowguid field. </summary>	
		public virtual System.Guid Rowguid
		{ 
			get { return _rowguid; }
			set { _rowguid = value; }
		}

		/// <summary>Gets or sets the SalesQuota field. </summary>	
		public virtual System.Decimal SalesQuota
		{ 
			get { return _salesQuota; }
			set { _salesQuota = value; }
		}

		/// <summary>Represents the navigator which is mapped onto the association 'Sales.SalesPersonQuotaHistory.SalesPerson - Sales.SalesPerson.SalesPersonQuotaHistories (m:1)'</summary>
		public virtual SalesPerson SalesPerson
		{
			get { return _salesPerson; }
			set { _salesPerson = value; }
		}
		
		#endregion
	}
}
