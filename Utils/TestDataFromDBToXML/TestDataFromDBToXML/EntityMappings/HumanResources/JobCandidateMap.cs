


using System;
using System.Collections.Generic;
using System.Text;
using FluentNHibernate.Mapping;
using AdventureWorks.EntityClasses;

namespace AdventureWorks.Mappings.HumanResources
{
    using EntityClasses.HumanResources;

    /// <summary>Represents the mapping of the 'HumanResources.JobCandidate' entity, represented by the 'JobCandidate' class.</summary>
	public partial class JobCandidateMap : ClassMap<JobCandidate>
    {
		/// <summary>Initializes a new instance of the <see cref="JobCandidateMap"/> class.</summary>
		public JobCandidateMap()
        {
			Table("[HumanResources].[JobCandidate]");
			OptimisticLock.None();
			LazyLoad();

			Id(x=>x.JobCandidateId)
				.Access.CamelCaseField(Prefix.Underscore)
				.Column("[JobCandidateID]")
				.GeneratedBy.Identity();
			Map(x=>x.ModifiedDate).Column("[ModifiedDate]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.Resume).CustomType("StringClob").Column("[Resume]").Access.CamelCaseField(Prefix.Underscore);

			References(x=>x.Employee)
				.Access.CamelCaseField(Prefix.Underscore)
				.Cascade.All()
				.Fetch.Select()
				.Columns("[EmployeeID]");

			AdditionalMappingInfo();
		} 
				
		/// <summary>Partial method for adding additional mapping information in a partial class.</summary>
		partial void AdditionalMappingInfo();
	} 
}  
