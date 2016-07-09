namespace AdventureWorks.Repository.Test.Model.Sales
{
    using Person;
    using Production;

	public class ShoppingCartItem
	{
		public Product Product{ get; set; }
		public System.DateTime DateCreated{ get; set; }
		public System.DateTime ModifiedDate{ get; set; }
		public System.Int32 Quantity{ get; set; }
		public System.String ShoppingCartId{ get; set; }
		public System.Int32 ShoppingCartItemId{ get; set; }
	}
}
