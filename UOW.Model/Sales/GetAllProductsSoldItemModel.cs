namespace AdventureWorks.UOW.Model.Sales
{
    using System;

    public class GetAllProductsSoldItemModel
    {
        public Byte[] ThumbNailPhoto { get; set; }
        public String Name { get; set; }
        public String Size { get; set; }
        public Decimal StandardCost { get; set; }
    }
}