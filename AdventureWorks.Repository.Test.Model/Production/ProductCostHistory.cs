namespace AdventureWorks.Repository.Test.Model.Production
{
    using System;

    public class ProductCostHistory
    {
        public Product Product { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public System.Decimal StandardCost { get; set; }
        public System.DateTime StartDate { get; set; }
    }
}
