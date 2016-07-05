


using System;
using System.Collections.Generic;
using System.Text;
using FluentNHibernate.Mapping;
using AdventureWorks.EntityClasses;

namespace AdventureWorks.Mappings.Person
{
    using EntityClasses.Person;

    /// <summary>Represents the mapping of the 'Person.Address' entity, represented by the 'Address' class.</summary>
	public partial class AddressMap : ClassMap<Address>
    {
		/// <summary>Initializes a new instance of the <see cref="AddressMap"/> class.</summary>
		public AddressMap()
        {
			Table("[Person].[Address]");
			OptimisticLock.None();
			LazyLoad();

			Id(x=>x.AddressId)
				.Access.CamelCaseField(Prefix.Underscore)
				.Column("[AddressID]")
				.GeneratedBy.Identity();
			Map(x=>x.AddressLine1).Length(60).Column("[AddressLine1]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.AddressLine2).Length(60).Column("[AddressLine2]").Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.City).Length(30).Column("[City]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.ModifiedDate).Column("[ModifiedDate]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.PostalCode).Length(15).Column("[PostalCode]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.Rowguid).Column("[rowguid]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);

			HasMany(x=>x.CustomerAddresses)
				.Access.CamelCaseField(Prefix.Underscore)
				.Cascade.AllDeleteOrphan()
				.Fetch.Select()
				.AsSet()
				.Inverse()
				.LazyLoad()
				.KeyColumns.Add("[AddressID]");
			HasMany(x=>x.EmployeeAddresses)
				.Access.CamelCaseField(Prefix.Underscore)
				.Cascade.AllDeleteOrphan()
				.Fetch.Select()
				.AsSet()
				.Inverse()
				.LazyLoad()
				.KeyColumns.Add("[AddressID]");
			HasMany(x=>x.SalesOrderHeaders)
				.Access.CamelCaseField(Prefix.Underscore)
				.Cascade.AllDeleteOrphan()
				.Fetch.Select()
				.AsSet()
				.Inverse()
				.LazyLoad()
				.KeyColumns.Add("[BillToAddressID]");
			HasMany(x=>x.SalesOrderHeaders1)
				.Access.CamelCaseField(Prefix.Underscore)
				.Cascade.AllDeleteOrphan()
				.Fetch.Select()
				.AsSet()
				.Inverse()
				.LazyLoad()
				.KeyColumns.Add("[ShipToAddressID]");
			References(x=>x.StateProvince)
				.Access.CamelCaseField(Prefix.Underscore)
				.Cascade.All()
				.Fetch.Select()
				.Columns("[StateProvinceID]");
			HasMany(x=>x.VendorAddresses)
				.Access.CamelCaseField(Prefix.Underscore)
				.Cascade.AllDeleteOrphan()
				.Fetch.Select()
				.AsSet()
				.Inverse()
				.LazyLoad()
				.KeyColumns.Add("[AddressID]");

			AdditionalMappingInfo();
		} 
				
		/// <summary>Partial method for adding additional mapping information in a partial class.</summary>
		partial void AdditionalMappingInfo();
	} 
}  
