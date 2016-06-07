


using System;
using System.Collections.Generic;
using System.Text;
using FluentNHibernate.Mapping;
using AdventureWorks.EntityClasses;

namespace AdventureWorks.Mappings.Production
{
    using EntityClasses.Production;

    /// <summary>Represents the mapping of the 'Production.ProductSubcategory' entity, represented by the 'ProductSubcategory' class.</summary>
	public partial class ProductSubcategoryMap : ClassMap<ProductSubcategory>
    {
		/// <summary>Initializes a new instance of the <see cref="ProductSubcategoryMap"/> class.</summary>
		public ProductSubcategoryMap()
        {
			Table("[Production].[ProductSubcategory]");
			OptimisticLock.None();
			LazyLoad();

			Id(x=>x.ProductSubcategoryId)
				.Access.CamelCaseField(Prefix.Underscore)
				.Column("[ProductSubcategoryID]")
				.GeneratedBy.Identity();
			Map(x=>x.ModifiedDate).Column("[ModifiedDate]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.Name).Length(50).Column("[Name]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.Rowguid).Column("[rowguid]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);

			References(x=>x.ProductCategory)
				.Access.CamelCaseField(Prefix.Underscore)
				.Cascade.All()
				.Fetch.Select()
				.Columns("[ProductCategoryID]");
			HasMany(x=>x.Products)
				.Access.CamelCaseField(Prefix.Underscore)
				.Cascade.AllDeleteOrphan()
				.Fetch.Select()
				.AsSet()
				.Inverse()
				.LazyLoad()
				.KeyColumns.Add("[ProductSubcategoryID]");

			AdditionalMappingInfo();
		} 
				
		/// <summary>Partial method for adding additional mapping information in a partial class.</summary>
		partial void AdditionalMappingInfo();
	} 
}  
