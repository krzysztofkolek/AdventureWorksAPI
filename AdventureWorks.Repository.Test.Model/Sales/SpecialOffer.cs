namespace AdventureWorks.Repository.Test.Model.Sales
{
    using System;

	public class SpecialOffer
	{
		public System.String _category{ get; set; }
		public System.String _description{ get; set; }
		public System.Decimal _discountPct{ get; set; }
		public System.DateTime _endDate{ get; set; }
		public Nullable<System.Int32> _maxQty{ get; set; }
		public System.Int32 _minQty{ get; set; }
		public System.DateTime _modifiedDate{ get; set; }
		public System.Guid _rowguid{ get; set; }
		public System.Int32 _specialOfferId{ get; set; }
		public System.DateTime _startDate{ get; set; }
		public System.String _type{ get; set; }
	}
}
