


using System;
using System.Collections.Generic;
using System.Text;
using FluentNHibernate.Mapping;
using AdventureWorks.EntityClasses;

namespace AdventureWorks.Mappings.Sales
{
    using EntityClasses.Sales;

    /// <summary>Represents the mapping of the 'Sales.SalesPerson' entity, represented by the 'SalesPerson' class.</summary>
	public partial class SalesPersonMap : ClassMap<SalesPerson>
    {
		/// <summary>Initializes a new instance of the <see cref="SalesPersonMap"/> class.</summary>
		public SalesPersonMap()
        {
			Table("[Sales].[SalesPerson]");
			OptimisticLock.None();
			LazyLoad();

			Id(x=>x.SalesPersonId)
				.Access.CamelCaseField(Prefix.Underscore)
				.Column("[SalesPersonID]")
				.GeneratedBy.Foreign("Employee");
			Map(x=>x.Bonus).Column("[Bonus]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.CommissionPct).Column("[CommissionPct]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.ModifiedDate).Column("[ModifiedDate]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.Rowguid).Column("[rowguid]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.SalesLastYear).Column("[SalesLastYear]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.SalesQuota).Column("[SalesQuota]").Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.SalesYtd).Column("[SalesYTD]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);

			HasOne(x=>x.Employee)
				.Access.CamelCaseField(Prefix.Underscore)
				.Cascade.All()
				.Fetch.Select()
				.Constrained();
			HasMany(x=>x.SalesOrderHeaders)
				.Access.CamelCaseField(Prefix.Underscore)
				.Cascade.AllDeleteOrphan()
				.Fetch.Select()
				.AsSet()
				.Inverse()
				.LazyLoad()
				.KeyColumns.Add("[SalesPersonID]");
			HasMany(x=>x.SalesPersonQuotaHistories)
				.Access.CamelCaseField(Prefix.Underscore)
				.Cascade.AllDeleteOrphan()
				.Fetch.Select()
				.AsSet()
				.Inverse()
				.LazyLoad()
				.KeyColumns.Add("[SalesPersonID]");
			References(x=>x.SalesTerritory)
				.Access.CamelCaseField(Prefix.Underscore)
				.Cascade.All()
				.Fetch.Select()
				.Columns("[TerritoryID]");
			HasMany(x=>x.SalesTerritoryHistories)
				.Access.CamelCaseField(Prefix.Underscore)
				.Cascade.AllDeleteOrphan()
				.Fetch.Select()
				.AsSet()
				.Inverse()
				.LazyLoad()
				.KeyColumns.Add("[SalesPersonID]");
			HasMany(x=>x.Stores)
				.Access.CamelCaseField(Prefix.Underscore)
				.Cascade.AllDeleteOrphan()
				.Fetch.Select()
				.AsSet()
				.Inverse()
				.LazyLoad()
				.KeyColumns.Add("[SalesPersonID]");

			AdditionalMappingInfo();
		} 
				
		/// <summary>Partial method for adding additional mapping information in a partial class.</summary>
		partial void AdditionalMappingInfo();
	} 
}  
