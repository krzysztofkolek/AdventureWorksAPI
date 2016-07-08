namespace AdventureWorks.Repository.Test.Model.Production
{
    using Person;
    using Production;

	public class ProductDocument
	{
		public Document _document{ get; set; }
		public Product _product{ get; set; }
		public System.DateTime _modifiedDate{ get; set; }
	}
}
