


using System;
using System.Collections.Generic;
using System.Text;
using FluentNHibernate.Mapping;
using AdventureWorks.EntityClasses;

namespace AdventureWorks.Mappings.Sales
{
    using EntityClasses.Sales;

    /// <summary>Represents the mapping of the 'Sales.SalesTaxRate' entity, represented by the 'SalesTaxRate' class.</summary>
	public partial class SalesTaxRateMap : ClassMap<SalesTaxRate>
    {
		/// <summary>Initializes a new instance of the <see cref="SalesTaxRateMap"/> class.</summary>
		public SalesTaxRateMap()
        {
			Table("[Sales].[SalesTaxRate]");
			OptimisticLock.None();
			LazyLoad();

			Id(x=>x.SalesTaxRateId)
				.Access.CamelCaseField(Prefix.Underscore)
				.Column("[SalesTaxRateID]")
				.GeneratedBy.Identity();
			Map(x=>x.ModifiedDate).Column("[ModifiedDate]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.Name).Length(50).Column("[Name]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.Rowguid).Column("[rowguid]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.TaxRate).Column("[TaxRate]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.TaxType).Column("[TaxType]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);

			References(x=>x.StateProvince)
				.Access.CamelCaseField(Prefix.Underscore)
				.Cascade.All()
				.Fetch.Select()
				.Columns("[StateProvinceID]");

			AdditionalMappingInfo();
		} 
				
		/// <summary>Partial method for adding additional mapping information in a partial class.</summary>
		partial void AdditionalMappingInfo();
	} 
}  
