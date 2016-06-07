﻿


using System;
using System.ComponentModel;
using System.Collections.Generic;

namespace AdventureWorks.EntityClasses.HumanResources
{
	/// <summary>Class which represents the entity 'HumanResources.EmployeeDepartmentHistory'</summary>
	public partial class EmployeeDepartmentHistory
	{
		#region Class Member Declarations
		private Department _department;
		private Employee _employee;
		private Shift _shift;
		private Nullable<System.DateTime> _endDate;
		private System.DateTime _modifiedDate;
		private System.DateTime _startDate;
		#endregion

		/// <summary>Initializes a new instance of the <see cref="EmployeeDepartmentHistory"/> class.</summary>
		public EmployeeDepartmentHistory() : base()
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

		/// <summary>Gets or sets the StartDate field. </summary>	
		public virtual System.DateTime StartDate
		{ 
			get { return _startDate; }
			set { _startDate = value; }
		}

		/// <summary>Represents the navigator which is mapped onto the association 'HumanResources.EmployeeDepartmentHistory.Department - HumanResources.Department.EmployeeDepartmentHistories (m:1)'</summary>
		public virtual Department Department
		{
			get { return _department; }
			set { _department = value; }
		}
		
		/// <summary>Represents the navigator which is mapped onto the association 'HumanResources.EmployeeDepartmentHistory.Employee - HumanResources.Employee.EmployeeDepartmentHistories (m:1)'</summary>
		public virtual Employee Employee
		{
			get { return _employee; }
			set { _employee = value; }
		}
		
		/// <summary>Represents the navigator which is mapped onto the association 'HumanResources.EmployeeDepartmentHistory.Shift - HumanResources.Shift.EmployeeDepartmentHistories (m:1)'</summary>
		public virtual Shift Shift
		{
			get { return _shift; }
			set { _shift = value; }
		}
		
		#endregion
	}
}