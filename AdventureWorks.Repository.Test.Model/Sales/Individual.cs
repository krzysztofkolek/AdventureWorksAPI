namespace AdventureWorks.Repository.Test.Model.Sales
{
    using Person;

	public class Individual
	{
		public Contact _contact{ get; set; }
		public Customer _customer{ get; set; }
		public System.Int32 _customerId{ get; set; }
		public System.String _demographics{ get; set; }
		public System.DateTime _modifiedDate{ get; set; }
	}
}
