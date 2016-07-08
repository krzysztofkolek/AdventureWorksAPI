


using System;
using System.Collections.Generic;
using System.Text;
using FluentNHibernate.Mapping;
using AdventureWorks.EntityClasses;

namespace AdventureWorks.Mappings.Production
{
    using EntityClasses.Production;

    /// <summary>Represents the mapping of the 'Production.ProductDescription' entity, represented by the 'ProductDescription' class.</summary>
	public partial class ProductDescriptionMap : ClassMap<ProductDescription>
    {
		/// <summary>Initializes a new instance of the <see cref="ProductDescriptionMap"/> class.</summary>
		public ProductDescriptionMap()
        {
			Table("[Production].[ProductDescription]");
			OptimisticLock.None();
			LazyLoad();

			Id(x=>x.ProductDescriptionId)
				.Access.CamelCaseField(Prefix.Underscore)
				.Column("[ProductDescriptionID]")
				.GeneratedBy.Identity();
			Map(x=>x.Description).Length(400).Column("[Description]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.ModifiedDate).Column("[ModifiedDate]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.Rowguid).Column("[rowguid]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);

			HasMany(x=>x.ProductModelProductDescriptionCultures)
				.Access.CamelCaseField(Prefix.Underscore)
				.Cascade.AllDeleteOrphan()
				.Fetch.Select()
				.AsSet()
				.Inverse()
				.LazyLoad()
				.KeyColumns.Add("[ProductDescriptionID]");

			AdditionalMappingInfo();
		} 
				
		/// <summary>Partial method for adding additional mapping information in a partial class.</summary>
		partial void AdditionalMappingInfo();
	} 
}  
