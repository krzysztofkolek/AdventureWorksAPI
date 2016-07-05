


using System;
using System.Collections.Generic;
using System.Text;
using FluentNHibernate.Mapping;
using AdventureWorks.EntityClasses;

namespace AdventureWorks.Mappings.Sales
{
    using EntityClasses.Sales;

    /// <summary>Represents the mapping of the 'Sales.StoreContact' entity, represented by the 'StoreContact' class.</summary>
	public partial class StoreContactMap : ClassMap<StoreContact>
    {
		/// <summary>Initializes a new instance of the <see cref="StoreContactMap"/> class.</summary>
		public StoreContactMap()
        {
			Table("[Sales].[StoreContact]");
			OptimisticLock.None();
			LazyLoad();

			CompositeId()
				.KeyReference(x => x.Contact, x => x.Access.CamelCaseField(Prefix.Underscore), "[ContactID]")
				.KeyReference(x => x.Store, x => x.Access.CamelCaseField(Prefix.Underscore), "[CustomerID]");
			Map(x=>x.ModifiedDate).Column("[ModifiedDate]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.Rowguid).Column("[rowguid]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);

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
