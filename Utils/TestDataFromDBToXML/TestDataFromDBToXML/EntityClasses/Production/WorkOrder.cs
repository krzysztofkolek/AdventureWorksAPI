﻿


using System;
using System.ComponentModel;
using System.Collections.Generic;

namespace AdventureWorks.EntityClasses.Production
{
    using Person;
    using Production;

    /// <summary>Class which represents the entity 'Production.WorkOrder'</summary>
	public partial class WorkOrder
	{
		#region Class Member Declarations
		private Product _product;
		private ScrapReason _scrapReason;
		private ISet<WorkOrderRouting> _workOrderRoutings;
		private System.DateTime _dueDate;
		private Nullable<System.DateTime> _endDate;
		private System.DateTime _modifiedDate;
		private System.Int32 _orderQty;
		private System.Int16 _scrappedQty;
		private System.DateTime _startDate;
		private System.Int32 _stockedQty;
		private System.Int32 _workOrderId;
		#endregion

		/// <summary>Initializes a new instance of the <see cref="WorkOrder"/> class.</summary>
		public WorkOrder() : base()
		{
			_workOrderRoutings = new HashSet<WorkOrderRouting>();
			_stockedQty = default(System.Int32);
			_workOrderId = default(System.Int32);
			OnCreated();
		}

		/// <summary>Method called from the constructor</summary>
		partial void OnCreated();

		/// <summary>Returns a hash code for this instance.</summary>
		/// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
		public override int GetHashCode()
		{
			int toReturn = base.GetHashCode();
			toReturn ^= this.WorkOrderId.GetHashCode();
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
			WorkOrder toCompareWith = obj as WorkOrder;
			return toCompareWith == null ? false : ((this.WorkOrderId == toCompareWith.WorkOrderId));
		}
		

		#region Class Property Declarations
		/// <summary>Gets or sets the DueDate field. </summary>	
		public virtual System.DateTime DueDate
		{ 
			get { return _dueDate; }
			set { _dueDate = value; }
		}

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

		/// <summary>Gets or sets the OrderQty field. </summary>	
		public virtual System.Int32 OrderQty
		{ 
			get { return _orderQty; }
			set { _orderQty = value; }
		}

		/// <summary>Gets or sets the ScrappedQty field. </summary>	
		public virtual System.Int16 ScrappedQty
		{ 
			get { return _scrappedQty; }
			set { _scrappedQty = value; }
		}

		/// <summary>Gets or sets the StartDate field. </summary>	
		public virtual System.DateTime StartDate
		{ 
			get { return _startDate; }
			set { _startDate = value; }
		}

		/// <summary>Gets the StockedQty field. </summary>	
		public virtual System.Int32 StockedQty
		{ 
			get { return _stockedQty; }
		}

		/// <summary>Gets the WorkOrderId field. </summary>	
		public virtual System.Int32 WorkOrderId
		{ 
			get { return _workOrderId; }
		}

		/// <summary>Represents the navigator which is mapped onto the association 'Production.WorkOrder.Product - Production.Product.WorkOrders (m:1)'</summary>
		public virtual Product Product
		{
			get { return _product; }
			set { _product = value; }
		}
		
		/// <summary>Represents the navigator which is mapped onto the association 'Production.WorkOrder.ScrapReason - Production.ScrapReason.WorkOrders (m:1)'</summary>
		public virtual ScrapReason ScrapReason
		{
			get { return _scrapReason; }
			set { _scrapReason = value; }
		}
		
		/// <summary>Represents the navigator which is mapped onto the association 'Production.WorkOrderRouting.WorkOrder - Production.WorkOrder.WorkOrderRoutings (m:1)'</summary>
		public virtual ISet<WorkOrderRouting> WorkOrderRoutings
		{
			get { return _workOrderRoutings; }
			set { _workOrderRoutings = value; }
		}
		
		#endregion
	}
}
