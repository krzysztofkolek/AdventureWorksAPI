namespace AdventureWorks.Repository.Test.Model.Sales
{
    using Person;

	public class ContactCreditCard
	{
		public Contact _contact{ get; set; }
		public CreditCard _creditCard{ get; set; }
		public System.DateTime _modifiedDate{ get; set; }
	}
}
