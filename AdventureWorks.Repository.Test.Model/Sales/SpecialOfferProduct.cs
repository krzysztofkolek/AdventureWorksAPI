namespace AdventureWorks.Repository.Test.Model.Sales
{
    using Person;
    using Production;

	public class SpecialOfferProduct
	{
		public Product Product{ get; set; }
		public SpecialOffer SpecialOffer{ get; set; }
		public System.DateTime ModifiedDate{ get; set; }
		public System.Guid Rowguid{ get; set; }
	}
}
