


using System;
using System.Collections.Generic;
using System.Text;
using FluentNHibernate.Mapping;
using AdventureWorks.EntityClasses;

namespace AdventureWorks.Mappings.Person
{
    using EntityClasses.Person;

    /// <summary>Represents the mapping of the 'Person.StateProvince' entity, represented by the 'StateProvince' class.</summary>
	public partial class StateProvinceMap : ClassMap<StateProvince>
    {
		/// <summary>Initializes a new instance of the <see cref="StateProvinceMap"/> class.</summary>
		public StateProvinceMap()
        {
			Table("[Person].[StateProvince]");
			OptimisticLock.None();
			LazyLoad();

			Id(x=>x.StateProvinceId)
				.Access.CamelCaseField(Prefix.Underscore)
				.Column("[StateProvinceID]")
				.GeneratedBy.Identity();
			Map(x=>x.IsOnlyStateProvinceFlag).Column("[IsOnlyStateProvinceFlag]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.ModifiedDate).Column("[ModifiedDate]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.Name).Length(50).Column("[Name]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.Rowguid).Column("[rowguid]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.StateProvinceCode).Length(3).Column("[StateProvinceCode]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);

			HasMany(x=>x.Addresses)
				.Access.CamelCaseField(Prefix.Underscore)
				.Cascade.AllDeleteOrphan()
				.Fetch.Select()
				.AsSet()
				.Inverse()
				.LazyLoad()
				.KeyColumns.Add("[StateProvinceID]");
			References(x=>x.CountryRegion)
				.Access.CamelCaseField(Prefix.Underscore)
				.Cascade.All()
				.Fetch.Select()
				.Columns("[CountryRegionCode]");
			HasMany(x=>x.SalesTaxRates)
				.Access.CamelCaseField(Prefix.Underscore)
				.Cascade.AllDeleteOrphan()
				.Fetch.Select()
				.AsSet()
				.Inverse()
				.LazyLoad()
				.KeyColumns.Add("[StateProvinceID]");
			References(x=>x.SalesTerritory)
				.Access.CamelCaseField(Prefix.Underscore)
				.Cascade.All()
				.Fetch.Select()
				.Columns("[TerritoryID]");

			AdditionalMappingInfo();
		} 
				
		/// <summary>Partial method for adding additional mapping information in a partial class.</summary>
		partial void AdditionalMappingInfo();
	} 
}  
