


using System;
using System.Collections.Generic;
using System.Text;
using FluentNHibernate.Mapping;
using AdventureWorks.EntityClasses;

namespace AdventureWorks.Mappings.Production
{
    using EntityClasses.Production;

    /// <summary>Represents the mapping of the 'Production.ScrapReason' entity, represented by the 'ScrapReason' class.</summary>
	public partial class ScrapReasonMap : ClassMap<ScrapReason>
    {
		/// <summary>Initializes a new instance of the <see cref="ScrapReasonMap"/> class.</summary>
		public ScrapReasonMap()
        {
			Table("[Production].[ScrapReason]");
			OptimisticLock.None();
			LazyLoad();

			Id(x=>x.ScrapReasonId)
				.Access.CamelCaseField(Prefix.Underscore)
				.Column("[ScrapReasonID]")
				.GeneratedBy.Identity();
			Map(x=>x.ModifiedDate).Column("[ModifiedDate]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.Name).Length(50).Column("[Name]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);

			HasMany(x=>x.WorkOrders)
				.Access.CamelCaseField(Prefix.Underscore)
				.Cascade.AllDeleteOrphan()
				.Fetch.Select()
				.AsSet()
				.Inverse()
				.LazyLoad()
				.KeyColumns.Add("[ScrapReasonID]");

			AdditionalMappingInfo();
		} 
				
		/// <summary>Partial method for adding additional mapping information in a partial class.</summary>
		partial void AdditionalMappingInfo();
	} 
}  
