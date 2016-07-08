


using System;
using System.Collections.Generic;
using System.Text;
using FluentNHibernate.Mapping;
using AdventureWorks.EntityClasses;

namespace AdventureWorks.Mappings.Production
{
    using EntityClasses.Production;

    /// <summary>Represents the mapping of the 'Production.WorkOrderRouting' entity, represented by the 'WorkOrderRouting' class.</summary>
	public partial class WorkOrderRoutingMap : ClassMap<WorkOrderRouting>
    {
		/// <summary>Initializes a new instance of the <see cref="WorkOrderRoutingMap"/> class.</summary>
		public WorkOrderRoutingMap()
        {
			Table("[Production].[WorkOrderRouting]");
			OptimisticLock.None();
			LazyLoad();

			CompositeId()
				.KeyProperty(x => x.OperationSequence, x => x.Access.CamelCaseField(Prefix.Underscore).ColumnName("[OperationSequence]"))
				.KeyProperty(x => x.ProductId, x => x.Access.CamelCaseField(Prefix.Underscore).ColumnName("[ProductID]"))
				.KeyReference(x => x.WorkOrder, x => x.Access.CamelCaseField(Prefix.Underscore), "[WorkOrderID]");
			Map(x=>x.ActualCost).Column("[ActualCost]").Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.ActualEndDate).Column("[ActualEndDate]").Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.ActualResourceHrs).Column("[ActualResourceHrs]").Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.ActualStartDate).Column("[ActualStartDate]").Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.ModifiedDate).Column("[ModifiedDate]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.PlannedCost).Column("[PlannedCost]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.ScheduledEndDate).Column("[ScheduledEndDate]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.ScheduledStartDate).Column("[ScheduledStartDate]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);

			References(x=>x.Location)
				.Access.CamelCaseField(Prefix.Underscore)
				.Cascade.All()
				.Fetch.Select()
				.Columns("[LocationID]");

			AdditionalMappingInfo();
		} 
				
		/// <summary>Partial method for adding additional mapping information in a partial class.</summary>
		partial void AdditionalMappingInfo();
	} 
}  
