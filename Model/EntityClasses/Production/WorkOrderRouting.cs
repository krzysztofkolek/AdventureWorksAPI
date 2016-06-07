﻿


using System;
using System.ComponentModel;
using System.Collections.Generic;

namespace AdventureWorks.EntityClasses.Production
{
	/// <summary>Class which represents the entity 'Production.WorkOrderRouting'</summary>
	public partial class WorkOrderRouting
	{
		#region Class Member Declarations
		private Location _location;
		private WorkOrder _workOrder;
		private Nullable<System.Decimal> _actualCost;
		private Nullable<System.DateTime> _actualEndDate;
		private Nullable<System.Decimal> _actualResourceHrs;
		private Nullable<System.DateTime> _actualStartDate;
		private System.DateTime _modifiedDate;
		private System.Int16 _operationSequence;
		private System.Decimal _plannedCost;
		private System.Int32 _productId;
		private System.DateTime _scheduledEndDate;
		private System.DateTime _scheduledStartDate;
		#endregion

		/// <summary>Initializes a new instance of the <see cref="WorkOrderRouting"/> class.</summary>
		public WorkOrderRouting() : base()
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
		/// <summary>Gets or sets the ActualCost field. </summary>	
		public virtual Nullable<System.Decimal> ActualCost
		{ 
			get { return _actualCost; }
			set { _actualCost = value; }
		}

		/// <summary>Gets or sets the ActualEndDate field. </summary>	
		public virtual Nullable<System.DateTime> ActualEndDate
		{ 
			get { return _actualEndDate; }
			set { _actualEndDate = value; }
		}

		/// <summary>Gets or sets the ActualResourceHrs field. </summary>	
		public virtual Nullable<System.Decimal> ActualResourceHrs
		{ 
			get { return _actualResourceHrs; }
			set { _actualResourceHrs = value; }
		}

		/// <summary>Gets or sets the ActualStartDate field. </summary>	
		public virtual Nullable<System.DateTime> ActualStartDate
		{ 
			get { return _actualStartDate; }
			set { _actualStartDate = value; }
		}

		/// <summary>Gets or sets the ModifiedDate field. </summary>	
		public virtual System.DateTime ModifiedDate
		{ 
			get { return _modifiedDate; }
			set { _modifiedDate = value; }
		}

		/// <summary>Gets or sets the OperationSequence field. </summary>	
		public virtual System.Int16 OperationSequence
		{ 
			get { return _operationSequence; }
			set { _operationSequence = value; }
		}

		/// <summary>Gets or sets the PlannedCost field. </summary>	
		public virtual System.Decimal PlannedCost
		{ 
			get { return _plannedCost; }
			set { _plannedCost = value; }
		}

		/// <summary>Gets or sets the ProductId field. </summary>	
		public virtual System.Int32 ProductId
		{ 
			get { return _productId; }
			set { _productId = value; }
		}

		/// <summary>Gets or sets the ScheduledEndDate field. </summary>	
		public virtual System.DateTime ScheduledEndDate
		{ 
			get { return _scheduledEndDate; }
			set { _scheduledEndDate = value; }
		}

		/// <summary>Gets or sets the ScheduledStartDate field. </summary>	
		public virtual System.DateTime ScheduledStartDate
		{ 
			get { return _scheduledStartDate; }
			set { _scheduledStartDate = value; }
		}

		/// <summary>Represents the navigator which is mapped onto the association 'Production.WorkOrderRouting.Location - Production.Location.WorkOrderRoutings (m:1)'</summary>
		public virtual Location Location
		{
			get { return _location; }
			set { _location = value; }
		}
		
		/// <summary>Represents the navigator which is mapped onto the association 'Production.WorkOrderRouting.WorkOrder - Production.WorkOrder.WorkOrderRoutings (m:1)'</summary>
		public virtual WorkOrder WorkOrder
		{
			get { return _workOrder; }
			set { _workOrder = value; }
		}
		
		#endregion
	}
}
