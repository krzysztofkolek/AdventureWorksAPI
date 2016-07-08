namespace AdventureWorks.Repository.Test.Model.Production
{
    using Person;
    using Production;

	public class ProductInventory
	{
		public Location _location{ get; set; }
		public Product _product{ get; set; }
		public System.Byte _bin{ get; set; }
		public System.DateTime _modifiedDate{ get; set; }
		public System.Int16 _quantity{ get; set; }
		public System.Guid _rowguid{ get; set; }
		public System.String _shelf{ get; set; }
	}
}
