


using System;
using System.Collections.Generic;
using System.Text;
using FluentNHibernate.Mapping;
using AdventureWorks.EntityClasses;

namespace AdventureWorks.Mappings.Purchasing
{
    using EntityClasses.Purchasing;

    /// <summary>Represents the mapping of the 'Purchasing.ProductVendor' entity, represented by the 'ProductVendor' class.</summary>
	public partial class ProductVendorMap : ClassMap<ProductVendor>
    {
		/// <summary>Initializes a new instance of the <see cref="ProductVendorMap"/> class.</summary>
		public ProductVendorMap()
        {
			Table("[Purchasing].[ProductVendor]");
			OptimisticLock.None();
			LazyLoad();

			CompositeId()
				.KeyReference(x => x.Product, x => x.Access.CamelCaseField(Prefix.Underscore), "[ProductID]")
				.KeyReference(x => x.Vendor, x => x.Access.CamelCaseField(Prefix.Underscore), "[VendorID]");
			Map(x=>x.AverageLeadTime).Column("[AverageLeadTime]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.LastReceiptCost).Column("[LastReceiptCost]").Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.LastReceiptDate).Column("[LastReceiptDate]").Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.MaxOrderQty).Column("[MaxOrderQty]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.MinOrderQty).Column("[MinOrderQty]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.ModifiedDate).Column("[ModifiedDate]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.OnOrderQty).Column("[OnOrderQty]").Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.StandardPrice).Column("[StandardPrice]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);

			References(x=>x.UnitMeasure)
				.Access.CamelCaseField(Prefix.Underscore)
				.Cascade.All()
				.Fetch.Select()
				.Columns("[UnitMeasureCode]");

			AdditionalMappingInfo();
		} 
				
		/// <summary>Partial method for adding additional mapping information in a partial class.</summary>
		partial void AdditionalMappingInfo();
	} 
}  
