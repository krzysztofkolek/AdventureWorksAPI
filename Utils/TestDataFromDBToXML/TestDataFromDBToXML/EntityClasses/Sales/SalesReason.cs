﻿


using System;
using System.ComponentModel;
using System.Collections.Generic;

namespace AdventureWorks.EntityClasses.Sales
{
	/// <summary>Class which represents the entity 'Sales.SalesReason'</summary>
	public partial class SalesReason
	{
		#region Class Member Declarations
		private ISet<SalesOrderHeaderSalesReason> _salesOrderHeaderSalesReasons;
		private System.DateTime _modifiedDate;
		private System.String _name;
		private System.String _reasonType;
		private System.Int32 _salesReasonId;
		#endregion

		/// <summary>Initializes a new instance of the <see cref="SalesReason"/> class.</summary>
		public SalesReason() : base()
		{
			_salesOrderHeaderSalesReasons = new HashSet<SalesOrderHeaderSalesReason>();
			_salesReasonId = default(System.Int32);
			OnCreated();
		}

		/// <summary>Method called from the constructor</summary>
		partial void OnCreated();

		/// <summary>Returns a hash code for this instance.</summary>
		/// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
		public override int GetHashCode()
		{
			int toReturn = base.GetHashCode();
			toReturn ^= this.SalesReasonId.GetHashCode();
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
			SalesReason toCompareWith = obj as SalesReason;
			return toCompareWith == null ? false : ((this.SalesReasonId == toCompareWith.SalesReasonId));
		}
		

		#region Class Property Declarations
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

		/// <summary>Gets or sets the ReasonType field. </summary>	
		public virtual System.String ReasonType
		{ 
			get { return _reasonType; }
			set { _reasonType = value; }
		}

		/// <summary>Gets the SalesReasonId field. </summary>	
		public virtual System.Int32 SalesReasonId
		{ 
			get { return _salesReasonId; }
		}

		/// <summary>Represents the navigator which is mapped onto the association 'Sales.SalesOrderHeaderSalesReason.SalesReason - Sales.SalesReason.SalesOrderHeaderSalesReasons (m:1)'</summary>
		public virtual ISet<SalesOrderHeaderSalesReason> SalesOrderHeaderSalesReasons
		{
			get { return _salesOrderHeaderSalesReasons; }
			set { _salesOrderHeaderSalesReasons = value; }
		}
		
		#endregion
	}
}
