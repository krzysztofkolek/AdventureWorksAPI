


using System;
using System.Collections.Generic;
using System.Text;
using FluentNHibernate.Mapping;
using AdventureWorks.EntityClasses;

namespace AdventureWorks.Mappings.Purchasing
{
    using EntityClasses.Purchasing;

    /// <summary>Represents the mapping of the 'Purchasing.PurchaseOrderHeader' entity, represented by the 'PurchaseOrderHeader' class.</summary>
	public partial class PurchaseOrderHeaderMap : ClassMap<PurchaseOrderHeader>
    {
		/// <summary>Initializes a new instance of the <see cref="PurchaseOrderHeaderMap"/> class.</summary>
		public PurchaseOrderHeaderMap()
        {
			Table("[Purchasing].[PurchaseOrderHeader]");
			OptimisticLock.None();
			LazyLoad();

			Id(x=>x.PurchaseOrderId)
				.Access.CamelCaseField(Prefix.Underscore)
				.Column("[PurchaseOrderID]")
				.GeneratedBy.Identity();
			Map(x=>x.Freight).Column("[Freight]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.ModifiedDate).Column("[ModifiedDate]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.OrderDate).Column("[OrderDate]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.RevisionNumber).Column("[RevisionNumber]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.ShipDate).Column("[ShipDate]").Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.Status).Column("[Status]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.SubTotal).Column("[SubTotal]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.TaxAmt).Column("[TaxAmt]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.TotalDue).ReadOnly().Column("[TotalDue]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);

			References(x=>x.Employee)
				.Access.CamelCaseField(Prefix.Underscore)
				.Cascade.All()
				.Fetch.Select()
				.Columns("[EmployeeID]");
			HasMany(x=>x.PurchaseOrderDetails)
				.Access.CamelCaseField(Prefix.Underscore)
				.Cascade.AllDeleteOrphan()
				.Fetch.Select()
				.AsSet()
				.Inverse()
				.LazyLoad()
				.KeyColumns.Add("[PurchaseOrderID]");
			References(x=>x.ShipMethod)
				.Access.CamelCaseField(Prefix.Underscore)
				.Cascade.All()
				.Fetch.Select()
				.Columns("[ShipMethodID]");
			References(x=>x.Vendor)
				.Access.CamelCaseField(Prefix.Underscore)
				.Cascade.All()
				.Fetch.Select()
				.Columns("[VendorID]");

			AdditionalMappingInfo();
		} 
				
		/// <summary>Partial method for adding additional mapping information in a partial class.</summary>
		partial void AdditionalMappingInfo();
	} 
}  
