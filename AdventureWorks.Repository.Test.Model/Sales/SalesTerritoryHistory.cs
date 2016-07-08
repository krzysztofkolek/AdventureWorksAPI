namespace AdventureWorks.Repository.Test.Model.Sales
{
    using System;

    public class SalesTerritoryHistory
    {
        public SalesPerson _salesPerson{ get; set; }
        public SalesTerritory _salesTerritory{ get; set; }
        public Nullable<System.DateTime> _endDate{ get; set; }
        public System.DateTime _modifiedDate{ get; set; }
        public System.Guid _rowguid{ get; set; }
        public System.DateTime _startDate{ get; set; }
    }
}
