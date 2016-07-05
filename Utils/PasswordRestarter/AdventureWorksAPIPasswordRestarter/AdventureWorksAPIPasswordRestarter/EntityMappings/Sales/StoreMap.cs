namespace AdventureWorks.Mappings.Sales
{
    using EntityClasses;
    using EntityClasses.Sales;
    using FluentNHibernate.Mapping;

    /// <summary>Represents the mapping of the 'Sales.Store' entity, represented by the 'Store' class.</summary>
    public class StoreMap : ClassMap<Store>
    {
        /// <summary>Initializes a new instance of the <see cref="StoreMap" /> class.</summary>
        public StoreMap()
        {
            Table("[Sales].[Store]");
            OptimisticLock.None();
            LazyLoad();

            Id(x => x.CustomerId)
                .Access.CamelCaseField(Prefix.Underscore)
                .Column("[CustomerID]")
                .GeneratedBy.Foreign("Customer");
            Map(x => x.Demographics)
                .CustomType("StringClob")
                .Column("[Demographics]")
                .Access.CamelCaseField(Prefix.Underscore);
            Map(x => x.ModifiedDate).Column("[ModifiedDate]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);
            Map(x => x.Name).Length(50).Column("[Name]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);
            Map(x => x.Rowguid).Column("[rowguid]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);

            HasOne(x => x.Customer)
                .Access.CamelCaseField(Prefix.Underscore)
                .Cascade.All()
                .Fetch.Select()
                .Constrained();
            References(x => x.SalesPerson)
                .Access.CamelCaseField(Prefix.Underscore)
                .Cascade.All()
                .Fetch.Select()
                .Columns("[SalesPersonID]");
            HasMany(x => x.StoreContacts)
                .Access.CamelCaseField(Prefix.Underscore)
                .Cascade.AllDeleteOrphan()
                .Fetch.Select()
                .AsSet()
                .Inverse()
                .LazyLoad()
                .KeyColumns.Add("[CustomerID]");

            AdditionalMappingInfo();
        }

        /// <summary>Partial method for adding additional mapping information in a partial class.</summary>
        private void AdditionalMappingInfo()
        {
        }
    }
}