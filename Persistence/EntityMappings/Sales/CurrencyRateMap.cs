


using System;
using System.Collections.Generic;
using System.Text;
using FluentNHibernate.Mapping;
using AdventureWorks.EntityClasses;

namespace AdventureWorks.Mappings.Sales
{
    using EntityClasses.Sales;

    /// <summary>Represents the mapping of the 'Sales.CurrencyRate' entity, represented by the 'CurrencyRate' class.</summary>
	public partial class CurrencyRateMap : ClassMap<CurrencyRate>
    {
		/// <summary>Initializes a new instance of the <see cref="CurrencyRateMap"/> class.</summary>
		public CurrencyRateMap()
        {
			Table("[Sales].[CurrencyRate]");
			OptimisticLock.None();
			LazyLoad();

			Id(x=>x.CurrencyRateId)
				.Access.CamelCaseField(Prefix.Underscore)
				.Column("[CurrencyRateID]")
				.GeneratedBy.Identity();
			Map(x=>x.AverageRate).Column("[AverageRate]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.CurrencyRateDate).Column("[CurrencyRateDate]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.EndOfDayRate).Column("[EndOfDayRate]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.ModifiedDate).Column("[ModifiedDate]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);

			References(x=>x.Currency)
				.Access.CamelCaseField(Prefix.Underscore)
				.Cascade.All()
				.Fetch.Select()
				.Columns("[FromCurrencyCode]");
			References(x=>x.Currency1)
				.Access.CamelCaseField(Prefix.Underscore)
				.Cascade.All()
				.Fetch.Select()
				.Columns("[ToCurrencyCode]");
			HasMany(x=>x.SalesOrderHeaders)
				.Access.CamelCaseField(Prefix.Underscore)
				.Cascade.AllDeleteOrphan()
				.Fetch.Select()
				.AsSet()
				.Inverse()
				.LazyLoad()
				.KeyColumns.Add("[CurrencyRateID]");

			AdditionalMappingInfo();
		} 
				
		/// <summary>Partial method for adding additional mapping information in a partial class.</summary>
		partial void AdditionalMappingInfo();
	} 
}  
