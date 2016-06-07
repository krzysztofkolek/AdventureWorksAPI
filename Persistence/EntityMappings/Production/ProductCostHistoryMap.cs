


using System;
using System.Collections.Generic;
using System.Text;
using FluentNHibernate.Mapping;
using AdventureWorks.EntityClasses;

namespace AdventureWorks.Mappings.Production
{
    using EntityClasses.Production;

    /// <summary>Represents the mapping of the 'Production.ProductCostHistory' entity, represented by the 'ProductCostHistory' class.</summary>
	public partial class ProductCostHistoryMap : ClassMap<ProductCostHistory>
    {
		/// <summary>Initializes a new instance of the <see cref="ProductCostHistoryMap"/> class.</summary>
		public ProductCostHistoryMap()
        {
			Table("[Production].[ProductCostHistory]");
			OptimisticLock.None();
			LazyLoad();

			CompositeId()
				.KeyReference(x => x.Product, x => x.Access.CamelCaseField(Prefix.Underscore), "[ProductID]")
				.KeyProperty(x => x.StartDate, x => x.Access.CamelCaseField(Prefix.Underscore).ColumnName("[StartDate]"));
			Map(x=>x.EndDate).Column("[EndDate]").Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.ModifiedDate).Column("[ModifiedDate]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.StandardCost).Column("[StandardCost]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);


			AdditionalMappingInfo();
		} 
				
		/// <summary>Partial method for adding additional mapping information in a partial class.</summary>
		partial void AdditionalMappingInfo();
	} 
}  
