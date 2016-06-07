


using System;
using System.Collections.Generic;
using System.Text;
using FluentNHibernate.Mapping;
using AdventureWorks.EntityClasses;

namespace AdventureWorks.Mappings.Sales
{
    using EntityClasses.Sales;

    /// <summary>Represents the mapping of the 'Sales.ContactCreditCard' entity, represented by the 'ContactCreditCard' class.</summary>
	public partial class ContactCreditCardMap : ClassMap<ContactCreditCard>
    {
		/// <summary>Initializes a new instance of the <see cref="ContactCreditCardMap"/> class.</summary>
		public ContactCreditCardMap()
        {
			Table("[Sales].[ContactCreditCard]");
			OptimisticLock.None();
			LazyLoad();

			CompositeId()
				.KeyReference(x => x.Contact, x => x.Access.CamelCaseField(Prefix.Underscore), "[ContactID]")
				.KeyReference(x => x.CreditCard, x => x.Access.CamelCaseField(Prefix.Underscore), "[CreditCardID]");
			Map(x=>x.ModifiedDate).Column("[ModifiedDate]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);


			AdditionalMappingInfo();
		} 
				
		/// <summary>Partial method for adding additional mapping information in a partial class.</summary>
		partial void AdditionalMappingInfo();
	} 
}  
