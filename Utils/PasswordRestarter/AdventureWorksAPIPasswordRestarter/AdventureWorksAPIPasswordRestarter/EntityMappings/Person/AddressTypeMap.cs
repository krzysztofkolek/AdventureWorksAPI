


using System;
using System.Collections.Generic;
using System.Text;
using FluentNHibernate.Mapping;
using AdventureWorks.EntityClasses;

namespace AdventureWorks.Mappings.Person
{
    using EntityClasses.Person;

    /// <summary>Represents the mapping of the 'Person.AddressType' entity, represented by the 'AddressType' class.</summary>
	public partial class AddressTypeMap : ClassMap<AddressType>
    {
		/// <summary>Initializes a new instance of the <see cref="AddressTypeMap"/> class.</summary>
		public AddressTypeMap()
        {
			Table("[Person].[AddressType]");
			OptimisticLock.None();
			LazyLoad();

			Id(x=>x.AddressTypeId)
				.Access.CamelCaseField(Prefix.Underscore)
				.Column("[AddressTypeID]")
				.GeneratedBy.Identity();
			Map(x=>x.ModifiedDate).Column("[ModifiedDate]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.Name).Length(50).Column("[Name]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.Rowguid).Column("[rowguid]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);

			HasMany(x=>x.CustomerAddresses)
				.Access.CamelCaseField(Prefix.Underscore)
				.Cascade.AllDeleteOrphan()
				.Fetch.Select()
				.AsSet()
				.Inverse()
				.LazyLoad()
				.KeyColumns.Add("[AddressTypeID]");
			HasMany(x=>x.VendorAddresses)
				.Access.CamelCaseField(Prefix.Underscore)
				.Cascade.AllDeleteOrphan()
				.Fetch.Select()
				.AsSet()
				.Inverse()
				.LazyLoad()
				.KeyColumns.Add("[AddressTypeID]");

			AdditionalMappingInfo();
		} 
				
		/// <summary>Partial method for adding additional mapping information in a partial class.</summary>
		partial void AdditionalMappingInfo();
	} 
}  
