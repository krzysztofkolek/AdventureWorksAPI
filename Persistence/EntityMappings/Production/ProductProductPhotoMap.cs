


using System;
using System.Collections.Generic;
using System.Text;
using FluentNHibernate.Mapping;
using AdventureWorks.EntityClasses;

namespace AdventureWorks.Mappings.Production
{
    using EntityClasses.Production;

    /// <summary>Represents the mapping of the 'Production.ProductProductPhoto' entity, represented by the 'ProductProductPhoto' class.</summary>
	public partial class ProductProductPhotoMap : ClassMap<ProductProductPhoto>
    {
		/// <summary>Initializes a new instance of the <see cref="ProductProductPhotoMap"/> class.</summary>
		public ProductProductPhotoMap()
        {
			Table("[Production].[ProductProductPhoto]");
			OptimisticLock.None();
			LazyLoad();

			CompositeId()
				.KeyReference(x => x.Product, x => x.Access.CamelCaseField(Prefix.Underscore), "[ProductID]")
				.KeyReference(x => x.ProductPhoto, x => x.Access.CamelCaseField(Prefix.Underscore), "[ProductPhotoID]");
			Map(x=>x.ModifiedDate).Column("[ModifiedDate]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.Primary).Column("[Primary]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);


			AdditionalMappingInfo();
		} 
				
		/// <summary>Partial method for adding additional mapping information in a partial class.</summary>
		partial void AdditionalMappingInfo();
	} 
}  
