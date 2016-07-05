


using System;
using System.Collections.Generic;
using System.Text;
using FluentNHibernate.Mapping;
using AdventureWorks.EntityClasses;

namespace AdventureWorks.Mappings.HumanResources
{
    using EntityClasses.HumanResources;

    /// <summary>Represents the mapping of the 'HumanResources.Employee' entity, represented by the 'Employee' class.</summary>
	public partial class EmployeeMap : ClassMap<Employee>
    {
		/// <summary>Initializes a new instance of the <see cref="EmployeeMap"/> class.</summary>
		public EmployeeMap()
        {
			Table("[HumanResources].[Employee]");
			OptimisticLock.None();
			LazyLoad();

			Id(x=>x.EmployeeId)
				.Access.CamelCaseField(Prefix.Underscore)
				.Column("[EmployeeID]")
				.GeneratedBy.Identity();
			Map(x=>x.BirthDate).Column("[BirthDate]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.CurrentFlag).Column("[CurrentFlag]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.Gender).Length(1).Column("[Gender]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.HireDate).Column("[HireDate]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.LoginId).Length(256).Column("[LoginID]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.MaritalStatus).Length(1).Column("[MaritalStatus]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.ModifiedDate).Column("[ModifiedDate]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.NationalIdnumber).Length(15).Column("[NationalIDNumber]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.Rowguid).Column("[rowguid]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.SalariedFlag).Column("[SalariedFlag]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.SickLeaveHours).Column("[SickLeaveHours]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.Title).Length(50).Column("[Title]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.VacationHours).Column("[VacationHours]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);

			References(x=>x.Contact)
				.Access.CamelCaseField(Prefix.Underscore)
				.Cascade.All()
				.Fetch.Select()
				.Columns("[ContactID]");
			HasMany(x=>x.EmployeeAddresses)
				.Access.CamelCaseField(Prefix.Underscore)
				.Cascade.AllDeleteOrphan()
				.Fetch.Select()
				.AsSet()
				.Inverse()
				.LazyLoad()
				.KeyColumns.Add("[EmployeeID]");
			HasMany(x=>x.EmployeeDepartmentHistories)
				.Access.CamelCaseField(Prefix.Underscore)
				.Cascade.AllDeleteOrphan()
				.Fetch.Select()
				.AsSet()
				.Inverse()
				.LazyLoad()
				.KeyColumns.Add("[EmployeeID]");
			References(x=>x.EmployeeNav)
				.Access.CamelCaseField(Prefix.Underscore)
				.Cascade.All()
				.Fetch.Select()
				.Columns("[ManagerID]");
			HasMany(x=>x.EmployeePayHistories)
				.Access.CamelCaseField(Prefix.Underscore)
				.Cascade.AllDeleteOrphan()
				.Fetch.Select()
				.AsSet()
				.Inverse()
				.LazyLoad()
				.KeyColumns.Add("[EmployeeID]");
			HasMany(x=>x.Employees)
				.Access.CamelCaseField(Prefix.Underscore)
				.Cascade.AllDeleteOrphan()
				.Fetch.Select()
				.AsSet()
				.Inverse()
				.LazyLoad()
				.KeyColumns.Add("[ManagerID]");
			HasMany(x=>x.JobCandidates)
				.Access.CamelCaseField(Prefix.Underscore)
				.Cascade.AllDeleteOrphan()
				.Fetch.Select()
				.AsSet()
				.Inverse()
				.LazyLoad()
				.KeyColumns.Add("[EmployeeID]");
			HasMany(x=>x.PurchaseOrderHeaders)
				.Access.CamelCaseField(Prefix.Underscore)
				.Cascade.AllDeleteOrphan()
				.Fetch.Select()
				.AsSet()
				.Inverse()
				.LazyLoad()
				.KeyColumns.Add("[EmployeeID]");
			HasOne(x=>x.SalesPerson)
				.Access.CamelCaseField(Prefix.Underscore)
				.Cascade.All()
				.Fetch.Select();

			AdditionalMappingInfo();
		} 
				
		/// <summary>Partial method for adding additional mapping information in a partial class.</summary>
		partial void AdditionalMappingInfo();
	} 
}  
