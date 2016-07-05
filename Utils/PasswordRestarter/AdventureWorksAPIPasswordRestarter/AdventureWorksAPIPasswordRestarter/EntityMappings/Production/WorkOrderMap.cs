


using System;
using System.Collections.Generic;
using System.Text;
using FluentNHibernate.Mapping;
using AdventureWorks.EntityClasses;

namespace AdventureWorks.Mappings.Production
{
    using EntityClasses.Production;

    /// <summary>Represents the mapping of the 'Production.WorkOrder' entity, represented by the 'WorkOrder' class.</summary>
	public partial class WorkOrderMap : ClassMap<WorkOrder>
    {
		/// <summary>Initializes a new instance of the <see cref="WorkOrderMap"/> class.</summary>
		public WorkOrderMap()
        {
			Table("[Production].[WorkOrder]");
			OptimisticLock.None();
			LazyLoad();

			Id(x=>x.WorkOrderId)
				.Access.CamelCaseField(Prefix.Underscore)
				.Column("[WorkOrderID]")
				.GeneratedBy.Identity();
			Map(x=>x.DueDate).Column("[DueDate]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.EndDate).Column("[EndDate]").Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.ModifiedDate).Column("[ModifiedDate]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.OrderQty).Column("[OrderQty]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.ScrappedQty).Column("[ScrappedQty]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.StartDate).Column("[StartDate]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.StockedQty).ReadOnly().Column("[StockedQty]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);

			References(x=>x.Product)
				.Access.CamelCaseField(Prefix.Underscore)
				.Cascade.All()
				.Fetch.Select()
				.Columns("[ProductID]");
			References(x=>x.ScrapReason)
				.Access.CamelCaseField(Prefix.Underscore)
				.Cascade.All()
				.Fetch.Select()
				.Columns("[ScrapReasonID]");
			HasMany(x=>x.WorkOrderRoutings)
				.Access.CamelCaseField(Prefix.Underscore)
				.Cascade.AllDeleteOrphan()
				.Fetch.Select()
				.AsSet()
				.Inverse()
				.LazyLoad()
				.KeyColumns.Add("[WorkOrderID]");

			AdditionalMappingInfo();
		} 
				
		/// <summary>Partial method for adding additional mapping information in a partial class.</summary>
		partial void AdditionalMappingInfo();
	} 
}  
