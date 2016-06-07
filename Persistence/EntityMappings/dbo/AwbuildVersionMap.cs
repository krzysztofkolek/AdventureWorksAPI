namespace AdventureWorks.Mappings.dbo
{    using System;
    using System.Collections.Generic;
    using System.Text;
    using FluentNHibernate.Mapping;
    using AdventureWorks.EntityClasses;
    using EntityClasses.dbo;

    /// <summary>Represents the mapping of the 'AwbuildVersion' entity, represented by the 'AwbuildVersion' class.</summary>
	public partial class AwbuildVersionMap : ClassMap<AwbuildVersion>
    {
		/// <summary>Initializes a new instance of the <see cref="AwbuildVersionMap"/> class.</summary>
		public AwbuildVersionMap()
        {
			Table("[dbo].[AWBuildVersion]");
			OptimisticLock.None();
			LazyLoad();

			Id(x=>x.SystemInformationId)
				.Access.CamelCaseField(Prefix.Underscore)
				.Column("[SystemInformationID]")
				.GeneratedBy.Identity();
			Map(x=>x.DatabaseVersion).Length(25).Column("[Database Version]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.ModifiedDate).Column("[ModifiedDate]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.VersionDate).Column("[VersionDate]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);


			AdditionalMappingInfo();
		} 
				
		/// <summary>Partial method for adding additional mapping information in a partial class.</summary>
		partial void AdditionalMappingInfo();
	} 
}  
