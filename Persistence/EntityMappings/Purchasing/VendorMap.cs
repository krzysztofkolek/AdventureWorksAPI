


using System;
using System.Collections.Generic;
using System.Text;
using FluentNHibernate.Mapping;
using AdventureWorks.EntityClasses;

namespace AdventureWorks.Mappings.Purchasing
{
    using EntityClasses.Purchasing;

    /// <summary>Represents the mapping of the 'Purchasing.Vendor' entity, represented by the 'Vendor' class.</summary>
	public partial class VendorMap : ClassMap<Vendor>
    {
		/// <summary>Initializes a new instance of the <see cref="VendorMap"/> class.</summary>
		public VendorMap()
        {
			Table("[Purchasing].[Vendor]");
			OptimisticLock.None();
			LazyLoad();

			Id(x=>x.VendorId)
				.Access.CamelCaseField(Prefix.Underscore)
				.Column("[VendorID]")
				.GeneratedBy.Identity();
			Map(x=>x.AccountNumber).Length(15).Column("[AccountNumber]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.ActiveFlag).Column("[ActiveFlag]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.CreditRating).Column("[CreditRating]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.ModifiedDate).Column("[ModifiedDate]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.Name).Length(50).Column("[Name]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.PreferredVendorStatus).Column("[PreferredVendorStatus]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.PurchasingWebServiceUrl).Length(1024).Column("[PurchasingWebServiceURL]").Access.CamelCaseField(Prefix.Underscore);

			HasMany(x=>x.ProductVendors)
				.Access.CamelCaseField(Prefix.Underscore)
				.Cascade.AllDeleteOrphan()
				.Fetch.Select()
				.AsSet()
				.Inverse()
				.LazyLoad()
				.KeyColumns.Add("[VendorID]");
			HasMany(x=>x.PurchaseOrderHeaders)
				.Access.CamelCaseField(Prefix.Underscore)
				.Cascade.AllDeleteOrphan()
				.Fetch.Select()
				.AsSet()
				.Inverse()
				.LazyLoad()
				.KeyColumns.Add("[VendorID]");
			HasMany(x=>x.VendorAddresses)
				.Access.CamelCaseField(Prefix.Underscore)
				.Cascade.AllDeleteOrphan()
				.Fetch.Select()
				.AsSet()
				.Inverse()
				.LazyLoad()
				.KeyColumns.Add("[VendorID]");
			HasMany(x=>x.VendorContacts)
				.Access.CamelCaseField(Prefix.Underscore)
				.Cascade.AllDeleteOrphan()
				.Fetch.Select()
				.AsSet()
				.Inverse()
				.LazyLoad()
				.KeyColumns.Add("[VendorID]");

			AdditionalMappingInfo();
		} 
				
		/// <summary>Partial method for adding additional mapping information in a partial class.</summary>
		partial void AdditionalMappingInfo();
	} 
}  
