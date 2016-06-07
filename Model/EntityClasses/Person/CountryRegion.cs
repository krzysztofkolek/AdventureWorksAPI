


using System;
using System.ComponentModel;
using System.Collections.Generic;

namespace AdventureWorks.EntityClasses.Person
{
    using Sales;

    /// <summary>Class which represents the entity 'Person.CountryRegion'</summary>
	public partial class CountryRegion
	{
		#region Class Member Declarations
		private ISet<StateProvince> _stateProvinces;
		private ISet<CountryRegionCurrency> _countryRegionCurrencies;
		private System.String _countryRegionCode;
		private System.DateTime _modifiedDate;
		private System.String _name;
		#endregion

		/// <summary>Initializes a new instance of the <see cref="CountryRegion"/> class.</summary>
		public CountryRegion() : base()
		{
			_stateProvinces = new HashSet<StateProvince>();
			_countryRegionCurrencies = new HashSet<CountryRegionCurrency>();
			OnCreated();
		}

		/// <summary>Method called from the constructor</summary>
		partial void OnCreated();

		/// <summary>Returns a hash code for this instance.</summary>
		/// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
		public override int GetHashCode()
		{
			int toReturn = base.GetHashCode();
			toReturn ^= this.CountryRegionCode.GetHashCode();
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
			CountryRegion toCompareWith = obj as CountryRegion;
			return toCompareWith == null ? false : ((this.CountryRegionCode == toCompareWith.CountryRegionCode));
		}
		

		#region Class Property Declarations
		/// <summary>Gets or sets the CountryRegionCode field. </summary>	
		public virtual System.String CountryRegionCode
		{ 
			get { return _countryRegionCode; }
			set { _countryRegionCode = value; }
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

		/// <summary>Represents the navigator which is mapped onto the association 'Person.StateProvince.CountryRegion - Person.CountryRegion.StateProvinces (m:1)'</summary>
		public virtual ISet<StateProvince> StateProvinces
		{
			get { return _stateProvinces; }
			set { _stateProvinces = value; }
		}
		
		/// <summary>Represents the navigator which is mapped onto the association 'Sales.CountryRegionCurrency.CountryRegion - Person.CountryRegion.CountryRegionCurrencies (m:1)'</summary>
		public virtual ISet<CountryRegionCurrency> CountryRegionCurrencies
		{
			get { return _countryRegionCurrencies; }
			set { _countryRegionCurrencies = value; }
		}
		
		#endregion
	}
}
