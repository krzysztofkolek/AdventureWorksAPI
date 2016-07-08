﻿


using System;
using System.ComponentModel;
using System.Collections.Generic;

namespace AdventureWorks.EntityClasses.Sales
{
    using Person;

    /// <summary>Class which represents the entity 'Sales.SalesTaxRate'</summary>
	public partial class SalesTaxRate
	{
		#region Class Member Declarations
		private StateProvince _stateProvince;
		private System.DateTime _modifiedDate;
		private System.String _name;
		private System.Guid _rowguid;
		private System.Int32 _salesTaxRateId;
		private System.Decimal _taxRate;
		private System.Byte _taxType;
		#endregion

		/// <summary>Initializes a new instance of the <see cref="SalesTaxRate"/> class.</summary>
		public SalesTaxRate() : base()
		{
			_salesTaxRateId = default(System.Int32);
			OnCreated();
		}

		/// <summary>Method called from the constructor</summary>
		partial void OnCreated();

		/// <summary>Returns a hash code for this instance.</summary>
		/// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
		public override int GetHashCode()
		{
			int toReturn = base.GetHashCode();
			toReturn ^= this.SalesTaxRateId.GetHashCode();
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
			SalesTaxRate toCompareWith = obj as SalesTaxRate;
			return toCompareWith == null ? false : ((this.SalesTaxRateId == toCompareWith.SalesTaxRateId));
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

		/// <summary>Gets the SalesTaxRateId field. </summary>	
		public virtual System.Int32 SalesTaxRateId
		{ 
			get { return _salesTaxRateId; }
		}

		/// <summary>Gets or sets the TaxRate field. </summary>	
		public virtual System.Decimal TaxRate
		{ 
			get { return _taxRate; }
			set { _taxRate = value; }
		}

		/// <summary>Gets or sets the TaxType field. </summary>	
		public virtual System.Byte TaxType
		{ 
			get { return _taxType; }
			set { _taxType = value; }
		}

		/// <summary>Represents the navigator which is mapped onto the association 'Sales.SalesTaxRate.StateProvince - Person.StateProvince.SalesTaxRates (m:1)'</summary>
		public virtual StateProvince StateProvince
		{
			get { return _stateProvince; }
			set { _stateProvince = value; }
		}
		
		#endregion
	}
}
