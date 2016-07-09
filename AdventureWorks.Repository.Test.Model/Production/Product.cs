namespace AdventureWorks.Repository.Test.Model.Production
{
    using System;

    public class Product
    {
        public ProductModel ProductModel { get; set; }
        public ProductSubcategory ProductSubcategory { get; set; }
        public UnitMeasure UnitMeasure { get; set; }
        public UnitMeasure UnitMeasure1 { get; set; }
        public System.String Class { get; set; }
        public System.String Color { get; set; }
        public System.Int32 DaysToManufacture { get; set; }
        public Nullable<System.DateTime> DiscontinuedDate { get; set; }
        public System.Boolean FinishedGoodsFlag { get; set; }
        public System.Decimal ListPrice { get; set; }
        public System.Boolean MakeFlag { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public System.String Name { get; set; }
        public System.Int32 ProductId { get; set; }
        public System.String ProductLine { get; set; }
        public System.String ProductNumber { get; set; }
        public System.Int16 ReorderPoint { get; set; }
        public System.Guid Rowguid { get; set; }
        public System.Int16 SafetyStockLevel { get; set; }
        public Nullable<System.DateTime> SellEndDate { get; set; }
        public System.DateTime SellStartDate { get; set; }
        public System.String Size { get; set; }
        public System.Decimal StandardCost { get; set; }
        public System.String Style { get; set; }
        public Nullable<System.Decimal> Weight { get; set; }
    }
}
