


using System;
using System.Collections.Generic;
using System.Text;
using FluentNHibernate.Mapping;
using AdventureWorks.EntityClasses;

namespace AdventureWorks.Mappings.Sales
{
    using EntityClasses.Sales;

    /// <summary>Represents the mapping of the 'Sales.SalesTerritoryHistory' entity, represented by the 'SalesTerritoryHistory' class.</summary>
	public partial class SalesTerritoryHistoryMap : ClassMap<SalesTerritoryHistory>
    {
		/// <summary>Initializes a new instance of the <see cref="SalesTerritoryHistoryMap"/> class.</summary>
		public SalesTerritoryHistoryMap()
        {
			Table("[Sales].[SalesTerritoryHistory]");
			OptimisticLock.None();
			LazyLoad();

			CompositeId()
				.KeyReference(x => x.SalesPerson, x => x.Access.CamelCaseField(Prefix.Underscore), "[SalesPersonID]")
				.KeyProperty(x => x.StartDate, x => x.Access.CamelCaseField(Prefix.Underscore).ColumnName("[StartDate]"))
				.KeyReference(x => x.SalesTerritory, x => x.Access.CamelCaseField(Prefix.Underscore), "[TerritoryID]");
			Map(x=>x.EndDate).Column("[EndDate]").Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.ModifiedDate).Column("[ModifiedDate]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.Rowguid).Column("[rowguid]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);


			AdditionalMappingInfo();
		} 
				
		/// <summary>Partial method for adding additional mapping information in a partial class.</summary>
		partial void AdditionalMappingInfo();
	} 
}  
