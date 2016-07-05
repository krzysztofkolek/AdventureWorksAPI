


using System;
using System.Collections.Generic;
using System.Text;
using FluentNHibernate.Mapping;
using AdventureWorks.EntityClasses;

namespace AdventureWorks.Mappings.Production
{
    using EntityClasses.Production;

    /// <summary>Represents the mapping of the 'Production.Culture' entity, represented by the 'Culture' class.</summary>
	public partial class CultureMap : ClassMap<Culture>
    {
		/// <summary>Initializes a new instance of the <see cref="CultureMap"/> class.</summary>
		public CultureMap()
        {
			Table("[Production].[Culture]");
			OptimisticLock.None();
			LazyLoad();

			Id(x=>x.CultureId)
				.Access.CamelCaseField(Prefix.Underscore)
				.Column("[CultureID]")
				.GeneratedBy.Assigned();
			Map(x=>x.ModifiedDate).Column("[ModifiedDate]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.Name).Length(50).Column("[Name]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);

			HasMany(x=>x.ProductModelProductDescriptionCultures)
				.Access.CamelCaseField(Prefix.Underscore)
				.Cascade.AllDeleteOrphan()
				.Fetch.Select()
				.AsSet()
				.Inverse()
				.LazyLoad()
				.KeyColumns.Add("[CultureID]");

			AdditionalMappingInfo();
		} 
				
		/// <summary>Partial method for adding additional mapping information in a partial class.</summary>
		partial void AdditionalMappingInfo();
	} 
}  
