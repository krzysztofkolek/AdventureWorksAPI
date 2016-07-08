


using System;
using System.Collections.Generic;
using System.Text;
using FluentNHibernate.Mapping;
using AdventureWorks.EntityClasses;

namespace AdventureWorks.Mappings.Purchasing
{
    using EntityClasses.Purchasing;

    /// <summary>Represents the mapping of the 'Purchasing.VendorContact' entity, represented by the 'VendorContact' class.</summary>
	public partial class VendorContactMap : ClassMap<VendorContact>
    {
		/// <summary>Initializes a new instance of the <see cref="VendorContactMap"/> class.</summary>
		public VendorContactMap()
        {
			Table("[Purchasing].[VendorContact]");
			OptimisticLock.None();
			LazyLoad();

			CompositeId()
				.KeyReference(x => x.Contact, x => x.Access.CamelCaseField(Prefix.Underscore), "[ContactID]")
				.KeyReference(x => x.Vendor, x => x.Access.CamelCaseField(Prefix.Underscore), "[VendorID]");
			Map(x=>x.ModifiedDate).Column("[ModifiedDate]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);

			References(x=>x.ContactType)
				.Access.CamelCaseField(Prefix.Underscore)
				.Cascade.All()
				.Fetch.Select()
				.Columns("[ContactTypeID]");

			AdditionalMappingInfo();
		} 
				
		/// <summary>Partial method for adding additional mapping information in a partial class.</summary>
		partial void AdditionalMappingInfo();
	} 
}  
