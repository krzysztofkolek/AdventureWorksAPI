


using System;
using System.Collections.Generic;
using System.Text;
using FluentNHibernate.Mapping;
using AdventureWorks.EntityClasses;

namespace AdventureWorks.Mappings.Purchasing
{
    using EntityClasses.Purchasing;

    /// <summary>Represents the mapping of the 'Purchasing.PurchaseOrderDetail' entity, represented by the 'PurchaseOrderDetail' class.</summary>
	public partial class PurchaseOrderDetailMap : ClassMap<PurchaseOrderDetail>
    {
		/// <summary>Initializes a new instance of the <see cref="PurchaseOrderDetailMap"/> class.</summary>
		public PurchaseOrderDetailMap()
        {
			Table("[Purchasing].[PurchaseOrderDetail]");
			OptimisticLock.None();
			LazyLoad();

			Id(x=>x.PurchaseOrderDetailId)
				.Access.CamelCaseField(Prefix.Underscore)
				.Column("[PurchaseOrderDetailID]")
				.GeneratedBy.Identity();
			Map(x=>x.DueDate).Column("[DueDate]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.LineTotal).ReadOnly().Column("[LineTotal]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.ModifiedDate).Column("[ModifiedDate]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.OrderQty).Column("[OrderQty]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.ReceivedQty).Column("[ReceivedQty]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.RejectedQty).Column("[RejectedQty]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.StockedQty).ReadOnly().Column("[StockedQty]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.UnitPrice).Column("[UnitPrice]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);

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
