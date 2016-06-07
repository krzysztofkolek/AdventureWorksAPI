


using System;
using System.Collections.Generic;
using System.Text;
using FluentNHibernate.Mapping;
using AdventureWorks.EntityClasses;

namespace AdventureWorks.Mappings.Sales
{
    using EntityClasses.Sales;

    /// <summary>Represents the mapping of the 'Sales.SalesOrderHeaderSalesReason' entity, represented by the 'SalesOrderHeaderSalesReason' class.</summary>
	public partial class SalesOrderHeaderSalesReasonMap : ClassMap<SalesOrderHeaderSalesReason>
    {
		/// <summary>Initializes a new instance of the <see cref="SalesOrderHeaderSalesReasonMap"/> class.</summary>
		public SalesOrderHeaderSalesReasonMap()
        {
			Table("[Sales].[SalesOrderHeaderSalesReason]");
			OptimisticLock.None();
			LazyLoad();

			CompositeId()
				.KeyReference(x => x.SalesOrderHeader, x => x.Access.CamelCaseField(Prefix.Underscore), "[SalesOrderID]")
				.KeyReference(x => x.SalesReason, x => x.Access.CamelCaseField(Prefix.Underscore), "[SalesReasonID]");
			Map(x=>x.ModifiedDate).Column("[ModifiedDate]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);


			AdditionalMappingInfo();
		} 
				
		/// <summary>Partial method for adding additional mapping information in a partial class.</summary>
		partial void AdditionalMappingInfo();
	} 
}  
