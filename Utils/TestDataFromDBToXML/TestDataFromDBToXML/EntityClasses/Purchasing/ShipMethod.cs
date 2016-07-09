﻿


using System;
using System.ComponentModel;
using System.Collections.Generic;

namespace AdventureWorks.EntityClasses.Purchasing
{
    using Sales;

    /// <summary>Class which represents the entity 'Purchasing.ShipMethod'</summary>
	public partial class ShipMethod
	{
		#region Class Member Declarations
		private ISet<PurchaseOrderHeader> _purchaseOrderHeaders;
		private ISet<SalesOrderHeader> _salesOrderHeaders;
		private System.DateTime _modifiedDate;
		private System.String _name;
		private System.Guid _rowguid;
		private System.Decimal _shipBase;
		private System.Int32 _shipMethodId;
		private System.Decimal _shipRate;
		#endregion

		/// <summary>Initializes a new instance of the <see cref="ShipMethod"/> class.</summary>
		public ShipMethod() : base()
		{
			_purchaseOrderHeaders = new HashSet<PurchaseOrderHeader>();
			_salesOrderHeaders = new HashSet<SalesOrderHeader>();
			_shipMethodId = default(System.Int32);
			OnCreated();
		}

		/// <summary>Method called from the constructor</summary>
		partial void OnCreated();

		/// <summary>Returns a hash code for this instance.</summary>
		/// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
		public override int GetHashCode()
		{
			int toReturn = base.GetHashCode();
			toReturn ^= this.ShipMethodId.GetHashCode();
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
			ShipMethod toCompareWith = obj as ShipMethod;
			return toCompareWith == null ? false : ((this.ShipMethodId == toCompareWith.ShipMethodId));
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

		/// <summary>Gets or sets the Rowguid field. </summary>	
		public virtual System.Guid Rowguid
		{ 
			get { return _rowguid; }
			set { _rowguid = value; }
		}

		/// <summary>Gets or sets the ShipBase field. </summary>	
		public virtual System.Decimal ShipBase
		{ 
			get { return _shipBase; }
			set { _shipBase = value; }
		}

		/// <summary>Gets the ShipMethodId field. </summary>	
		public virtual System.Int32 ShipMethodId
		{ 
			get { return _shipMethodId; }
		}

		/// <summary>Gets or sets the ShipRate field. </summary>	
		public virtual System.Decimal ShipRate
		{ 
			get { return _shipRate; }
			set { _shipRate = value; }
		}

		/// <summary>Represents the navigator which is mapped onto the association 'Purchasing.PurchaseOrderHeader.ShipMethod - Purchasing.ShipMethod.PurchaseOrderHeaders (m:1)'</summary>
		public virtual ISet<PurchaseOrderHeader> PurchaseOrderHeaders
		{
			get { return _purchaseOrderHeaders; }
			set { _purchaseOrderHeaders = value; }
		}
		
		/// <summary>Represents the navigator which is mapped onto the association 'Sales.SalesOrderHeader.ShipMethod - Purchasing.ShipMethod.SalesOrderHeaders (m:1)'</summary>
		public virtual ISet<SalesOrderHeader> SalesOrderHeaders
		{
			get { return _salesOrderHeaders; }
			set { _salesOrderHeaders = value; }
		}
		
		#endregion
	}
}