


using System;
using System.Collections.Generic;
using System.Text;
using FluentNHibernate.Mapping;
using AdventureWorks.EntityClasses;

namespace AdventureWorks.Mappings.Person
{
    using EntityClasses.Person;

    /// <summary>Represents the mapping of the 'Person.Contact' entity, represented by the 'Contact' class.</summary>
	public partial class ContactMap : ClassMap<Contact>
    {
		/// <summary>Initializes a new instance of the <see cref="ContactMap"/> class.</summary>
		public ContactMap()
        {
			Table("[Person].[Contact]");
			OptimisticLock.None();
			LazyLoad();

			Id(x=>x.ContactId)
				.Access.CamelCaseField(Prefix.Underscore)
				.Column("[ContactID]")
				.GeneratedBy.Identity();
			Map(x=>x.AdditionalContactInfo).CustomType("StringClob").Column("[AdditionalContactInfo]").Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.EmailAddress).Length(50).Column("[EmailAddress]").Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.EmailPromotion).Column("[EmailPromotion]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.FirstName).Length(50).Column("[FirstName]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.LastName).Length(50).Column("[LastName]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.MiddleName).Length(50).Column("[MiddleName]").Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.ModifiedDate).Column("[ModifiedDate]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.NameStyle).Column("[NameStyle]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.PasswordHash).Length(128).Column("[PasswordHash]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.PasswordSalt).Length(10).Column("[PasswordSalt]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.Phone).Length(25).Column("[Phone]").Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.Rowguid).Column("[rowguid]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.Suffix).Length(10).Column("[Suffix]").Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.Title).Length(8).Column("[Title]").Access.CamelCaseField(Prefix.Underscore);

			HasMany(x=>x.ContactCreditCards)
				.Access.CamelCaseField(Prefix.Underscore)
				.Cascade.AllDeleteOrphan()
				.Fetch.Select()
				.AsSet()
				.Inverse()
				.LazyLoad()
				.KeyColumns.Add("[ContactID]");
			HasMany(x=>x.Employees)
				.Access.CamelCaseField(Prefix.Underscore)
				.Cascade.AllDeleteOrphan()
				.Fetch.Select()
				.AsSet()
				.Inverse()
				.LazyLoad()
				.KeyColumns.Add("[ContactID]");
			HasMany(x=>x.Individuals)
				.Access.CamelCaseField(Prefix.Underscore)
				.Cascade.AllDeleteOrphan()
				.Fetch.Select()
				.AsSet()
				.Inverse()
				.LazyLoad()
				.KeyColumns.Add("[ContactID]");
			HasMany(x=>x.SalesOrderHeaders)
				.Access.CamelCaseField(Prefix.Underscore)
				.Cascade.AllDeleteOrphan()
				.Fetch.Select()
				.AsSet()
				.Inverse()
				.LazyLoad()
				.KeyColumns.Add("[ContactID]");
			HasMany(x=>x.StoreContacts)
				.Access.CamelCaseField(Prefix.Underscore)
				.Cascade.AllDeleteOrphan()
				.Fetch.Select()
				.AsSet()
				.Inverse()
				.LazyLoad()
				.KeyColumns.Add("[ContactID]");
			HasMany(x=>x.VendorContacts)
				.Access.CamelCaseField(Prefix.Underscore)
				.Cascade.AllDeleteOrphan()
				.Fetch.Select()
				.AsSet()
				.Inverse()
				.LazyLoad()
				.KeyColumns.Add("[ContactID]");

			AdditionalMappingInfo();
		} 
				
		/// <summary>Partial method for adding additional mapping information in a partial class.</summary>
		partial void AdditionalMappingInfo();
	} 
}  
