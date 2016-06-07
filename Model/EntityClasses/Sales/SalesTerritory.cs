﻿


using System;
using System.ComponentModel;
using System.Collections.Generic;

namespace AdventureWorks.EntityClasses.Sales
{
    using Person;

    /// <summary>Class which represents the entity 'Sales.SalesTerritory'</summary>
	public partial class SalesTerritory
	{
		#region Class Member Declarations
		private ISet<StateProvince> _stateProvinces;
		private ISet<Customer> _customers;
		private ISet<SalesOrderHeader> _salesOrderHeaders;
		private ISet<SalesPerson> _salesPeople;
		private ISet<SalesTerritoryHistory> _salesTerritoryHistories;
		private System.Decimal _costLastYear;
		private System.Decimal _costYtd;
		private System.String _countryRegionCode;
		private System.String _group;
		private System.DateTime _modifiedDate;
		private System.String _name;
		private System.Guid _rowguid;
		private System.Decimal _salesLastYear;
		private System.Decimal _salesYtd;
		private System.Int32 _territoryId;
		#endregion

		/// <summary>Initializes a new instance of the <see cref="SalesTerritory"/> class.</summary>
		public SalesTerritory() : base()
		{
			_stateProvinces = new HashSet<StateProvince>();
			_customers = new HashSet<Customer>();
			_salesOrderHeaders = new HashSet<SalesOrderHeader>();
			_salesPeople = new HashSet<SalesPerson>();
			_salesTerritoryHistories = new HashSet<SalesTerritoryHistory>();
			_territoryId = default(System.Int32);
			OnCreated();
		}

		/// <summary>Method called from the constructor</summary>
		partial void OnCreated();

		/// <summary>Returns a hash code for this instance.</summary>
		/// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
		public override int GetHashCode()
		{
			int toReturn = base.GetHashCode();
			toReturn ^= this.TerritoryId.GetHashCode();
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
			SalesTerritory toCompareWith = obj as SalesTerritory;
			return toCompareWith == null ? false : ((this.TerritoryId == toCompareWith.TerritoryId));
		}
		

		#region Class Property Declarations
		/// <summary>Gets or sets the CostLastYear field. </summary>	
		public virtual System.Decimal CostLastYear
		{ 
			get { return _costLastYear; }
			set { _costLastYear = value; }
		}

		/// <summary>Gets or sets the CostYtd field. </summary>	
		public virtual System.Decimal CostYtd
		{ 
			get { return _costYtd; }
			set { _costYtd = value; }
		}

		/// <summary>Gets or sets the CountryRegionCode field. </summary>	
		public virtual System.String CountryRegionCode
		{ 
			get { return _countryRegionCode; }
			set { _countryRegionCode = value; }
		}

		/// <summary>Gets or sets the Group field. </summary>	
		public virtual System.String Group
		{ 
			get { return _group; }
			set { _group = value; }
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

		/// <summary>Gets or sets the SalesYtd field. </summary>	
		public virtual System.Decimal SalesYtd
		{ 
			get { return _salesYtd; }
			set { _salesYtd = value; }
		}

		/// <summary>Gets the TerritoryId field. </summary>	
		public virtual System.Int32 TerritoryId
		{ 
			get { return _territoryId; }
		}

		/// <summary>Represents the navigator which is mapped onto the association 'Person.StateProvince.SalesTerritory - Sales.SalesTerritory.StateProvinces (m:1)'</summary>
		public virtual ISet<StateProvince> StateProvinces
		{
			get { return _stateProvinces; }
			set { _stateProvinces = value; }
		}
		
		/// <summary>Represents the navigator which is mapped onto the association 'Sales.Customer.SalesTerritory - Sales.SalesTerritory.Customers (m:1)'</summary>
		public virtual ISet<Customer> Customers
		{
			get { return _customers; }
			set { _customers = value; }
		}
		
		/// <summary>Represents the navigator which is mapped onto the association 'Sales.SalesOrderHeader.SalesTerritory - Sales.SalesTerritory.SalesOrderHeaders (m:1)'</summary>
		public virtual ISet<SalesOrderHeader> SalesOrderHeaders
		{
			get { return _salesOrderHeaders; }
			set { _salesOrderHeaders = value; }
		}
		
		/// <summary>Represents the navigator which is mapped onto the association 'Sales.SalesPerson.SalesTerritory - Sales.SalesTerritory.SalesPeople (m:1)'</summary>
		public virtual ISet<SalesPerson> SalesPeople
		{
			get { return _salesPeople; }
			set { _salesPeople = value; }
		}
		
		/// <summary>Represents the navigator which is mapped onto the association 'Sales.SalesTerritoryHistory.SalesTerritory - Sales.SalesTerritory.SalesTerritoryHistories (m:1)'</summary>
		public virtual ISet<SalesTerritoryHistory> SalesTerritoryHistories
		{
			get { return _salesTerritoryHistories; }
			set { _salesTerritoryHistories = value; }
		}
		
		#endregion
	}
}