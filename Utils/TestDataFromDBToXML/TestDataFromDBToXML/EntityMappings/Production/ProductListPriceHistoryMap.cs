


using System;
using System.Collections.Generic;
using System.Text;
using FluentNHibernate.Mapping;
using AdventureWorks.EntityClasses;

namespace AdventureWorks.Mappings.Production
{
    using EntityClasses.Production;

    /// <summary>Represents the mapping of the 'Production.ProductListPriceHistory' entity, represented by the 'ProductListPriceHistory' class.</summary>
	public partial class ProductListPriceHistoryMap : ClassMap<ProductListPriceHistory>
    {
		/// <summary>Initializes a new instance of the <see cref="ProductListPriceHistoryMap"/> class.</summary>
		public ProductListPriceHistoryMap()
        {
			Table("[Production].[ProductListPriceHistory]");
			OptimisticLock.None();
			LazyLoad();

			CompositeId()
				.KeyReference(x => x.Product, x => x.Access.CamelCaseField(Prefix.Underscore), "[ProductID]")
				.KeyProperty(x => x.StartDate, x => x.Access.CamelCaseField(Prefix.Underscore).ColumnName("[StartDate]"));
			Map(x=>x.EndDate).Column("[EndDate]").Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.ListPrice).Column("[ListPrice]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.ModifiedDate).Column("[ModifiedDate]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);


			AdditionalMappingInfo();
		} 
				
		/// <summary>Partial method for adding additional mapping information in a partial class.</summary>
		partial void AdditionalMappingInfo();
	} 
}  
