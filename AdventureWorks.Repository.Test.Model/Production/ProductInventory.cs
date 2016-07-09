namespace AdventureWorks.Repository.Test.Model.Production
{

    public class ProductInventory
    {
        public Location Location { get; set; }
        public Product Product { get; set; }
        public System.Byte Bin { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public System.Int16 Quantity { get; set; }
        public System.Guid Rowguid { get; set; }
        public System.String Shelf { get; set; }
    }
}
