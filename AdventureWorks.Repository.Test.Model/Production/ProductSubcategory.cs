namespace AdventureWorks.Repository.Test.Model.Production
{
    using Person;
    using Production;

	public class ProductSubcategory
	{
		public ProductCategory _productCategory{ get; set; }
		public System.DateTime _modifiedDate{ get; set; }
		public System.String _name{ get; set; }
		public System.Int32 _productSubcategoryId{ get; set; }
		public System.Guid _rowguid{ get; set; }
	}
}
