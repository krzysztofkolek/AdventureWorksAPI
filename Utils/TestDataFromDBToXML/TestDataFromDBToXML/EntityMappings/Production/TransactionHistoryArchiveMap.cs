


using System;
using System.Collections.Generic;
using System.Text;
using FluentNHibernate.Mapping;
using AdventureWorks.EntityClasses;

namespace AdventureWorks.Mappings.Production
{
    using EntityClasses.Production;

    /// <summary>Represents the mapping of the 'Production.TransactionHistoryArchive' entity, represented by the 'TransactionHistoryArchive' class.</summary>
	public partial class TransactionHistoryArchiveMap : ClassMap<TransactionHistoryArchive>
    {
		/// <summary>Initializes a new instance of the <see cref="TransactionHistoryArchiveMap"/> class.</summary>
		public TransactionHistoryArchiveMap()
        {
			Table("[Production].[TransactionHistoryArchive]");
			OptimisticLock.None();
			LazyLoad();

			Id(x=>x.TransactionId)
				.Access.CamelCaseField(Prefix.Underscore)
				.Column("[TransactionID]")
				.GeneratedBy.Assigned();
			Map(x=>x.ActualCost).Column("[ActualCost]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.ModifiedDate).Column("[ModifiedDate]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.ProductId).Column("[ProductID]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.Quantity).Column("[Quantity]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.ReferenceOrderId).Column("[ReferenceOrderID]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.ReferenceOrderLineId).Column("[ReferenceOrderLineID]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.TransactionDate).Column("[TransactionDate]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.TransactionType).Length(1).Column("[TransactionType]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);


			AdditionalMappingInfo();
		} 
				
		/// <summary>Partial method for adding additional mapping information in a partial class.</summary>
		partial void AdditionalMappingInfo();
	} 
}  
