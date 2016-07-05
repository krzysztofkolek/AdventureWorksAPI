


using System;
using System.Collections.Generic;
using System.Text;
using FluentNHibernate.Mapping;
using AdventureWorks.EntityClasses;

namespace AdventureWorks.Mappings.Production
{
    using EntityClasses.Production;

    /// <summary>Represents the mapping of the 'Production.ProductDocument' entity, represented by the 'ProductDocument' class.</summary>
	public partial class ProductDocumentMap : ClassMap<ProductDocument>
    {
		/// <summary>Initializes a new instance of the <see cref="ProductDocumentMap"/> class.</summary>
		public ProductDocumentMap()
        {
			Table("[Production].[ProductDocument]");
			OptimisticLock.None();
			LazyLoad();

			CompositeId()
				.KeyReference(x => x.Document, x => x.Access.CamelCaseField(Prefix.Underscore), "[DocumentID]")
				.KeyReference(x => x.Product, x => x.Access.CamelCaseField(Prefix.Underscore), "[ProductID]");
			Map(x=>x.ModifiedDate).Column("[ModifiedDate]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);


			AdditionalMappingInfo();
		} 
				
		/// <summary>Partial method for adding additional mapping information in a partial class.</summary>
		partial void AdditionalMappingInfo();
	} 
}  
