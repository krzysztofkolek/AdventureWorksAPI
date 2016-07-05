


using System;
using System.Collections.Generic;
using System.Text;
using FluentNHibernate.Mapping;
using AdventureWorks.EntityClasses;

namespace AdventureWorks.Mappings.Purchasing
{
    using EntityClasses.Purchasing;

    /// <summary>Represents the mapping of the 'Purchasing.ShipMethod' entity, represented by the 'ShipMethod' class.</summary>
	public partial class ShipMethodMap : ClassMap<ShipMethod>
    {
		/// <summary>Initializes a new instance of the <see cref="ShipMethodMap"/> class.</summary>
		public ShipMethodMap()
        {
			Table("[Purchasing].[ShipMethod]");
			OptimisticLock.None();
			LazyLoad();

			Id(x=>x.ShipMethodId)
				.Access.CamelCaseField(Prefix.Underscore)
				.Column("[ShipMethodID]")
				.GeneratedBy.Identity();
			Map(x=>x.ModifiedDate).Column("[ModifiedDate]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.Name).Length(50).Column("[Name]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.Rowguid).Column("[rowguid]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.ShipBase).Column("[ShipBase]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.ShipRate).Column("[ShipRate]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);

			HasMany(x=>x.PurchaseOrderHeaders)
				.Access.CamelCaseField(Prefix.Underscore)
				.Cascade.AllDeleteOrphan()
				.Fetch.Select()
				.AsSet()
				.Inverse()
				.LazyLoad()
				.KeyColumns.Add("[ShipMethodID]");
			HasMany(x=>x.SalesOrderHeaders)
				.Access.CamelCaseField(Prefix.Underscore)
				.Cascade.AllDeleteOrphan()
				.Fetch.Select()
				.AsSet()
				.Inverse()
				.LazyLoad()
				.KeyColumns.Add("[ShipMethodID]");

			AdditionalMappingInfo();
		} 
				
		/// <summary>Partial method for adding additional mapping information in a partial class.</summary>
		partial void AdditionalMappingInfo();
	} 
}  
