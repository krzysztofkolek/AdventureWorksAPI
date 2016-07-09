namespace AdventureWorks.Repository.Test.Model.Production
{
    using Person;
    using Production;

	public class TransactionHistory
	{
		public Product Product{ get; set; }
		public System.Decimal ActualCost{ get; set; }
		public System.DateTime ModifiedDate{ get; set; }
		public System.Int32 Quantity{ get; set; }
		public System.Int32 ReferenceOrderId{ get; set; }
		public System.Int32 ReferenceOrderLineId{ get; set; }
		public System.DateTime TransactionDate{ get; set; }
		public System.Int32 TransactionId{ get; set; }
		public System.String TransactionType{ get; set; }
	}
}
