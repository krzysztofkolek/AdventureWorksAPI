﻿


using System;
using System.ComponentModel;
using System.Collections.Generic;

namespace AdventureWorks.EntityClasses.HumanResources
{
	/// <summary>Class which represents the entity 'HumanResources.EmployeePayHistory'</summary>
	public partial class EmployeePayHistory
	{
		#region Class Member Declarations
		private Employee _employee;
		private System.DateTime _modifiedDate;
		private System.Byte _payFrequency;
		private System.Decimal _rate;
		private System.DateTime _rateChangeDate;
		#endregion

		/// <summary>Initializes a new instance of the <see cref="EmployeePayHistory"/> class.</summary>
		public EmployeePayHistory() : base()
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

		/// <summary>Gets or sets the PayFrequency field. </summary>	
		public virtual System.Byte PayFrequency
		{ 
			get { return _payFrequency; }
			set { _payFrequency = value; }
		}

		/// <summary>Gets or sets the Rate field. </summary>	
		public virtual System.Decimal Rate
		{ 
			get { return _rate; }
			set { _rate = value; }
		}

		/// <summary>Gets or sets the RateChangeDate field. </summary>	
		public virtual System.DateTime RateChangeDate
		{ 
			get { return _rateChangeDate; }
			set { _rateChangeDate = value; }
		}

		/// <summary>Represents the navigator which is mapped onto the association 'HumanResources.EmployeePayHistory.Employee - HumanResources.Employee.EmployeePayHistories (m:1)'</summary>
		public virtual Employee Employee
		{
			get { return _employee; }
			set { _employee = value; }
		}
		
		#endregion
	}
}
