


using System;
using System.Collections.Generic;
using System.Text;
using FluentNHibernate.Mapping;
using AdventureWorks.EntityClasses;

namespace AdventureWorks.Mappings.Production
{
    using EntityClasses.Production;

    /// <summary>Represents the mapping of the 'Production.ProductModel' entity, represented by the 'ProductModel' class.</summary>
	public partial class ProductModelMap : ClassMap<ProductModel>
    {
		/// <summary>Initializes a new instance of the <see cref="ProductModelMap"/> class.</summary>
		public ProductModelMap()
        {
			Table("[Production].[ProductModel]");
			OptimisticLock.None();
			LazyLoad();

			Id(x=>x.ProductModelId)
				.Access.CamelCaseField(Prefix.Underscore)
				.Column("[ProductModelID]")
				.GeneratedBy.Identity();
			Map(x=>x.CatalogDescription).CustomType("StringClob").Column("[CatalogDescription]").Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.Instructions).CustomType("StringClob").Column("[Instructions]").Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.ModifiedDate).Column("[ModifiedDate]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.Name).Length(50).Column("[Name]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.Rowguid).Column("[rowguid]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);

			HasMany(x=>x.ProductModelIllustrations)
				.Access.CamelCaseField(Prefix.Underscore)
				.Cascade.AllDeleteOrphan()
				.Fetch.Select()
				.AsSet()
				.Inverse()
				.LazyLoad()
				.KeyColumns.Add("[ProductModelID]");
			HasMany(x=>x.ProductModelProductDescriptionCultures)
				.Access.CamelCaseField(Prefix.Underscore)
				.Cascade.AllDeleteOrphan()
				.Fetch.Select()
				.AsSet()
				.Inverse()
				.LazyLoad()
				.KeyColumns.Add("[ProductModelID]");
			HasMany(x=>x.Products)
				.Access.CamelCaseField(Prefix.Underscore)
				.Cascade.AllDeleteOrphan()
				.Fetch.Select()
				.AsSet()
				.Inverse()
				.LazyLoad()
				.KeyColumns.Add("[ProductModelID]");

			AdditionalMappingInfo();
		} 
				
		/// <summary>Partial method for adding additional mapping information in a partial class.</summary>
		partial void AdditionalMappingInfo();
	} 
}  
