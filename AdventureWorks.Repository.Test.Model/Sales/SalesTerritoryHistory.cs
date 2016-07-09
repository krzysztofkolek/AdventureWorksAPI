namespace AdventureWorks.Repository.Test.Model.Sales
{
    using System;

    public class SalesTerritoryHistory
    {
        public SalesPerson SalesPerson{ get; set; }
        public SalesTerritory SalesTerritory{ get; set; }
        public Nullable<System.DateTime> EndDate{ get; set; }
        public System.DateTime ModifiedDate{ get; set; }
        public System.Guid Rowguid{ get; set; }
        public System.DateTime StartDate{ get; set; }
    }
}
