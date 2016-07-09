namespace AdventureWorks.Repository.Test.Model.Production
{
    using Person;
    using Production;

	public class ProductProductPhoto
	{
		public Product Product{ get; set; }
		public ProductPhoto ProductPhoto{ get; set; }
		public System.DateTime ModifiedDate{ get; set; }
		public System.Boolean Primary{ get; set; }
	}
}
