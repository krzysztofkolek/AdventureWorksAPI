


using System;
using System.Collections.Generic;
using System.Text;
using FluentNHibernate.Mapping;
using AdventureWorks.EntityClasses;

namespace AdventureWorks.Mappings.HumanResources
{
    using EntityClasses.HumanResources;

    /// <summary>Represents the mapping of the 'HumanResources.EmployeeDepartmentHistory' entity, represented by the 'EmployeeDepartmentHistory' class.</summary>
	public partial class EmployeeDepartmentHistoryMap : ClassMap<EmployeeDepartmentHistory>
    {
		/// <summary>Initializes a new instance of the <see cref="EmployeeDepartmentHistoryMap"/> class.</summary>
		public EmployeeDepartmentHistoryMap()
        {
			Table("[HumanResources].[EmployeeDepartmentHistory]");
			OptimisticLock.None();
			LazyLoad();

			CompositeId()
				.KeyReference(x => x.Department, x => x.Access.CamelCaseField(Prefix.Underscore), "[DepartmentID]")
				.KeyReference(x => x.Employee, x => x.Access.CamelCaseField(Prefix.Underscore), "[EmployeeID]")
				.KeyReference(x => x.Shift, x => x.Access.CamelCaseField(Prefix.Underscore), "[ShiftID]")
				.KeyProperty(x => x.StartDate, x => x.Access.CamelCaseField(Prefix.Underscore).ColumnName("[StartDate]"));
			Map(x=>x.EndDate).Column("[EndDate]").Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.ModifiedDate).Column("[ModifiedDate]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);


			AdditionalMappingInfo();
		} 
				
		/// <summary>Partial method for adding additional mapping information in a partial class.</summary>
		partial void AdditionalMappingInfo();
	} 
}  
