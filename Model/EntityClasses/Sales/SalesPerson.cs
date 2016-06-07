


using System;
using System.ComponentModel;
using System.Collections.Generic;

namespace AdventureWorks.EntityClasses.Sales
{
    using HumanResources;

    /// <summary>Class which represents the entity 'Sales.SalesPerson'</summary>
	public partial class SalesPerson
	{
		#region Class Member Declarations
		private Employee _employee;
		private ISet<SalesOrderHeader> _salesOrderHeaders;
		private ISet<SalesPersonQuotaHistory> _salesPersonQuotaHistories;
		private SalesTerritory _salesTerritory;
		private ISet<SalesTerritoryHistory> _salesTerritoryHistories;
		private ISet<Store> _stores;
		private System.Decimal _bonus;
		private System.Decimal _commissionPct;
		private System.DateTime _modifiedDate;
		private System.Guid _rowguid;
		private System.Decimal _salesLastYear;
		private System.Int32 _salesPersonId;
		private Nullable<System.Decimal> _salesQuota;
		private System.Decimal _salesYtd;
		#endregion

		/// <summary>Initializes a new instance of the <see cref="SalesPerson"/> class.</summary>
		public SalesPerson() : base()
		{
			_salesOrderHeaders = new HashSet<SalesOrderHeader>();
			_salesPersonQuotaHistories = new HashSet<SalesPersonQuotaHistory>();
			_salesTerritoryHistories = new HashSet<SalesTerritoryHistory>();
			_stores = new HashSet<Store>();
			OnCreated();
		}

		/// <summary>Method called from the constructor</summary>
		partial void OnCreated();

		/// <summary>Returns a hash code for this instance.</summary>
		/// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
		public override int GetHashCode()
		{
			int toReturn = base.GetHashCode();
			toReturn ^= this.SalesPersonId.GetHashCode();
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
		/// <summary>Gets or sets the Bonus field. </summary>	
		public virtual System.Decimal Bonus
		{ 
			get { return _bonus; }
			set { _bonus = value; }
		}

		/// <summary>Gets or sets the CommissionPct field. </summary>	
		public virtual System.Decimal CommissionPct
		{ 
			get { return _commissionPct; }
			set { _commissionPct = value; }
		}

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

		/// <summary>Gets or sets the SalesLastYear field. </summary>	
		public virtual System.Decimal SalesLastYear
		{ 
			get { return _salesLastYear; }
			set { _salesLastYear = value; }
		}

		/// <summary>Gets or sets the SalesPersonId field. </summary>	
		public virtual System.Int32 SalesPersonId
		{ 
			get { return _salesPersonId; }
			set { _salesPersonId = value; }
		}

		/// <summary>Gets or sets the SalesQuota field. </summary>	
		public virtual Nullable<System.Decimal> SalesQuota
		{ 
			get { return _salesQuota; }
			set { _salesQuota = value; }
		}

		/// <summary>Gets or sets the SalesYtd field. </summary>	
		public virtual System.Decimal SalesYtd
		{ 
			get { return _salesYtd; }
			set { _salesYtd = value; }
		}

		/// <summary>Represents the navigator which is mapped onto the association 'Sales.SalesPerson.Employee - HumanResources.Employee.SalesPerson (1:1)'</summary>
		public virtual Employee Employee
		{
			get { return _employee; }
			set { _employee = value; }
		}
		
		/// <summary>Represents the navigator which is mapped onto the association 'Sales.SalesOrderHeader.SalesPerson - Sales.SalesPerson.SalesOrderHeaders (m:1)'</summary>
		public virtual ISet<SalesOrderHeader> SalesOrderHeaders
		{
			get { return _salesOrderHeaders; }
			set { _salesOrderHeaders = value; }
		}
		
		/// <summary>Represents the navigator which is mapped onto the association 'Sales.SalesPersonQuotaHistory.SalesPerson - Sales.SalesPerson.SalesPersonQuotaHistories (m:1)'</summary>
		public virtual ISet<SalesPersonQuotaHistory> SalesPersonQuotaHistories
		{
			get { return _salesPersonQuotaHistories; }
			set { _salesPersonQuotaHistories = value; }
		}
		
		/// <summary>Represents the navigator which is mapped onto the association 'Sales.SalesPerson.SalesTerritory - Sales.SalesTerritory.SalesPeople (m:1)'</summary>
		public virtual SalesTerritory SalesTerritory
		{
			get { return _salesTerritory; }
			set { _salesTerritory = value; }
		}
		
		/// <summary>Represents the navigator which is mapped onto the association 'Sales.SalesTerritoryHistory.SalesPerson - Sales.SalesPerson.SalesTerritoryHistories (m:1)'</summary>
		public virtual ISet<SalesTerritoryHistory> SalesTerritoryHistories
		{
			get { return _salesTerritoryHistories; }
			set { _salesTerritoryHistories = value; }
		}
		
		/// <summary>Represents the navigator which is mapped onto the association 'Sales.Store.SalesPerson - Sales.SalesPerson.Stores (m:1)'</summary>
		public virtual ISet<Store> Stores
		{
			get { return _stores; }
			set { _stores = value; }
		}
		
		#endregion
	}
}
