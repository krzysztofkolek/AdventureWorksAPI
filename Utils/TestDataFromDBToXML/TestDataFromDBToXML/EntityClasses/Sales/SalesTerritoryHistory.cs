﻿


using System;
using System.ComponentModel;
using System.Collections.Generic;

namespace AdventureWorks.EntityClasses.Sales
{
	/// <summary>Class which represents the entity 'Sales.SalesTerritoryHistory'</summary>
	public partial class SalesTerritoryHistory
	{
		#region Class Member Declarations
		private SalesPerson _salesPerson;
		private SalesTerritory _salesTerritory;
		private Nullable<System.DateTime> _endDate;
		private System.DateTime _modifiedDate;
		private System.Guid _rowguid;
		private System.DateTime _startDate;
		#endregion

		/// <summary>Initializes a new instance of the <see cref="SalesTerritoryHistory"/> class.</summary>
		public SalesTerritoryHistory() : base()
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
		/// <summary>Gets or sets the EndDate field. </summary>	
		public virtual Nullable<System.DateTime> EndDate
		{ 
			get { return _endDate; }
			set { _endDate = value; }
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

		/// <summary>Gets or sets the StartDate field. </summary>	
		public virtual System.DateTime StartDate
		{ 
			get { return _startDate; }
			set { _startDate = value; }
		}

		/// <summary>Represents the navigator which is mapped onto the association 'Sales.SalesTerritoryHistory.SalesPerson - Sales.SalesPerson.SalesTerritoryHistories (m:1)'</summary>
		public virtual SalesPerson SalesPerson
		{
			get { return _salesPerson; }
			set { _salesPerson = value; }
		}
		
		/// <summary>Represents the navigator which is mapped onto the association 'Sales.SalesTerritoryHistory.SalesTerritory - Sales.SalesTerritory.SalesTerritoryHistories (m:1)'</summary>
		public virtual SalesTerritory SalesTerritory
		{
			get { return _salesTerritory; }
			set { _salesTerritory = value; }
		}
		
		#endregion
	}
}
