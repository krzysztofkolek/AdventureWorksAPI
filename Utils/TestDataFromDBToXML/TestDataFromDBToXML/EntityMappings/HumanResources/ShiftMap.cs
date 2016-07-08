


using System;
using System.Collections.Generic;
using System.Text;
using FluentNHibernate.Mapping;
using AdventureWorks.EntityClasses;

namespace AdventureWorks.Mappings.HumanResources
{
    using EntityClasses.HumanResources;

    /// <summary>Represents the mapping of the 'HumanResources.Shift' entity, represented by the 'Shift' class.</summary>
	public partial class ShiftMap : ClassMap<Shift>
    {
		/// <summary>Initializes a new instance of the <see cref="ShiftMap"/> class.</summary>
		public ShiftMap()
        {
			Table("[HumanResources].[Shift]");
			OptimisticLock.None();
			LazyLoad();

			Id(x=>x.ShiftId)
				.Access.CamelCaseField(Prefix.Underscore)
				.Column("[ShiftID]")
				.GeneratedBy.Identity();
			Map(x=>x.EndTime).Column("[EndTime]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.ModifiedDate).Column("[ModifiedDate]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.Name).Length(50).Column("[Name]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.StartTime).Column("[StartTime]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);

			HasMany(x=>x.EmployeeDepartmentHistories)
				.Access.CamelCaseField(Prefix.Underscore)
				.Cascade.AllDeleteOrphan()
				.Fetch.Select()
				.AsSet()
				.Inverse()
				.LazyLoad()
				.KeyColumns.Add("[ShiftID]");

			AdditionalMappingInfo();
		} 
				
		/// <summary>Partial method for adding additional mapping information in a partial class.</summary>
		partial void AdditionalMappingInfo();
	} 
}  
