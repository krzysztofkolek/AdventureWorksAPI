


using System;
using System.Collections.Generic;
using System.Text;
using FluentNHibernate.Mapping;
using AdventureWorks.EntityClasses;

namespace AdventureWorks.Mappings.Production
{
    using EntityClasses.Production;

    /// <summary>Represents the mapping of the 'Production.UnitMeasure' entity, represented by the 'UnitMeasure' class.</summary>
	public partial class UnitMeasureMap : ClassMap<UnitMeasure>
    {
		/// <summary>Initializes a new instance of the <see cref="UnitMeasureMap"/> class.</summary>
		public UnitMeasureMap()
        {
			Table("[Production].[UnitMeasure]");
			OptimisticLock.None();
			LazyLoad();

			Id(x=>x.UnitMeasureCode)
				.Access.CamelCaseField(Prefix.Underscore)
				.Column("[UnitMeasureCode]")
				.GeneratedBy.Assigned();
			Map(x=>x.ModifiedDate).Column("[ModifiedDate]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.Name).Length(50).Column("[Name]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);

			HasMany(x=>x.BillOfMaterials)
				.Access.CamelCaseField(Prefix.Underscore)
				.Cascade.AllDeleteOrphan()
				.Fetch.Select()
				.AsSet()
				.Inverse()
				.LazyLoad()
				.KeyColumns.Add("[UnitMeasureCode]");
			HasMany(x=>x.Products)
				.Access.CamelCaseField(Prefix.Underscore)
				.Cascade.AllDeleteOrphan()
				.Fetch.Select()
				.AsSet()
				.Inverse()
				.LazyLoad()
				.KeyColumns.Add("[SizeUnitMeasureCode]");
			HasMany(x=>x.Products1)
				.Access.CamelCaseField(Prefix.Underscore)
				.Cascade.AllDeleteOrphan()
				.Fetch.Select()
				.AsSet()
				.Inverse()
				.LazyLoad()
				.KeyColumns.Add("[WeightUnitMeasureCode]");
			HasMany(x=>x.ProductVendors)
				.Access.CamelCaseField(Prefix.Underscore)
				.Cascade.AllDeleteOrphan()
				.Fetch.Select()
				.AsSet()
				.Inverse()
				.LazyLoad()
				.KeyColumns.Add("[UnitMeasureCode]");

			AdditionalMappingInfo();
		} 
				
		/// <summary>Partial method for adding additional mapping information in a partial class.</summary>
		partial void AdditionalMappingInfo();
	} 
}  
