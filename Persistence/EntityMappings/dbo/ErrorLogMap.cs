namespace AdventureWorks.Mappings.dbo
{
    using EntityClasses.dbo;
    using FluentNHibernate.Mapping;

    /// <summary>Represents the mapping of the 'ErrorLog' entity, represented by the 'ErrorLog' class.</summary>
	public partial class ErrorLogMap : ClassMap<ErrorLog>
    {
		/// <summary>Initializes a new instance of the <see cref="ErrorLogMap"/> class.</summary>
		public ErrorLogMap()
        {
			Table("[dbo].[ErrorLog]");
			OptimisticLock.None();
			LazyLoad();

			Id(x=>x.ErrorLogId)
				.Access.CamelCaseField(Prefix.Underscore)
				.Column("[ErrorLogID]")
				.GeneratedBy.Identity();
			Map(x=>x.ErrorLine).Column("[ErrorLine]").Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.ErrorMessage).Column("[ErrorMessage]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.ErrorNumber).Column("[ErrorNumber]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.ErrorProcedure).Length(126).Column("[ErrorProcedure]").Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.ErrorSeverity).Column("[ErrorSeverity]").Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.ErrorState).Column("[ErrorState]").Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.ErrorTime).Column("[ErrorTime]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.UserName).Length(128).Column("[UserName]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);


			AdditionalMappingInfo();
		} 
				
		/// <summary>Partial method for adding additional mapping information in a partial class.</summary>
		partial void AdditionalMappingInfo();
	} 
}  
