


using System;
using System.Collections.Generic;
using System.Text;
using FluentNHibernate.Mapping;
using AdventureWorks.EntityClasses;

namespace AdventureWorks.Mappings.Sales
{
    using EntityClasses.Sales;

    /// <summary>Represents the mapping of the 'Sales.SpecialOfferProduct' entity, represented by the 'SpecialOfferProduct' class.</summary>
	public partial class SpecialOfferProductMap : ClassMap<SpecialOfferProduct>
    {
		/// <summary>Initializes a new instance of the <see cref="SpecialOfferProductMap"/> class.</summary>
		public SpecialOfferProductMap()
        {
			Table("[Sales].[SpecialOfferProduct]");
			OptimisticLock.None();
			LazyLoad();

			CompositeId()
				.KeyReference(x => x.Product, x => x.Access.CamelCaseField(Prefix.Underscore), "[ProductID]")
				.KeyReference(x => x.SpecialOffer, x => x.Access.CamelCaseField(Prefix.Underscore), "[SpecialOfferID]");
			Map(x=>x.ModifiedDate).Column("[ModifiedDate]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.Rowguid).Column("[rowguid]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);

			HasMany(x=>x.SalesOrderDetails)
				.Access.CamelCaseField(Prefix.Underscore)
				.Cascade.AllDeleteOrphan()
				.Fetch.Select()
				.AsSet()
				.Inverse()
				.LazyLoad()
				.KeyColumns.Add("[ProductID]", "[SpecialOfferID]");

			AdditionalMappingInfo();
		} 
				
		/// <summary>Partial method for adding additional mapping information in a partial class.</summary>
		partial void AdditionalMappingInfo();
	} 
}  
