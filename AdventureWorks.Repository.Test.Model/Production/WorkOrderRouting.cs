using System;
namespace AdventureWorks.Repository.Test.Model.Production
{
	public class WorkOrderRouting
	{
		public Location _location{ get; set; }
		public WorkOrder _workOrder{ get; set; }
		public Nullable<System.Decimal> _actualCost{ get; set; }
		public Nullable<System.DateTime> _actualEndDate{ get; set; }
		public Nullable<System.Decimal> _actualResourceHrs{ get; set; }
		public Nullable<System.DateTime> _actualStartDate{ get; set; }
		public System.DateTime _modifiedDate{ get; set; }
		public System.Int16 _operationSequence{ get; set; }
		public System.Decimal _plannedCost{ get; set; }
		public System.Int32 _productId{ get; set; }
		public System.DateTime _scheduledEndDate{ get; set; }
		public System.DateTime _scheduledStartDate{ get; set; }
	}
}
