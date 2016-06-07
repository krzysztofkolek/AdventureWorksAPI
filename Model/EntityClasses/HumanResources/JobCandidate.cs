﻿


using System;
using System.ComponentModel;
using System.Collections.Generic;

namespace AdventureWorks.EntityClasses.HumanResources
{
	/// <summary>Class which represents the entity 'HumanResources.JobCandidate'</summary>
	public partial class JobCandidate
	{
		#region Class Member Declarations
		private Employee _employee;
		private System.Int32 _jobCandidateId;
		private System.DateTime _modifiedDate;
		private System.String _resume;
		#endregion

		/// <summary>Initializes a new instance of the <see cref="JobCandidate"/> class.</summary>
		public JobCandidate() : base()
		{
			_jobCandidateId = default(System.Int32);
			OnCreated();
		}

		/// <summary>Method called from the constructor</summary>
		partial void OnCreated();

		/// <summary>Returns a hash code for this instance.</summary>
		/// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
		public override int GetHashCode()
		{
			int toReturn = base.GetHashCode();
			toReturn ^= this.JobCandidateId.GetHashCode();
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
			JobCandidate toCompareWith = obj as JobCandidate;
			return toCompareWith == null ? false : ((this.JobCandidateId == toCompareWith.JobCandidateId));
		}
		

		#region Class Property Declarations
		/// <summary>Gets the JobCandidateId field. </summary>	
		public virtual System.Int32 JobCandidateId
		{ 
			get { return _jobCandidateId; }
		}

		/// <summary>Gets or sets the ModifiedDate field. </summary>	
		public virtual System.DateTime ModifiedDate
		{ 
			get { return _modifiedDate; }
			set { _modifiedDate = value; }
		}

		/// <summary>Gets or sets the Resume field. </summary>	
		public virtual System.String Resume
		{ 
			get { return _resume; }
			set { _resume = value; }
		}

		/// <summary>Represents the navigator which is mapped onto the association 'HumanResources.JobCandidate.Employee - HumanResources.Employee.JobCandidates (m:1)'</summary>
		public virtual Employee Employee
		{
			get { return _employee; }
			set { _employee = value; }
		}
		
		#endregion
	}
}
