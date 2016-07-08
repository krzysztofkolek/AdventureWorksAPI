


using System;
using System.Collections.Generic;
using System.Text;
using FluentNHibernate.Mapping;
using AdventureWorks.EntityClasses;

namespace AdventureWorks.Mappings.Sales
{
    using EntityClasses.Sales;

    /// <summary>Represents the mapping of the 'Sales.CustomerAddress' entity, represented by the 'CustomerAddress' class.</summary>
	public partial class CustomerAddressMap : ClassMap<CustomerAddress>
    {
		/// <summary>Initializes a new instance of the <see cref="CustomerAddressMap"/> class.</summary>
		public CustomerAddressMap()
        {
			Table("[Sales].[CustomerAddress]");
			OptimisticLock.None();
			LazyLoad();

			CompositeId()
				.KeyReference(x => x.Address, x => x.Access.CamelCaseField(Prefix.Underscore), "[AddressID]")
				.KeyReference(x => x.Customer, x => x.Access.CamelCaseField(Prefix.Underscore), "[CustomerID]");
			Map(x=>x.ModifiedDate).Column("[ModifiedDate]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.Rowguid).Column("[rowguid]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);

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
