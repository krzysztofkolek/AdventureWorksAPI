


using System;
using System.Collections.Generic;
using System.Text;
using FluentNHibernate.Mapping;
using AdventureWorks.EntityClasses;

namespace AdventureWorks.Mappings.Production
{
    using EntityClasses.Production;

    /// <summary>Represents the mapping of the 'Production.ProductPhoto' entity, represented by the 'ProductPhoto' class.</summary>
	public partial class ProductPhotoMap : ClassMap<ProductPhoto>
    {
		/// <summary>Initializes a new instance of the <see cref="ProductPhotoMap"/> class.</summary>
		public ProductPhotoMap()
        {
			Table("[Production].[ProductPhoto]");
			OptimisticLock.None();
			LazyLoad();

			Id(x=>x.ProductPhotoId)
				.Access.CamelCaseField(Prefix.Underscore)
				.Column("[ProductPhotoID]")
				.GeneratedBy.Identity();
			Map(x=>x.LargePhoto).CustomType("BinaryBlob").Column("[LargePhoto]").Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.LargePhotoFileName).Length(50).Column("[LargePhotoFileName]").Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.ModifiedDate).Column("[ModifiedDate]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.ThumbNailPhoto).CustomType("BinaryBlob").Column("[ThumbNailPhoto]").Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.ThumbnailPhotoFileName).Length(50).Column("[ThumbnailPhotoFileName]").Access.CamelCaseField(Prefix.Underscore);

			HasMany(x=>x.ProductProductPhotos)
				.Access.CamelCaseField(Prefix.Underscore)
				.Cascade.AllDeleteOrphan()
				.Fetch.Select()
				.AsSet()
				.Inverse()
				.LazyLoad()
				.KeyColumns.Add("[ProductPhotoID]");

			AdditionalMappingInfo();
		} 
				
		/// <summary>Partial method for adding additional mapping information in a partial class.</summary>
		partial void AdditionalMappingInfo();
	} 
}  
