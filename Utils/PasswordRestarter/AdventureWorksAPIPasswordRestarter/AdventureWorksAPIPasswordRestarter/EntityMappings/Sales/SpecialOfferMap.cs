


using System;
using System.Collections.Generic;
using System.Text;
using FluentNHibernate.Mapping;
using AdventureWorks.EntityClasses;

namespace AdventureWorks.Mappings.Sales
{
    using EntityClasses.Sales;

    /// <summary>Represents the mapping of the 'Sales.SpecialOffer' entity, represented by the 'SpecialOffer' class.</summary>
	public partial class SpecialOfferMap : ClassMap<SpecialOffer>
    {
		/// <summary>Initializes a new instance of the <see cref="SpecialOfferMap"/> class.</summary>
		public SpecialOfferMap()
        {
			Table("[Sales].[SpecialOffer]");
			OptimisticLock.None();
			LazyLoad();

			Id(x=>x.SpecialOfferId)
				.Access.CamelCaseField(Prefix.Underscore)
				.Column("[SpecialOfferID]")
				.GeneratedBy.Identity();
			Map(x=>x.Category).Length(50).Column("[Category]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.Description).Length(255).Column("[Description]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.DiscountPct).Column("[DiscountPct]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.EndDate).Column("[EndDate]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.MaxQty).Column("[MaxQty]").Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.MinQty).Column("[MinQty]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.ModifiedDate).Column("[ModifiedDate]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.Rowguid).Column("[rowguid]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.StartDate).Column("[StartDate]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.Type).Length(50).Column("[Type]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);

			HasMany(x=>x.SpecialOfferProducts)
				.Access.CamelCaseField(Prefix.Underscore)
				.Cascade.AllDeleteOrphan()
				.Fetch.Select()
				.AsSet()
				.Inverse()
				.LazyLoad()
				.KeyColumns.Add("[SpecialOfferID]");

			AdditionalMappingInfo();
		} 
				
		/// <summary>Partial method for adding additional mapping information in a partial class.</summary>
		partial void AdditionalMappingInfo();
	} 
}  
