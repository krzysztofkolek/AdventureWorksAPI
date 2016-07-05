


using System;
using System.Collections.Generic;
using System.Text;
using FluentNHibernate.Mapping;
using AdventureWorks.EntityClasses;

namespace AdventureWorks.Mappings.Purchasing
{
    using EntityClasses.Purchasing;

    /// <summary>Represents the mapping of the 'Purchasing.VendorAddress' entity, represented by the 'VendorAddress' class.</summary>
	public partial class VendorAddressMap : ClassMap<VendorAddress>
    {
		/// <summary>Initializes a new instance of the <see cref="VendorAddressMap"/> class.</summary>
		public VendorAddressMap()
        {
			Table("[Purchasing].[VendorAddress]");
			OptimisticLock.None();
			LazyLoad();

			CompositeId()
				.KeyReference(x => x.Address, x => x.Access.CamelCaseField(Prefix.Underscore), "[AddressID]")
				.KeyReference(x => x.Vendor, x => x.Access.CamelCaseField(Prefix.Underscore), "[VendorID]");
			Map(x=>x.ModifiedDate).Column("[ModifiedDate]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);

			References(x=>x.AddressType)
				.Access.CamelCaseField(Prefix.Underscore)
				.Cascade.All()
				.Fetch.Select()
				.Columns("[AddressTypeID]");

			AdditionalMappingInfo();
		} 
				
		/// <summary>Partial method for adding additional mapping information in a partial class.</summary>
		partial void AdditionalMappingInfo();
	} 
}  
