


using System;
using System.Collections.Generic;
using System.Text;
using FluentNHibernate.Mapping;
using AdventureWorks.EntityClasses;

namespace AdventureWorks.Mappings.Sales
{
    using EntityClasses.Sales;

    /// <summary>Represents the mapping of the 'Sales.SalesTerritory' entity, represented by the 'SalesTerritory' class.</summary>
	public partial class SalesTerritoryMap : ClassMap<SalesTerritory>
    {
		/// <summary>Initializes a new instance of the <see cref="SalesTerritoryMap"/> class.</summary>
		public SalesTerritoryMap()
        {
			Table("[Sales].[SalesTerritory]");
			OptimisticLock.None();
			LazyLoad();

			Id(x=>x.TerritoryId)
				.Access.CamelCaseField(Prefix.Underscore)
				.Column("[TerritoryID]")
				.GeneratedBy.Identity();
			Map(x=>x.CostLastYear).Column("[CostLastYear]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.CostYtd).Column("[CostYTD]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.CountryRegionCode).Length(3).Column("[CountryRegionCode]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.Group).Length(50).Column("[Group]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.ModifiedDate).Column("[ModifiedDate]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.Name).Length(50).Column("[Name]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.Rowguid).Column("[rowguid]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.SalesLastYear).Column("[SalesLastYear]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.SalesYtd).Column("[SalesYTD]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);

			HasMany(x=>x.Customers)
				.Access.CamelCaseField(Prefix.Underscore)
				.Cascade.AllDeleteOrphan()
				.Fetch.Select()
				.AsSet()
				.Inverse()
				.LazyLoad()
				.KeyColumns.Add("[TerritoryID]");
			HasMany(x=>x.SalesOrderHeaders)
				.Access.CamelCaseField(Prefix.Underscore)
				.Cascade.AllDeleteOrphan()
				.Fetch.Select()
				.AsSet()
				.Inverse()
				.LazyLoad()
				.KeyColumns.Add("[TerritoryID]");
			HasMany(x=>x.SalesPeople)
				.Access.CamelCaseField(Prefix.Underscore)
				.Cascade.AllDeleteOrphan()
				.Fetch.Select()
				.AsSet()
				.Inverse()
				.LazyLoad()
				.KeyColumns.Add("[TerritoryID]");
			HasMany(x=>x.SalesTerritoryHistories)
				.Access.CamelCaseField(Prefix.Underscore)
				.Cascade.AllDeleteOrphan()
				.Fetch.Select()
				.AsSet()
				.Inverse()
				.LazyLoad()
				.KeyColumns.Add("[TerritoryID]");
			HasMany(x=>x.StateProvinces)
				.Access.CamelCaseField(Prefix.Underscore)
				.Cascade.AllDeleteOrphan()
				.Fetch.Select()
				.AsSet()
				.Inverse()
				.LazyLoad()
				.KeyColumns.Add("[TerritoryID]");

			AdditionalMappingInfo();
		} 
				
		/// <summary>Partial method for adding additional mapping information in a partial class.</summary>
		partial void AdditionalMappingInfo();
	} 
}  
