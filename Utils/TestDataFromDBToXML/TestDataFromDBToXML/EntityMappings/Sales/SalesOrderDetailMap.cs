


using System;
using System.Collections.Generic;
using System.Text;
using FluentNHibernate.Mapping;
using AdventureWorks.EntityClasses;

namespace AdventureWorks.Mappings.Sales
{
    using EntityClasses.Sales;

    /// <summary>Represents the mapping of the 'Sales.SalesOrderDetail' entity, represented by the 'SalesOrderDetail' class.</summary>
	public partial class SalesOrderDetailMap : ClassMap<SalesOrderDetail>
    {
		/// <summary>Initializes a new instance of the <see cref="SalesOrderDetailMap"/> class.</summary>
		public SalesOrderDetailMap()
        {
			Table("[Sales].[SalesOrderDetail]");
			OptimisticLock.None();
			LazyLoad();

			Id(x=>x.SalesOrderDetailId)
				.Access.CamelCaseField(Prefix.Underscore)
				.Column("[SalesOrderDetailID]")
				.GeneratedBy.Identity();
			Map(x=>x.CarrierTrackingNumber).Length(25).Column("[CarrierTrackingNumber]").Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.LineTotal).ReadOnly().Column("[LineTotal]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.ModifiedDate).Column("[ModifiedDate]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.OrderQty).Column("[OrderQty]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.Rowguid).Column("[rowguid]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.UnitPrice).Column("[UnitPrice]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.UnitPriceDiscount).Column("[UnitPriceDiscount]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);

			References(x=>x.SpecialOfferProduct)
				.Access.CamelCaseField(Prefix.Underscore)
				.Cascade.All()
				.Fetch.Select()
				.Columns("[ProductID]", "[SpecialOfferID]");

			AdditionalMappingInfo();
		} 
				
		/// <summary>Partial method for adding additional mapping information in a partial class.</summary>
		partial void AdditionalMappingInfo();
	} 
}  
