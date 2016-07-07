﻿


using System;
using System.ComponentModel;
using System.Collections.Generic;

namespace AdventureWorks.EntityClasses.Production
{
	/// <summary>Class which represents the entity 'Production.ScrapReason'</summary>
	public partial class ScrapReason
	{
		#region Class Member Declarations
		private ISet<WorkOrder> _workOrders;
		private System.DateTime _modifiedDate;
		private System.String _name;
		private System.Int16 _scrapReasonId;
		#endregion

		/// <summary>Initializes a new instance of the <see cref="ScrapReason"/> class.</summary>
		public ScrapReason() : base()
		{
			_workOrders = new HashSet<WorkOrder>();
			_scrapReasonId = default(System.Int16);
			OnCreated();
		}

		/// <summary>Method called from the constructor</summary>
		partial void OnCreated();

		/// <summary>Returns a hash code for this instance.</summary>
		/// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
		public override int GetHashCode()
		{
			int toReturn = base.GetHashCode();
			toReturn ^= this.ScrapReasonId.GetHashCode();
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
			ScrapReason toCompareWith = obj as ScrapReason;
			return toCompareWith == null ? false : ((this.ScrapReasonId == toCompareWith.ScrapReasonId));
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

		/// <summary>Gets the ScrapReasonId field. </summary>	
		public virtual System.Int16 ScrapReasonId
		{ 
			get { return _scrapReasonId; }
		}

		/// <summary>Represents the navigator which is mapped onto the association 'Production.WorkOrder.ScrapReason - Production.ScrapReason.WorkOrders (m:1)'</summary>
		public virtual ISet<WorkOrder> WorkOrders
		{
			get { return _workOrders; }
			set { _workOrders = value; }
		}
		
		#endregion
	}
}