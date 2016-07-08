namespace AdventureWorks.Repository.Test.Model.Purchasing
{
    using Person;
    using Production;

	public class PurchaseOrderDetail
	{
		public Product _product{ get; set; }
		public PurchaseOrderHeader _purchaseOrderHeader{ get; set; }
		public System.DateTime _dueDate{ get; set; }
		public System.Decimal _lineTotal{ get; set; }
		public System.DateTime _modifiedDate{ get; set; }
		public System.Int16 _orderQty{ get; set; }
		public System.Int32 _purchaseOrderDetailId{ get; set; }
		public System.Decimal _receivedQty{ get; set; }
		public System.Decimal _rejectedQty{ get; set; }
		public System.Decimal _stockedQty{ get; set; }
		public System.Decimal _unitPrice{ get; set; }
	}
}
