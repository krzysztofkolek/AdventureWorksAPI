namespace AdventureWorks.Repository.Test.Model.Production
{
    using Person;
    using Production;

	public class ProductReview
	{
		public Product Product{ get; set; }
		public System.String Comments{ get; set; }
		public System.String EmailAddress{ get; set; }
		public System.DateTime ModifiedDate{ get; set; }
		public System.Int32 ProductReviewId{ get; set; }
		public System.Int32 Rating{ get; set; }
		public System.DateTime ReviewDate{ get; set; }
		public System.String ReviewerName{ get; set; }
	}
}
