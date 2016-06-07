


using System;
using System.Collections.Generic;
using System.Text;
using FluentNHibernate.Mapping;
using AdventureWorks.EntityClasses;

namespace AdventureWorks.Mappings.Sales
{
    using EntityClasses.Sales;

    /// <summary>Represents the mapping of the 'Sales.ShoppingCartItem' entity, represented by the 'ShoppingCartItem' class.</summary>
	public partial class ShoppingCartItemMap : ClassMap<ShoppingCartItem>
    {
		/// <summary>Initializes a new instance of the <see cref="ShoppingCartItemMap"/> class.</summary>
		public ShoppingCartItemMap()
        {
			Table("[Sales].[ShoppingCartItem]");
			OptimisticLock.None();
			LazyLoad();

			Id(x=>x.ShoppingCartItemId)
				.Access.CamelCaseField(Prefix.Underscore)
				.Column("[ShoppingCartItemID]")
				.GeneratedBy.Identity();
			Map(x=>x.DateCreated).Column("[DateCreated]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.ModifiedDate).Column("[ModifiedDate]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.Quantity).Column("[Quantity]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.ShoppingCartId).Length(50).Column("[ShoppingCartID]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);

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
