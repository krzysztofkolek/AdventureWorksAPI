


using System;
using System.Collections.Generic;
using System.Text;
using FluentNHibernate.Mapping;
using AdventureWorks.EntityClasses;

namespace AdventureWorks.Mappings.Production
{
    using EntityClasses.Production;

    /// <summary>Represents the mapping of the 'Production.TransactionHistory' entity, represented by the 'TransactionHistory' class.</summary>
	public partial class TransactionHistoryMap : ClassMap<TransactionHistory>
    {
		/// <summary>Initializes a new instance of the <see cref="TransactionHistoryMap"/> class.</summary>
		public TransactionHistoryMap()
        {
			Table("[Production].[TransactionHistory]");
			OptimisticLock.None();
			LazyLoad();

			Id(x=>x.TransactionId)
				.Access.CamelCaseField(Prefix.Underscore)
				.Column("[TransactionID]")
				.GeneratedBy.Identity();
			Map(x=>x.ActualCost).Column("[ActualCost]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.ModifiedDate).Column("[ModifiedDate]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.Quantity).Column("[Quantity]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.ReferenceOrderId).Column("[ReferenceOrderID]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.ReferenceOrderLineId).Column("[ReferenceOrderLineID]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.TransactionDate).Column("[TransactionDate]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.TransactionType).Length(1).Column("[TransactionType]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);

			References(x=>x.Product)
				.Access.CamelCaseField(Prefix.Underscore)
				.Cascade.All()
				.Fetch.Select()
				.Columns("[ProductID]");

			AdditionalMappingInfo();
		} 
				
		/// <summary>Partial method for adding additional mapping information in a partial class.</summary>
		partial void AdditionalMappingInfo();
	} 
}  
