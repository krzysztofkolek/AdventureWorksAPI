namespace AdventureWorks.Repository.Test.Model.Production
{
    using Person;
    using Production;

	public class ProductReview
	{
		public Product _product{ get; set; }
		public System.String _comments{ get; set; }
		public System.String _emailAddress{ get; set; }
		public System.DateTime _modifiedDate{ get; set; }
		public System.Int32 _productReviewId{ get; set; }
		public System.Int32 _rating{ get; set; }
		public System.DateTime _reviewDate{ get; set; }
		public System.String _reviewerName{ get; set; }
	}
}
