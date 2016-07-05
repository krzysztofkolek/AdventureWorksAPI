﻿


using System;
using System.ComponentModel;
using System.Collections.Generic;

namespace AdventureWorks.EntityClasses.HumanResources
{
	/// <summary>Class which represents the entity 'HumanResources.Shift'</summary>
	public partial class Shift
	{
		#region Class Member Declarations
		private ISet<EmployeeDepartmentHistory> _employeeDepartmentHistories;
		private System.DateTime _endTime;
		private System.DateTime _modifiedDate;
		private System.String _name;
		private System.Byte _shiftId;
		private System.DateTime _startTime;
		#endregion

		/// <summary>Initializes a new instance of the <see cref="Shift"/> class.</summary>
		public Shift() : base()
		{
			_employeeDepartmentHistories = new HashSet<EmployeeDepartmentHistory>();
			_shiftId = default(System.Byte);
			OnCreated();
		}

		/// <summary>Method called from the constructor</summary>
		partial void OnCreated();

		/// <summary>Returns a hash code for this instance.</summary>
		/// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
		public override int GetHashCode()
		{
			int toReturn = base.GetHashCode();
			toReturn ^= this.ShiftId.GetHashCode();
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
			Shift toCompareWith = obj as Shift;
			return toCompareWith == null ? false : ((this.ShiftId == toCompareWith.ShiftId));
		}
		

		#region Class Property Declarations
		/// <summary>Gets or sets the EndTime field. </summary>	
		public virtual System.DateTime EndTime
		{ 
			get { return _endTime; }
			set { _endTime = value; }
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

		/// <summary>Gets the ShiftId field. </summary>	
		public virtual System.Byte ShiftId
		{ 
			get { return _shiftId; }
		}

		/// <summary>Gets or sets the StartTime field. </summary>	
		public virtual System.DateTime StartTime
		{ 
			get { return _startTime; }
			set { _startTime = value; }
		}

		/// <summary>Represents the navigator which is mapped onto the association 'HumanResources.EmployeeDepartmentHistory.Shift - HumanResources.Shift.EmployeeDepartmentHistories (m:1)'</summary>
		public virtual ISet<EmployeeDepartmentHistory> EmployeeDepartmentHistories
		{
			get { return _employeeDepartmentHistories; }
			set { _employeeDepartmentHistories = value; }
		}
		
		#endregion
	}
}
