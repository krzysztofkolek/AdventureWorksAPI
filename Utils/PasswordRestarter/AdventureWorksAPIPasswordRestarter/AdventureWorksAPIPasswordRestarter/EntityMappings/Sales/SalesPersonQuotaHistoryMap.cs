


using System;
using System.Collections.Generic;
using System.Text;
using FluentNHibernate.Mapping;
using AdventureWorks.EntityClasses;

namespace AdventureWorks.Mappings.Sales
{
    using EntityClasses.Sales;

    /// <summary>Represents the mapping of the 'Sales.SalesPersonQuotaHistory' entity, represented by the 'SalesPersonQuotaHistory' class.</summary>
	public partial class SalesPersonQuotaHistoryMap : ClassMap<SalesPersonQuotaHistory>
    {
		/// <summary>Initializes a new instance of the <see cref="SalesPersonQuotaHistoryMap"/> class.</summary>
		public SalesPersonQuotaHistoryMap()
        {
			Table("[Sales].[SalesPersonQuotaHistory]");
			OptimisticLock.None();
			LazyLoad();

			CompositeId()
				.KeyProperty(x => x.QuotaDate, x => x.Access.CamelCaseField(Prefix.Underscore).ColumnName("[QuotaDate]"))
				.KeyReference(x => x.SalesPerson, x => x.Access.CamelCaseField(Prefix.Underscore), "[SalesPersonID]");
			Map(x=>x.ModifiedDate).Column("[ModifiedDate]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.Rowguid).Column("[rowguid]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.SalesQuota).Column("[SalesQuota]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);


			AdditionalMappingInfo();
		} 
				
		/// <summary>Partial method for adding additional mapping information in a partial class.</summary>
		partial void AdditionalMappingInfo();
	} 
}  
