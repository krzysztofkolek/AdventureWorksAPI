


using System;
using System.Collections.Generic;
using System.Text;
using FluentNHibernate.Mapping;
using AdventureWorks.EntityClasses;

namespace AdventureWorks.Mappings.Production
{
    using EntityClasses.Production;

    /// <summary>Represents the mapping of the 'Production.Illustration' entity, represented by the 'Illustration' class.</summary>
	public partial class IllustrationMap : ClassMap<Illustration>
    {
		/// <summary>Initializes a new instance of the <see cref="IllustrationMap"/> class.</summary>
		public IllustrationMap()
        {
			Table("[Production].[Illustration]");
			OptimisticLock.None();
			LazyLoad();

			Id(x=>x.IllustrationId)
				.Access.CamelCaseField(Prefix.Underscore)
				.Column("[IllustrationID]")
				.GeneratedBy.Identity();
			Map(x=>x.Diagram).CustomType("StringClob").Column("[Diagram]").Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.ModifiedDate).Column("[ModifiedDate]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);

			HasMany(x=>x.ProductModelIllustrations)
				.Access.CamelCaseField(Prefix.Underscore)
				.Cascade.AllDeleteOrphan()
				.Fetch.Select()
				.AsSet()
				.Inverse()
				.LazyLoad()
				.KeyColumns.Add("[IllustrationID]");

			AdditionalMappingInfo();
		} 
				
		/// <summary>Partial method for adding additional mapping information in a partial class.</summary>
		partial void AdditionalMappingInfo();
	} 
}  
