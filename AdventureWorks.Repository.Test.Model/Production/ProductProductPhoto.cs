namespace AdventureWorks.Repository.Test.Model.Production
{
    using Person;
    using Production;

	public class ProductProductPhoto
	{
		public Product _product{ get; set; }
		public ProductPhoto _productPhoto{ get; set; }
		public System.DateTime _modifiedDate{ get; set; }
		public System.Boolean _primary{ get; set; }
	}
}
