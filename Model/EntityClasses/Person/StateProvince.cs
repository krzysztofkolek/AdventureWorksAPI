﻿


using System;
using System.ComponentModel;
using System.Collections.Generic;

namespace AdventureWorks.EntityClasses.Person
{
    using Sales;

    /// <summary>Class which represents the entity 'Person.StateProvince'</summary>
	public partial class StateProvince
	{
		#region Class Member Declarations
		private ISet<Address> _addresses;
		private CountryRegion _countryRegion;
		private ISet<SalesTaxRate> _salesTaxRates;
		private SalesTerritory _salesTerritory;
		private System.Boolean _isOnlyStateProvinceFlag;
		private System.DateTime _modifiedDate;
		private System.String _name;
		private System.Guid _rowguid;
		private System.String _stateProvinceCode;
		private System.Int32 _stateProvinceId;
		#endregion

		/// <summary>Initializes a new instance of the <see cref="StateProvince"/> class.</summary>
		public StateProvince() : base()
		{
			_addresses = new HashSet<Address>();
			_salesTaxRates = new HashSet<SalesTaxRate>();
			_stateProvinceId = default(System.Int32);
			OnCreated();
		}

		/// <summary>Method called from the constructor</summary>
		partial void OnCreated();

		/// <summary>Returns a hash code for this instance.</summary>
		/// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
		public override int GetHashCode()
		{
			int toReturn = base.GetHashCode();
			toReturn ^= this.StateProvinceId.GetHashCode();
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
			StateProvince toCompareWith = obj as StateProvince;
			return toCompareWith == null ? false : ((this.StateProvinceId == toCompareWith.StateProvinceId));
		}
		

		#region Class Property Declarations
		/// <summary>Gets or sets the IsOnlyStateProvinceFlag field. </summary>	
		public virtual System.Boolean IsOnlyStateProvinceFlag
		{ 
			get { return _isOnlyStateProvinceFlag; }
			set { _isOnlyStateProvinceFlag = value; }
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

		/// <summary>Gets or sets the StateProvinceCode field. </summary>	
		public virtual System.String StateProvinceCode
		{ 
			get { return _stateProvinceCode; }
			set { _stateProvinceCode = value; }
		}

		/// <summary>Gets the StateProvinceId field. </summary>	
		public virtual System.Int32 StateProvinceId
		{ 
			get { return _stateProvinceId; }
		}

		/// <summary>Represents the navigator which is mapped onto the association 'Person.Address.StateProvince - Person.StateProvince.Addresses (m:1)'</summary>
		public virtual ISet<Address> Addresses
		{
			get { return _addresses; }
			set { _addresses = value; }
		}
		
		/// <summary>Represents the navigator which is mapped onto the association 'Person.StateProvince.CountryRegion - Person.CountryRegion.StateProvinces (m:1)'</summary>
		public virtual CountryRegion CountryRegion
		{
			get { return _countryRegion; }
			set { _countryRegion = value; }
		}
		
		/// <summary>Represents the navigator which is mapped onto the association 'Sales.SalesTaxRate.StateProvince - Person.StateProvince.SalesTaxRates (m:1)'</summary>
		public virtual ISet<SalesTaxRate> SalesTaxRates
		{
			get { return _salesTaxRates; }
			set { _salesTaxRates = value; }
		}
		
		/// <summary>Represents the navigator which is mapped onto the association 'Person.StateProvince.SalesTerritory - Sales.SalesTerritory.StateProvinces (m:1)'</summary>
		public virtual SalesTerritory SalesTerritory
		{
			get { return _salesTerritory; }
			set { _salesTerritory = value; }
		}
		
		#endregion
	}
}