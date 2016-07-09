namespace AdventureWorks.Repository.Test.Model.Sales
{
    using Person;

	public class ContactCreditCard
	{
		public Contact Contact{ get; set; }
		public CreditCard CreditCard{ get; set; }
		public System.DateTime ModifiedDate{ get; set; }
	}
}
