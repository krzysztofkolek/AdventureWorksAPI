


using System;
using System.Collections.Generic;
using System.Text;
using FluentNHibernate.Mapping;
using AdventureWorks.EntityClasses;

namespace AdventureWorks.Mappings.HumanResources
{
    using EntityClasses.HumanResources;

    /// <summary>Represents the mapping of the 'HumanResources.EmployeePayHistory' entity, represented by the 'EmployeePayHistory' class.</summary>
	public partial class EmployeePayHistoryMap : ClassMap<EmployeePayHistory>
    {
		/// <summary>Initializes a new instance of the <see cref="EmployeePayHistoryMap"/> class.</summary>
		public EmployeePayHistoryMap()
        {
			Table("[HumanResources].[EmployeePayHistory]");
			OptimisticLock.None();
			LazyLoad();

			CompositeId()
				.KeyReference(x => x.Employee, x => x.Access.CamelCaseField(Prefix.Underscore), "[EmployeeID]")
				.KeyProperty(x => x.RateChangeDate, x => x.Access.CamelCaseField(Prefix.Underscore).ColumnName("[RateChangeDate]"));
			Map(x=>x.ModifiedDate).Column("[ModifiedDate]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.PayFrequency).Column("[PayFrequency]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.Rate).Column("[Rate]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);


			AdditionalMappingInfo();
		} 
				
		/// <summary>Partial method for adding additional mapping information in a partial class.</summary>
		partial void AdditionalMappingInfo();
	} 
}  
