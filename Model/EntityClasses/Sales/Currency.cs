﻿


using System;
using System.ComponentModel;
using System.Collections.Generic;

namespace AdventureWorks.EntityClasses.Sales
{
	/// <summary>Class which represents the entity 'Sales.Currency'</summary>
	public partial class Currency
	{
		#region Class Member Declarations
		private ISet<CountryRegionCurrency> _countryRegionCurrencies;
		private ISet<CurrencyRate> _currencyRates;
		private ISet<CurrencyRate> _currencyRates1;
		private System.String _currencyCode;
		private System.DateTime _modifiedDate;
		private System.String _name;
		#endregion

		/// <summary>Initializes a new instance of the <see cref="Currency"/> class.</summary>
		public Currency() : base()
		{
			_countryRegionCurrencies = new HashSet<CountryRegionCurrency>();
			_currencyRates = new HashSet<CurrencyRate>();
			_currencyRates1 = new HashSet<CurrencyRate>();
			OnCreated();
		}

		/// <summary>Method called from the constructor</summary>
		partial void OnCreated();

		/// <summary>Returns a hash code for this instance.</summary>
		/// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
		public override int GetHashCode()
		{
			int toReturn = base.GetHashCode();
			toReturn ^= this.CurrencyCode.GetHashCode();
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
			Currency toCompareWith = obj as Currency;
			return toCompareWith == null ? false : ((this.CurrencyCode == toCompareWith.CurrencyCode));
		}
		

		#region Class Property Declarations
		/// <summary>Gets or sets the CurrencyCode field. </summary>	
		public virtual System.String CurrencyCode
		{ 
			get { return _currencyCode; }
			set { _currencyCode = value; }
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

		/// <summary>Represents the navigator which is mapped onto the association 'Sales.CountryRegionCurrency.Currency - Sales.Currency.CountryRegionCurrencies (m:1)'</summary>
		public virtual ISet<CountryRegionCurrency> CountryRegionCurrencies
		{
			get { return _countryRegionCurrencies; }
			set { _countryRegionCurrencies = value; }
		}
		
		/// <summary>Represents the navigator which is mapped onto the association 'Sales.CurrencyRate.Currency - Sales.Currency.CurrencyRates (m:1)'</summary>
		public virtual ISet<CurrencyRate> CurrencyRates
		{
			get { return _currencyRates; }
			set { _currencyRates = value; }
		}
		
		/// <summary>Represents the navigator which is mapped onto the association 'Sales.CurrencyRate.Currency1 - Sales.Currency.CurrencyRates1 (m:1)'</summary>
		public virtual ISet<CurrencyRate> CurrencyRates1
		{
			get { return _currencyRates1; }
			set { _currencyRates1 = value; }
		}
		
		#endregion
	}
}
