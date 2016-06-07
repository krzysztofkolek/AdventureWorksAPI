


using System;
using System.Collections.Generic;
using System.Text;
using FluentNHibernate.Mapping;
using AdventureWorks.EntityClasses;

namespace AdventureWorks.Mappings.Production
{
    using EntityClasses.Production;

    /// <summary>Represents the mapping of the 'Production.ProductReview' entity, represented by the 'ProductReview' class.</summary>
	public partial class ProductReviewMap : ClassMap<ProductReview>
    {
		/// <summary>Initializes a new instance of the <see cref="ProductReviewMap"/> class.</summary>
		public ProductReviewMap()
        {
			Table("[Production].[ProductReview]");
			OptimisticLock.None();
			LazyLoad();

			Id(x=>x.ProductReviewId)
				.Access.CamelCaseField(Prefix.Underscore)
				.Column("[ProductReviewID]")
				.GeneratedBy.Identity();
			Map(x=>x.Comments).Length(3850).Column("[Comments]").Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.EmailAddress).Length(50).Column("[EmailAddress]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.ModifiedDate).Column("[ModifiedDate]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.Rating).Column("[Rating]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.ReviewDate).Column("[ReviewDate]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.ReviewerName).Length(50).Column("[ReviewerName]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);

			References(x=>x.Product)
				.Access.CamelCaseField(Prefix.Underscore)
				.Cascade.All()
				.Fetch.Select()
				.Columns("[ProductID]");

			AdditionalMappingInfo();
		} 
				
		/// <summary>Partial method for adding additional mapping information in a partial class.</summary>
		partial void AdditionalMappingInfo();
	} 
}  
