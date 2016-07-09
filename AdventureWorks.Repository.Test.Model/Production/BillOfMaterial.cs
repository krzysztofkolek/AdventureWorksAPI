namespace AdventureWorks.Repository.Test.Model.Production
{
    using System;

    public class BillOfMaterial
    {
        public Product Product { get; set; }
        public Product Product1 { get; set; }
        public UnitMeasure UnitMeasure { get; set; }
        public System.Int32 BillOfMaterialsId { get; set; }
        public System.Int16 Bomlevel { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public System.Decimal PerAssemblyQty { get; set; }
        public System.DateTime StartDate { get; set; }
    }
}
