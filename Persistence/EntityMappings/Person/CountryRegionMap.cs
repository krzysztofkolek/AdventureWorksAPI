


using System;
using System.Collections.Generic;
using System.Text;
using FluentNHibernate.Mapping;
using AdventureWorks.EntityClasses;

namespace AdventureWorks.Mappings.Person
{
    using EntityClasses.Person;

    /// <summary>Represents the mapping of the 'Person.CountryRegion' entity, represented by the 'CountryRegion' class.</summary>
	public partial class CountryRegionMap : ClassMap<CountryRegion>
    {
		/// <summary>Initializes a new instance of the <see cref="CountryRegionMap"/> class.</summary>
		public CountryRegionMap()
        {
			Table("[Person].[CountryRegion]");
			OptimisticLock.None();
			LazyLoad();

			Id(x=>x.CountryRegionCode)
				.Access.CamelCaseField(Prefix.Underscore)
				.Column("[CountryRegionCode]")
				.GeneratedBy.Assigned();
			Map(x=>x.ModifiedDate).Column("[ModifiedDate]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.Name).Length(50).Column("[Name]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);

			HasMany(x=>x.CountryRegionCurrencies)
				.Access.CamelCaseField(Prefix.Underscore)
				.Cascade.AllDeleteOrphan()
				.Fetch.Select()
				.AsSet()
				.Inverse()
				.LazyLoad()
				.KeyColumns.Add("[CountryRegionCode]");
			HasMany(x=>x.StateProvinces)
				.Access.CamelCaseField(Prefix.Underscore)
				.Cascade.AllDeleteOrphan()
				.Fetch.Select()
				.AsSet()
				.Inverse()
				.LazyLoad()
				.KeyColumns.Add("[CountryRegionCode]");

			AdditionalMappingInfo();
		} 
				
		/// <summary>Partial method for adding additional mapping information in a partial class.</summary>
		partial void AdditionalMappingInfo();
	} 
}  
