namespace AdventureWorks.Repository.Test.Model.Sales
{
    using Person;

	public class Individual
	{
		public Contact Contact{ get; set; }
		public Customer Customer{ get; set; }
		public System.Int32 CustomerId{ get; set; }
		public System.String Demographics{ get; set; }
		public System.DateTime ModifiedDate{ get; set; }
	}
}
