namespace AdventureWorks.Repository.Test.Model.Production
{
    using Person;
    using Production;

	public class TransactionHistory
	{
		public Product _product{ get; set; }
		public System.Decimal _actualCost{ get; set; }
		public System.DateTime _modifiedDate{ get; set; }
		public System.Int32 _quantity{ get; set; }
		public System.Int32 _referenceOrderId{ get; set; }
		public System.Int32 _referenceOrderLineId{ get; set; }
		public System.DateTime _transactionDate{ get; set; }
		public System.Int32 _transactionId{ get; set; }
		public System.String _transactionType{ get; set; }
	}
}
