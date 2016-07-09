namespace AdventureWorks.Repository.Test.Model.Person
{
    using Sales;

    public class StateProvince
    {
        public CountryRegion CountryRegion { get; set; }
        public SalesTerritory SalesTerritory { get; set; }
        public System.Boolean IsOnlyStateProvinceFlag { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public System.String Name { get; set; }
        public System.Guid Rowguid { get; set; }
        public System.String StateProvinceCode { get; set; }
        public System.Int32 StateProvinceId { get; set; }
    }
}
