namespace AdventureWorks.Repository.Test.Model.Production
{
    using Person;
    using Production;
    using System;

	public class ProductCostHistory
	{
		public Product _product{ get; set; }
		public Nullable<System.DateTime> _endDate{ get; set; }
		public System.DateTime _modifiedDate{ get; set; }
		public System.Decimal _standardCost{ get; set; }
		public System.DateTime _startDate{ get; set; }
	}
}
