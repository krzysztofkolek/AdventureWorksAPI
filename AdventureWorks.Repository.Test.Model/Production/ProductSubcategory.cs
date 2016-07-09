namespace AdventureWorks.Repository.Test.Model.Production
{
    using Person;
    using Production;

	public class ProductSubcategory
	{
		public ProductCategory ProductCategory{ get; set; }
		public System.DateTime ModifiedDate{ get; set; }
		public System.String Name{ get; set; }
		public System.Int32 ProductSubcategoryId{ get; set; }
		public System.Guid Rowguid{ get; set; }
	}
}
