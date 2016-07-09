namespace AdventureWorks.Repository.Test.Model.Sales
{
    using System;

	public class SpecialOffer
	{
		public System.String Category{ get; set; }
		public System.String Description{ get; set; }
		public System.Decimal DiscountPct{ get; set; }
		public System.DateTime EndDate{ get; set; }
		public Nullable<System.Int32> MaxQty{ get; set; }
		public System.Int32 MinQty{ get; set; }
		public System.DateTime ModifiedDate{ get; set; }
		public System.Guid Rowguid{ get; set; }
		public System.Int32 SpecialOfferId{ get; set; }
		public System.DateTime StartDate{ get; set; }
		public System.String Type{ get; set; }
	}
}
