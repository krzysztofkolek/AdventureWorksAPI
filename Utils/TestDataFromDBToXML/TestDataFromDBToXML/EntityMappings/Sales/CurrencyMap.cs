


using System;
using System.Collections.Generic;
using System.Text;
using FluentNHibernate.Mapping;
using AdventureWorks.EntityClasses;

namespace AdventureWorks.Mappings.Sales
{
    using EntityClasses.Sales;

    /// <summary>Represents the mapping of the 'Sales.Currency' entity, represented by the 'Currency' class.</summary>
	public partial class CurrencyMap : ClassMap<Currency>
    {
		/// <summary>Initializes a new instance of the <see cref="CurrencyMap"/> class.</summary>
		public CurrencyMap()
        {
			Table("[Sales].[Currency]");
			OptimisticLock.None();
			LazyLoad();

			Id(x=>x.CurrencyCode)
				.Access.CamelCaseField(Prefix.Underscore)
				.Column("[CurrencyCode]")
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
				.KeyColumns.Add("[CurrencyCode]");
			HasMany(x=>x.CurrencyRates)
				.Access.CamelCaseField(Prefix.Underscore)
				.Cascade.AllDeleteOrphan()
				.Fetch.Select()
				.AsSet()
				.Inverse()
				.LazyLoad()
				.KeyColumns.Add("[FromCurrencyCode]");
			HasMany(x=>x.CurrencyRates1)
				.Access.CamelCaseField(Prefix.Underscore)
				.Cascade.AllDeleteOrphan()
				.Fetch.Select()
				.AsSet()
				.Inverse()
				.LazyLoad()
				.KeyColumns.Add("[ToCurrencyCode]");

			AdditionalMappingInfo();
		} 
				
		/// <summary>Partial method for adding additional mapping information in a partial class.</summary>
		partial void AdditionalMappingInfo();
	} 
}  
