namespace AdventureWorks.Repository.Test.Model.Purchasing
{
    using Person;
    using Production;

	public class PurchaseOrderDetail
	{
		public Product Product{ get; set; }
		public PurchaseOrderHeader PurchaseOrderHeader{ get; set; }
		public System.DateTime DueDate{ get; set; }
		public System.Decimal LineTotal{ get; set; }
		public System.DateTime ModifiedDate{ get; set; }
		public System.Int16 OrderQty{ get; set; }
		public System.Int32 PurchaseOrderDetailId{ get; set; }
		public System.Decimal ReceivedQty{ get; set; }
		public System.Decimal RejectedQty{ get; set; }
		public System.Decimal StockedQty{ get; set; }
		public System.Decimal UnitPrice{ get; set; }
	}
}
