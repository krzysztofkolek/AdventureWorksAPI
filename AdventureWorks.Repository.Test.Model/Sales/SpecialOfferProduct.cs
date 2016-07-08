namespace AdventureWorks.Repository.Test.Model.Sales
{
    using Person;
    using Production;

	public class SpecialOfferProduct
	{
		public Product _product{ get; set; }
		public SpecialOffer _specialOffer{ get; set; }
		public System.DateTime _modifiedDate{ get; set; }
		public System.Guid _rowguid{ get; set; }
	}
}
