


using System;
using System.Collections.Generic;
using System.Text;
using FluentNHibernate.Mapping;
using AdventureWorks.EntityClasses;

namespace AdventureWorks.Mappings.Production
{
    using EntityClasses.Production;

    /// <summary>Represents the mapping of the 'Production.ProductInventory' entity, represented by the 'ProductInventory' class.</summary>
	public partial class ProductInventoryMap : ClassMap<ProductInventory>
    {
		/// <summary>Initializes a new instance of the <see cref="ProductInventoryMap"/> class.</summary>
		public ProductInventoryMap()
        {
			Table("[Production].[ProductInventory]");
			OptimisticLock.None();
			LazyLoad();

			CompositeId()
				.KeyReference(x => x.Location, x => x.Access.CamelCaseField(Prefix.Underscore), "[LocationID]")
				.KeyReference(x => x.Product, x => x.Access.CamelCaseField(Prefix.Underscore), "[ProductID]");
			Map(x=>x.Bin).Column("[Bin]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.ModifiedDate).Column("[ModifiedDate]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.Quantity).Column("[Quantity]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.Rowguid).Column("[rowguid]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.Shelf).Length(10).Column("[Shelf]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);


			AdditionalMappingInfo();
		} 
				
		/// <summary>Partial method for adding additional mapping information in a partial class.</summary>
		partial void AdditionalMappingInfo();
	} 
}  
