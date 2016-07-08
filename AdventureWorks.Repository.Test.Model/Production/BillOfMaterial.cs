namespace AdventureWorks.Repository.Test.Model.Production
{
    using Person;
    using Production;
    using System;

    public class BillOfMaterial
    {
        public Product _product{ get; set; }
        public Product _product1{ get; set; }
        public UnitMeasure _unitMeasure{ get; set; }
        public System.Int32 _billOfMaterialsId{ get; set; }
        public System.Int16 _bomlevel{ get; set; }
        public Nullable<System.DateTime> _endDate{ get; set; }
        public System.DateTime _modifiedDate{ get; set; }
        public System.Decimal _perAssemblyQty{ get; set; }
        public System.DateTime _startDate{ get; set; }
    }
}
