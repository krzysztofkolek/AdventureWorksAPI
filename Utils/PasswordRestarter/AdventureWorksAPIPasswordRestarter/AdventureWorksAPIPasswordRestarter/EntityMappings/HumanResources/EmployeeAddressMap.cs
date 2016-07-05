


using System;
using System.Collections.Generic;
using System.Text;
using FluentNHibernate.Mapping;
using AdventureWorks.EntityClasses;

namespace AdventureWorks.Mappings.HumanResources
{
    using EntityClasses.HumanResources;

    /// <summary>Represents the mapping of the 'HumanResources.EmployeeAddress' entity, represented by the 'EmployeeAddress' class.</summary>
	public partial class EmployeeAddressMap : ClassMap<EmployeeAddress>
    {
		/// <summary>Initializes a new instance of the <see cref="EmployeeAddressMap"/> class.</summary>
		public EmployeeAddressMap()
        {
			Table("[HumanResources].[EmployeeAddress]");
			OptimisticLock.None();
			LazyLoad();

			CompositeId()
				.KeyReference(x => x.Address, x => x.Access.CamelCaseField(Prefix.Underscore), "[AddressID]")
				.KeyReference(x => x.Employee, x => x.Access.CamelCaseField(Prefix.Underscore), "[EmployeeID]");
			Map(x=>x.ModifiedDate).Column("[ModifiedDate]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.Rowguid).Column("[rowguid]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);


			AdditionalMappingInfo();
		} 
				
		/// <summary>Partial method for adding additional mapping information in a partial class.</summary>
		partial void AdditionalMappingInfo();
	} 
}  
