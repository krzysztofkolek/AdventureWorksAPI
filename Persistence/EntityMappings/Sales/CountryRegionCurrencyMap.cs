


using System;
using System.Collections.Generic;
using System.Text;
using FluentNHibernate.Mapping;
using AdventureWorks.EntityClasses;

namespace AdventureWorks.Mappings.Sales
{
    using EntityClasses.Sales;

    /// <summary>Represents the mapping of the 'Sales.CountryRegionCurrency' entity, represented by the 'CountryRegionCurrency' class.</summary>
	public partial class CountryRegionCurrencyMap : ClassMap<CountryRegionCurrency>
    {
		/// <summary>Initializes a new instance of the <see cref="CountryRegionCurrencyMap"/> class.</summary>
		public CountryRegionCurrencyMap()
        {
			Table("[Sales].[CountryRegionCurrency]");
			OptimisticLock.None();
			LazyLoad();

			CompositeId()
				.KeyReference(x => x.CountryRegion, x => x.Access.CamelCaseField(Prefix.Underscore), "[CountryRegionCode]")
				.KeyReference(x => x.Currency, x => x.Access.CamelCaseField(Prefix.Underscore), "[CurrencyCode]");
			Map(x=>x.ModifiedDate).Column("[ModifiedDate]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);


			AdditionalMappingInfo();
		} 
				
		/// <summary>Partial method for adding additional mapping information in a partial class.</summary>
		partial void AdditionalMappingInfo();
	} 
}  
