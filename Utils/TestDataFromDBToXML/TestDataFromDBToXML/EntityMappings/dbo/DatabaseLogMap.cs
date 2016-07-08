


namespace AdventureWorks.Mappings.dbo
{
    using EntityClasses.dbo;
    using FluentNHibernate.Mapping;

    /// <summary>Represents the mapping of the 'DatabaseLog' entity, represented by the 'DatabaseLog' class.</summary>
	public partial class DatabaseLogMap : ClassMap<DatabaseLog>
    {
		/// <summary>Initializes a new instance of the <see cref="DatabaseLogMap"/> class.</summary>
		public DatabaseLogMap()
        {
			Table("[dbo].[DatabaseLog]");
			OptimisticLock.None();
			LazyLoad();

			Id(x=>x.DatabaseLogId)
				.Access.CamelCaseField(Prefix.Underscore)
				.Column("[DatabaseLogID]")
				.GeneratedBy.Identity();
			Map(x=>x.DatabaseUser).Length(128).Column("[DatabaseUser]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.Event).Length(128).Column("[Event]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.Object).Length(128).Column("[Object]").Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.PostTime).Column("[PostTime]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.Schema).Length(128).Column("[Schema]").Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.Tsql).CustomType("StringClob").Column("[TSQL]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.XmlEvent).CustomType("StringClob").Column("[XmlEvent]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);


			AdditionalMappingInfo();
		} 
				
		/// <summary>Partial method for adding additional mapping information in a partial class.</summary>
		partial void AdditionalMappingInfo();
	} 
}  
