


using System;
using System.Collections.Generic;
using System.Text;
using FluentNHibernate.Mapping;
using AdventureWorks.EntityClasses;

namespace AdventureWorks.Mappings.Production
{
    using EntityClasses.Production;

    /// <summary>Represents the mapping of the 'Production.Location' entity, represented by the 'Location' class.</summary>
	public partial class LocationMap : ClassMap<Location>
    {
		/// <summary>Initializes a new instance of the <see cref="LocationMap"/> class.</summary>
		public LocationMap()
        {
			Table("[Production].[Location]");
			OptimisticLock.None();
			LazyLoad();

			Id(x=>x.LocationId)
				.Access.CamelCaseField(Prefix.Underscore)
				.Column("[LocationID]")
				.GeneratedBy.Identity();
			Map(x=>x.Availability).Column("[Availability]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.CostRate).Column("[CostRate]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.ModifiedDate).Column("[ModifiedDate]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.Name).Length(50).Column("[Name]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);

			HasMany(x=>x.ProductInventories)
				.Access.CamelCaseField(Prefix.Underscore)
				.Cascade.AllDeleteOrphan()
				.Fetch.Select()
				.AsSet()
				.Inverse()
				.LazyLoad()
				.KeyColumns.Add("[LocationID]");
			HasMany(x=>x.WorkOrderRoutings)
				.Access.CamelCaseField(Prefix.Underscore)
				.Cascade.AllDeleteOrphan()
				.Fetch.Select()
				.AsSet()
				.Inverse()
				.LazyLoad()
				.KeyColumns.Add("[LocationID]");

			AdditionalMappingInfo();
		} 
				
		/// <summary>Partial method for adding additional mapping information in a partial class.</summary>
		partial void AdditionalMappingInfo();
	} 
}  
