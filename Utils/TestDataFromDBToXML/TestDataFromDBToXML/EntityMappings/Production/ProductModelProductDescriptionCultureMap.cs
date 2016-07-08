


using System;
using System.Collections.Generic;
using System.Text;
using FluentNHibernate.Mapping;
using AdventureWorks.EntityClasses;

namespace AdventureWorks.Mappings.Production
{
    using EntityClasses.Production;

    /// <summary>Represents the mapping of the 'Production.ProductModelProductDescriptionCulture' entity, represented by the 'ProductModelProductDescriptionCulture' class.</summary>
	public partial class ProductModelProductDescriptionCultureMap : ClassMap<ProductModelProductDescriptionCulture>
    {
		/// <summary>Initializes a new instance of the <see cref="ProductModelProductDescriptionCultureMap"/> class.</summary>
		public ProductModelProductDescriptionCultureMap()
        {
			Table("[Production].[ProductModelProductDescriptionCulture]");
			OptimisticLock.None();
			LazyLoad();

			CompositeId()
				.KeyReference(x => x.Culture, x => x.Access.CamelCaseField(Prefix.Underscore), "[CultureID]")
				.KeyReference(x => x.ProductDescription, x => x.Access.CamelCaseField(Prefix.Underscore), "[ProductDescriptionID]")
				.KeyReference(x => x.ProductModel, x => x.Access.CamelCaseField(Prefix.Underscore), "[ProductModelID]");
			Map(x=>x.ModifiedDate).Column("[ModifiedDate]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);


			AdditionalMappingInfo();
		} 
				
		/// <summary>Partial method for adding additional mapping information in a partial class.</summary>
		partial void AdditionalMappingInfo();
	} 
}  
