


using System;
using System.Collections.Generic;
using System.Text;
using FluentNHibernate.Mapping;
using AdventureWorks.EntityClasses;

namespace AdventureWorks.Mappings.Sales
{
    using EntityClasses.Sales;

    /// <summary>Represents the mapping of the 'Sales.SalesReason' entity, represented by the 'SalesReason' class.</summary>
	public partial class SalesReasonMap : ClassMap<SalesReason>
    {
		/// <summary>Initializes a new instance of the <see cref="SalesReasonMap"/> class.</summary>
		public SalesReasonMap()
        {
			Table("[Sales].[SalesReason]");
			OptimisticLock.None();
			LazyLoad();

			Id(x=>x.SalesReasonId)
				.Access.CamelCaseField(Prefix.Underscore)
				.Column("[SalesReasonID]")
				.GeneratedBy.Identity();
			Map(x=>x.ModifiedDate).Column("[ModifiedDate]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.Name).Length(50).Column("[Name]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.ReasonType).Length(50).Column("[ReasonType]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);

			HasMany(x=>x.SalesOrderHeaderSalesReasons)
				.Access.CamelCaseField(Prefix.Underscore)
				.Cascade.AllDeleteOrphan()
				.Fetch.Select()
				.AsSet()
				.Inverse()
				.LazyLoad()
				.KeyColumns.Add("[SalesReasonID]");

			AdditionalMappingInfo();
		} 
				
		/// <summary>Partial method for adding additional mapping information in a partial class.</summary>
		partial void AdditionalMappingInfo();
	} 
}  
