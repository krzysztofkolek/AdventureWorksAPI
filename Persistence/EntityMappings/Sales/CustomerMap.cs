


using System;
using System.Collections.Generic;
using System.Text;
using FluentNHibernate.Mapping;
using AdventureWorks.EntityClasses;

namespace AdventureWorks.Mappings.Sales
{
    using EntityClasses.Sales;

    /// <summary>Represents the mapping of the 'Sales.Customer' entity, represented by the 'Customer' class.</summary>
	public partial class CustomerMap : ClassMap<Customer>
    {
		/// <summary>Initializes a new instance of the <see cref="CustomerMap"/> class.</summary>
		public CustomerMap()
        {
			Table("[Sales].[Customer]");
			OptimisticLock.None();
			LazyLoad();

			Id(x=>x.CustomerId)
				.Access.CamelCaseField(Prefix.Underscore)
				.Column("[CustomerID]")
				.GeneratedBy.Identity();
			Map(x=>x.AccountNumber).ReadOnly().Length(10).Column("[AccountNumber]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.CustomerType).Length(1).Column("[CustomerType]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.ModifiedDate).Column("[ModifiedDate]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.Rowguid).Column("[rowguid]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);

			HasMany(x=>x.CustomerAddresses)
				.Access.CamelCaseField(Prefix.Underscore)
				.Cascade.AllDeleteOrphan()
				.Fetch.Select()
				.AsSet()
				.Inverse()
				.LazyLoad()
				.KeyColumns.Add("[CustomerID]");
			HasOne(x=>x.Individual)
				.Access.CamelCaseField(Prefix.Underscore)
				.Cascade.All()
				.Fetch.Select();
			HasMany(x=>x.SalesOrderHeaders)
				.Access.CamelCaseField(Prefix.Underscore)
				.Cascade.AllDeleteOrphan()
				.Fetch.Select()
				.AsSet()
				.Inverse()
				.LazyLoad()
				.KeyColumns.Add("[CustomerID]");
			References(x=>x.SalesTerritory)
				.Access.CamelCaseField(Prefix.Underscore)
				.Cascade.All()
				.Fetch.Select()
				.Columns("[TerritoryID]");
			HasOne(x=>x.Store)
				.Access.CamelCaseField(Prefix.Underscore)
				.Cascade.All()
				.Fetch.Select();

			AdditionalMappingInfo();
		} 
				
		/// <summary>Partial method for adding additional mapping information in a partial class.</summary>
		partial void AdditionalMappingInfo();
	} 
}  
