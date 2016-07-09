namespace AdventureWorks.Repository.Test.Model.Production
{
    using Person;
    using Production;

	public class ProductModel
	{
		public System.String CatalogDescription{ get; set; }
		public System.String Instructions{ get; set; }
		public System.DateTime ModifiedDate{ get; set; }
		public System.String Name{ get; set; }
		public System.Int32 ProductModelId{ get; set; }
		public System.Guid Rowguid{ get; set; }
	}
}
