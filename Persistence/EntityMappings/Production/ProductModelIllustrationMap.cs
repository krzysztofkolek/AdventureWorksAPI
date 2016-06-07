


using System;
using System.Collections.Generic;
using System.Text;
using FluentNHibernate.Mapping;
using AdventureWorks.EntityClasses;

namespace AdventureWorks.Mappings.Production
{
    using EntityClasses.Production;

    /// <summary>Represents the mapping of the 'Production.ProductModelIllustration' entity, represented by the 'ProductModelIllustration' class.</summary>
	public partial class ProductModelIllustrationMap : ClassMap<ProductModelIllustration>
    {
		/// <summary>Initializes a new instance of the <see cref="ProductModelIllustrationMap"/> class.</summary>
		public ProductModelIllustrationMap()
        {
			Table("[Production].[ProductModelIllustration]");
			OptimisticLock.None();
			LazyLoad();

			CompositeId()
				.KeyReference(x => x.Illustration, x => x.Access.CamelCaseField(Prefix.Underscore), "[IllustrationID]")
				.KeyReference(x => x.ProductModel, x => x.Access.CamelCaseField(Prefix.Underscore), "[ProductModelID]");
			Map(x=>x.ModifiedDate).Column("[ModifiedDate]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);


			AdditionalMappingInfo();
		} 
				
		/// <summary>Partial method for adding additional mapping information in a partial class.</summary>
		partial void AdditionalMappingInfo();
	} 
}  
