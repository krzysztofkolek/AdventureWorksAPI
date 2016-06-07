


using System;
using System.Collections.Generic;
using System.Text;
using FluentNHibernate.Mapping;
using AdventureWorks.EntityClasses;

namespace AdventureWorks.Mappings.Sales
{
    using EntityClasses.Sales;

    /// <summary>Represents the mapping of the 'Sales.Individual' entity, represented by the 'Individual' class.</summary>
	public partial class IndividualMap : ClassMap<Individual>
    {
		/// <summary>Initializes a new instance of the <see cref="IndividualMap"/> class.</summary>
		public IndividualMap()
        {
			Table("[Sales].[Individual]");
			OptimisticLock.None();
			LazyLoad();

			Id(x=>x.CustomerId)
				.Access.CamelCaseField(Prefix.Underscore)
				.Column("[CustomerID]")
				.GeneratedBy.Foreign("Customer");
			Map(x=>x.Demographics).CustomType("StringClob").Column("[Demographics]").Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.ModifiedDate).Column("[ModifiedDate]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);

			References(x=>x.Contact)
				.Access.CamelCaseField(Prefix.Underscore)
				.Cascade.All()
				.Fetch.Select()
				.Columns("[ContactID]");
			HasOne(x=>x.Customer)
				.Access.CamelCaseField(Prefix.Underscore)
				.Cascade.All()
				.Fetch.Select()
				.Constrained();

			AdditionalMappingInfo();
		} 
				
		/// <summary>Partial method for adding additional mapping information in a partial class.</summary>
		partial void AdditionalMappingInfo();
	} 
}  
