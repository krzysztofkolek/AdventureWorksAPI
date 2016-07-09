using System;
namespace AdventureWorks.Repository.Test.Model.Production
{
	public class WorkOrderRouting
	{
		public Location Location{ get; set; }
		public WorkOrder WorkOrder{ get; set; }
		public Nullable<System.Decimal> ActualCost{ get; set; }
		public Nullable<System.DateTime> ActualEndDate{ get; set; }
		public Nullable<System.Decimal> ActualResourceHrs{ get; set; }
		public Nullable<System.DateTime> ActualStartDate{ get; set; }
		public System.DateTime ModifiedDate{ get; set; }
		public System.Int16 OperationSequence{ get; set; }
		public System.Decimal PlannedCost{ get; set; }
		public System.Int32 ProductId{ get; set; }
		public System.DateTime ScheduledEndDate{ get; set; }
		public System.DateTime ScheduledStartDate{ get; set; }
	}
}
