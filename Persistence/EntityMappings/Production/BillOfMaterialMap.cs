


using System;
using System.Collections.Generic;
using System.Text;
using FluentNHibernate.Mapping;
using AdventureWorks.EntityClasses;

namespace AdventureWorks.Mappings.Production
{
    using EntityClasses.Production;

    /// <summary>Represents the mapping of the 'Production.BillOfMaterial' entity, represented by the 'BillOfMaterial' class.</summary>
	public partial class BillOfMaterialMap : ClassMap<BillOfMaterial>
    {
		/// <summary>Initializes a new instance of the <see cref="BillOfMaterialMap"/> class.</summary>
		public BillOfMaterialMap()
        {
			Table("[Production].[BillOfMaterials]");
			OptimisticLock.None();
			LazyLoad();

			Id(x=>x.BillOfMaterialsId)
				.Access.CamelCaseField(Prefix.Underscore)
				.Column("[BillOfMaterialsID]")
				.GeneratedBy.Identity();
			Map(x=>x.Bomlevel).Column("[BOMLevel]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.EndDate).Column("[EndDate]").Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.ModifiedDate).Column("[ModifiedDate]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.PerAssemblyQty).Column("[PerAssemblyQty]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.StartDate).Column("[StartDate]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);

			References(x=>x.Product)
				.Access.CamelCaseField(Prefix.Underscore)
				.Cascade.All()
				.Fetch.Select()
				.Columns("[ComponentID]");
			References(x=>x.Product1)
				.Access.CamelCaseField(Prefix.Underscore)
				.Cascade.All()
				.Fetch.Select()
				.Columns("[ProductAssemblyID]");
			References(x=>x.UnitMeasure)
				.Access.CamelCaseField(Prefix.Underscore)
				.Cascade.All()
				.Fetch.Select()
				.Columns("[UnitMeasureCode]");

			AdditionalMappingInfo();
		} 
				
		/// <summary>Partial method for adding additional mapping information in a partial class.</summary>
		partial void AdditionalMappingInfo();
	} 
}  
