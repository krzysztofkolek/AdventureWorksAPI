namespace AdventureWorks.Repository.Test.Model.Sales
{
    using Person;
    using Production;

	public class ShoppingCartItem
	{
		public Product _product{ get; set; }
		public System.DateTime _dateCreated{ get; set; }
		public System.DateTime _modifiedDate{ get; set; }
		public System.Int32 _quantity{ get; set; }
		public System.String _shoppingCartId{ get; set; }
		public System.Int32 _shoppingCartItemId{ get; set; }
	}
}
