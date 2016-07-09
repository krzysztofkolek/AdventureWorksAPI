namespace AdventureWorks.Repository.Test.Model.Production
{
    using Person;
    using Production;
    using System;

	public class WorkOrder
	{
		public Product Product{ get; set; }
		public ScrapReason ScrapReason{ get; set; }
		public System.DateTime DueDate{ get; set; }
		public Nullable<System.DateTime> EndDate{ get; set; }
		public System.DateTime ModifiedDate{ get; set; }
		public System.Int32 OrderQty{ get; set; }
		public System.Int16 ScrappedQty{ get; set; }
		public System.DateTime StartDate{ get; set; }
		public System.Int32 StockedQty{ get; set; }
		public System.Int32 WorkOrderId{ get; set; }
	}
}
