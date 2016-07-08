


using System;
using System.Collections.Generic;
using System.Text;
using FluentNHibernate.Mapping;
using AdventureWorks.EntityClasses;

namespace AdventureWorks.Mappings.Sales
{
    using EntityClasses.Sales;

    /// <summary>Represents the mapping of the 'Sales.SalesOrderHeader' entity, represented by the 'SalesOrderHeader' class.</summary>
	public partial class SalesOrderHeaderMap : ClassMap<SalesOrderHeader>
    {
		/// <summary>Initializes a new instance of the <see cref="SalesOrderHeaderMap"/> class.</summary>
		public SalesOrderHeaderMap()
        {
			Table("[Sales].[SalesOrderHeader]");
			OptimisticLock.None();
			LazyLoad();

			Id(x=>x.SalesOrderId)
				.Access.CamelCaseField(Prefix.Underscore)
				.Column("[SalesOrderID]")
				.GeneratedBy.Identity();
			Map(x=>x.AccountNumber).Length(15).Column("[AccountNumber]").Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.Comment).Length(128).Column("[Comment]").Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.CreditCardApprovalCode).Length(15).Column("[CreditCardApprovalCode]").Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.DueDate).Column("[DueDate]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.Freight).Column("[Freight]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.ModifiedDate).Column("[ModifiedDate]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.OnlineOrderFlag).Column("[OnlineOrderFlag]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.OrderDate).Column("[OrderDate]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.PurchaseOrderNumber).Length(25).Column("[PurchaseOrderNumber]").Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.RevisionNumber).Column("[RevisionNumber]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.Rowguid).Column("[rowguid]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.SalesOrderNumber).ReadOnly().Length(25).Column("[SalesOrderNumber]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.ShipDate).Column("[ShipDate]").Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.Status).Column("[Status]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.SubTotal).Column("[SubTotal]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.TaxAmt).Column("[TaxAmt]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.TotalDue).ReadOnly().Column("[TotalDue]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);

			References(x=>x.Address)
				.Access.CamelCaseField(Prefix.Underscore)
				.Cascade.All()
				.Fetch.Select()
				.Columns("[BillToAddressID]");
			References(x=>x.Address1)
				.Access.CamelCaseField(Prefix.Underscore)
				.Cascade.All()
				.Fetch.Select()
				.Columns("[ShipToAddressID]");
			References(x=>x.Contact)
				.Access.CamelCaseField(Prefix.Underscore)
				.Cascade.All()
				.Fetch.Select()
				.Columns("[ContactID]");
			References(x=>x.CreditCard)
				.Access.CamelCaseField(Prefix.Underscore)
				.Cascade.All()
				.Fetch.Select()
				.Columns("[CreditCardID]");
			References(x=>x.CurrencyRate)
				.Access.CamelCaseField(Prefix.Underscore)
				.Cascade.All()
				.Fetch.Select()
				.Columns("[CurrencyRateID]");
			References(x=>x.Customer)
				.Access.CamelCaseField(Prefix.Underscore)
				.Cascade.All()
				.Fetch.Select()
				.Columns("[CustomerID]");
			HasMany(x=>x.SalesOrderDetails)
				.Access.CamelCaseField(Prefix.Underscore)
				.Cascade.AllDeleteOrphan()
				.Fetch.Select()
				.AsSet()
				.Inverse()
				.LazyLoad()
				.KeyColumns.Add("[SalesOrderID]");
			HasMany(x=>x.SalesOrderHeaderSalesReasons)
				.Access.CamelCaseField(Prefix.Underscore)
				.Cascade.AllDeleteOrphan()
				.Fetch.Select()
				.AsSet()
				.Inverse()
				.LazyLoad()
				.KeyColumns.Add("[SalesOrderID]");
			References(x=>x.SalesPerson)
				.Access.CamelCaseField(Prefix.Underscore)
				.Cascade.All()
				.Fetch.Select()
				.Columns("[SalesPersonID]");
			References(x=>x.SalesTerritory)
				.Access.CamelCaseField(Prefix.Underscore)
				.Cascade.All()
				.Fetch.Select()
				.Columns("[TerritoryID]");
			References(x=>x.ShipMethod)
				.Access.CamelCaseField(Prefix.Underscore)
				.Cascade.All()
				.Fetch.Select()
				.Columns("[ShipMethodID]");

			AdditionalMappingInfo();
		} 
				
		/// <summary>Partial method for adding additional mapping information in a partial class.</summary>
		partial void AdditionalMappingInfo();
	} 
}  
