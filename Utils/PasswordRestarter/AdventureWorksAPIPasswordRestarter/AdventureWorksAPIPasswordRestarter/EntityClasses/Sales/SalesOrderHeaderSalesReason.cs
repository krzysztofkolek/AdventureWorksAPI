﻿


using System;
using System.ComponentModel;
using System.Collections.Generic;

namespace AdventureWorks.EntityClasses.Sales
{
	/// <summary>Class which represents the entity 'Sales.SalesOrderHeaderSalesReason'</summary>
	public partial class SalesOrderHeaderSalesReason
	{
		#region Class Member Declarations
		private SalesOrderHeader _salesOrderHeader;
		private SalesReason _salesReason;
		private System.DateTime _modifiedDate;
		#endregion

		/// <summary>Initializes a new instance of the <see cref="SalesOrderHeaderSalesReason"/> class.</summary>
		public SalesOrderHeaderSalesReason() : base()
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

		/// <summary>Represents the navigator which is mapped onto the association 'Sales.SalesOrderHeaderSalesReason.SalesOrderHeader - Sales.SalesOrderHeader.SalesOrderHeaderSalesReasons (m:1)'</summary>
		public virtual SalesOrderHeader SalesOrderHeader
		{
			get { return _salesOrderHeader; }
			set { _salesOrderHeader = value; }
		}
		
		/// <summary>Represents the navigator which is mapped onto the association 'Sales.SalesOrderHeaderSalesReason.SalesReason - Sales.SalesReason.SalesOrderHeaderSalesReasons (m:1)'</summary>
		public virtual SalesReason SalesReason
		{
			get { return _salesReason; }
			set { _salesReason = value; }
		}
		
		#endregion
	}
}
