


using System;
using System.Collections.Generic;
using System.Text;
using FluentNHibernate.Mapping;
using AdventureWorks.EntityClasses;

namespace AdventureWorks.Mappings.Sales
{
    using EntityClasses.Sales;

    /// <summary>Represents the mapping of the 'Sales.CreditCard' entity, represented by the 'CreditCard' class.</summary>
	public partial class CreditCardMap : ClassMap<CreditCard>
    {
		/// <summary>Initializes a new instance of the <see cref="CreditCardMap"/> class.</summary>
		public CreditCardMap()
        {
			Table("[Sales].[CreditCard]");
			OptimisticLock.None();
			LazyLoad();

			Id(x=>x.CreditCardId)
				.Access.CamelCaseField(Prefix.Underscore)
				.Column("[CreditCardID]")
				.GeneratedBy.Identity();
			Map(x=>x.CardNumber).Length(25).Column("[CardNumber]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.CardType).Length(50).Column("[CardType]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.ExpMonth).Column("[ExpMonth]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.ExpYear).Column("[ExpYear]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.ModifiedDate).Column("[ModifiedDate]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);

			HasMany(x=>x.ContactCreditCards)
				.Access.CamelCaseField(Prefix.Underscore)
				.Cascade.AllDeleteOrphan()
				.Fetch.Select()
				.AsSet()
				.Inverse()
				.LazyLoad()
				.KeyColumns.Add("[CreditCardID]");
			HasMany(x=>x.SalesOrderHeaders)
				.Access.CamelCaseField(Prefix.Underscore)
				.Cascade.AllDeleteOrphan()
				.Fetch.Select()
				.AsSet()
				.Inverse()
				.LazyLoad()
				.KeyColumns.Add("[CreditCardID]");

			AdditionalMappingInfo();
		} 
				
		/// <summary>Partial method for adding additional mapping information in a partial class.</summary>
		partial void AdditionalMappingInfo();
	} 
}  
