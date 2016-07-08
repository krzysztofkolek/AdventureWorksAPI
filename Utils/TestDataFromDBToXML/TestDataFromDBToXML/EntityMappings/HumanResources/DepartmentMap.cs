


using System;
using System.Collections.Generic;
using System.Text;
using FluentNHibernate.Mapping;
using AdventureWorks.EntityClasses;

namespace AdventureWorks.Mappings.HumanResources
{
    using EntityClasses.HumanResources;

    /// <summary>Represents the mapping of the 'HumanResources.Department' entity, represented by the 'Department' class.</summary>
	public partial class DepartmentMap : ClassMap<Department>
    {
		/// <summary>Initializes a new instance of the <see cref="DepartmentMap"/> class.</summary>
		public DepartmentMap()
        {
			Table("[HumanResources].[Department]");
			OptimisticLock.None();
			LazyLoad();

			Id(x=>x.DepartmentId)
				.Access.CamelCaseField(Prefix.Underscore)
				.Column("[DepartmentID]")
				.GeneratedBy.Identity();
			Map(x=>x.GroupName).Length(50).Column("[GroupName]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.ModifiedDate).Column("[ModifiedDate]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.Name).Length(50).Column("[Name]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);

			HasMany(x=>x.EmployeeDepartmentHistories)
				.Access.CamelCaseField(Prefix.Underscore)
				.Cascade.AllDeleteOrphan()
				.Fetch.Select()
				.AsSet()
				.Inverse()
				.LazyLoad()
				.KeyColumns.Add("[DepartmentID]");

			AdditionalMappingInfo();
		} 
				
		/// <summary>Partial method for adding additional mapping information in a partial class.</summary>
		partial void AdditionalMappingInfo();
	} 
}  
