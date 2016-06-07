


using System;
using System.Collections.Generic;
using System.Text;
using FluentNHibernate.Mapping;
using AdventureWorks.EntityClasses;

namespace AdventureWorks.Mappings.Production
{
    using EntityClasses.Production;

    /// <summary>Represents the mapping of the 'Production.Document' entity, represented by the 'Document' class.</summary>
	public partial class DocumentMap : ClassMap<Document>
    {
		/// <summary>Initializes a new instance of the <see cref="DocumentMap"/> class.</summary>
		public DocumentMap()
        {
			Table("[Production].[Document]");
			OptimisticLock.None();
			LazyLoad();

			Id(x=>x.DocumentId)
				.Access.CamelCaseField(Prefix.Underscore)
				.Column("[DocumentID]")
				.GeneratedBy.Identity();
			Map(x=>x.ChangeNumber).Column("[ChangeNumber]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.DocumentsBytes).CustomType("BinaryBlob").Column("[Document]").Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.DocumentSummary).CustomType("StringClob").Column("[DocumentSummary]").Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.FileExtension).Length(8).Column("[FileExtension]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.FileName).Length(400).Column("[FileName]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.ModifiedDate).Column("[ModifiedDate]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.Revision).Length(5).Column("[Revision]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.Status).Column("[Status]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.Title).Length(50).Column("[Title]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);

			HasMany(x=>x.ProductDocuments)
				.Access.CamelCaseField(Prefix.Underscore)
				.Cascade.AllDeleteOrphan()
				.Fetch.Select()
				.AsSet()
				.Inverse()
				.LazyLoad()
				.KeyColumns.Add("[DocumentID]");

			AdditionalMappingInfo();
		} 
				
		/// <summary>Partial method for adding additional mapping information in a partial class.</summary>
		partial void AdditionalMappingInfo();
	} 
}  
