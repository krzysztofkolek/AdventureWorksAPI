
namespace AdventureWorks.Repository.Test.Model.Production
{
    using System;

    public class ProductListPriceHistory
    {
        public Product Product { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public System.Decimal ListPrice { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public System.DateTime StartDate { get; set; }
    }
}
