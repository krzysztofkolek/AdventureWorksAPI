namespace AdventureWorks.Repository.Test.Model.Production
{
    using Person;
    using Production;
    using System;

	public class WorkOrder
	{
		public Product _product{ get; set; }
		public ScrapReason _scrapReason{ get; set; }
		public System.DateTime _dueDate{ get; set; }
		public Nullable<System.DateTime> _endDate{ get; set; }
		public System.DateTime _modifiedDate{ get; set; }
		public System.Int32 _orderQty{ get; set; }
		public System.Int16 _scrappedQty{ get; set; }
		public System.DateTime _startDate{ get; set; }
		public System.Int32 _stockedQty{ get; set; }
		public System.Int32 _workOrderId{ get; set; }
	}
}
