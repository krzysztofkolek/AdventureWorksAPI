namespace AdventureWorks.Mappings.Person.Production
{
    using EntityClasses.Person;
    using System;
    using System.Collections.Generic;
    using System.Text;
    using EntityClasses.Production;
    using FluentNHibernate.Mapping;
    using AdventureWorks.EntityClasses;

    /// <summary>Represents the mapping of the 'Production.Product' entity, represented by the 'Product' class.</summary>
	public partial class ProductMap : ClassMap<Product>
    {
		/// <summary>Initializes a new instance of the <see cref="ProductMap"/> class.</summary>
		public ProductMap()
        {
			Table("[Production].[Product]");
			OptimisticLock.None();
			LazyLoad();

			Id(x=>x.ProductId)
				.Access.CamelCaseField(Prefix.Underscore)
				.Column("[ProductID]")
				.GeneratedBy.Identity();
			Map(x=>x.Class).Length(2).Column("[Class]").Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.Color).Length(15).Column("[Color]").Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.DaysToManufacture).Column("[DaysToManufacture]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.DiscontinuedDate).Column("[DiscontinuedDate]").Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.FinishedGoodsFlag).Column("[FinishedGoodsFlag]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.ListPrice).Column("[ListPrice]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.MakeFlag).Column("[MakeFlag]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.ModifiedDate).Column("[ModifiedDate]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.Name).Length(50).Column("[Name]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.ProductLine).Length(2).Column("[ProductLine]").Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.ProductNumber).Length(25).Column("[ProductNumber]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.ReorderPoint).Column("[ReorderPoint]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.Rowguid).Column("[rowguid]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.SafetyStockLevel).Column("[SafetyStockLevel]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.SellEndDate).Column("[SellEndDate]").Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.SellStartDate).Column("[SellStartDate]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.Size).Length(5).Column("[Size]").Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.StandardCost).Column("[StandardCost]").Not.Nullable().Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.Style).Length(2).Column("[Style]").Access.CamelCaseField(Prefix.Underscore);
			Map(x=>x.Weight).Column("[Weight]").Access.CamelCaseField(Prefix.Underscore);

			HasMany(x=>x.BillOfMaterials)
				.Access.CamelCaseField(Prefix.Underscore)
				.Cascade.AllDeleteOrphan()
				.Fetch.Select()
				.AsSet()
				.Inverse()
				.LazyLoad()
				.KeyColumns.Add("[ComponentID]");
			HasMany(x=>x.BillOfMaterials1)
				.Access.CamelCaseField(Prefix.Underscore)
				.Cascade.AllDeleteOrphan()
				.Fetch.Select()
				.AsSet()
				.Inverse()
				.LazyLoad()
				.KeyColumns.Add("[ProductAssemblyID]");
			HasMany(x=>x.ProductCostHistories)
				.Access.CamelCaseField(Prefix.Underscore)
				.Cascade.AllDeleteOrphan()
				.Fetch.Select()
				.AsSet()
				.Inverse()
				.LazyLoad()
				.KeyColumns.Add("[ProductID]");
			HasMany(x=>x.ProductDocuments)
				.Access.CamelCaseField(Prefix.Underscore)
				.Cascade.AllDeleteOrphan()
				.Fetch.Select()
				.AsSet()
				.Inverse()
				.LazyLoad()
				.KeyColumns.Add("[ProductID]");
			HasMany(x=>x.ProductInventories)
				.Access.CamelCaseField(Prefix.Underscore)
				.Cascade.AllDeleteOrphan()
				.Fetch.Select()
				.AsSet()
				.Inverse()
				.LazyLoad()
				.KeyColumns.Add("[ProductID]");
			HasMany(x=>x.ProductListPriceHistories)
				.Access.CamelCaseField(Prefix.Underscore)
				.Cascade.AllDeleteOrphan()
				.Fetch.Select()
				.AsSet()
				.Inverse()
				.LazyLoad()
				.KeyColumns.Add("[ProductID]");
			References(x=>x.ProductModel)
				.Access.CamelCaseField(Prefix.Underscore)
				.Cascade.All()
				.Fetch.Select()
				.Columns("[ProductModelID]");
			HasMany(x=>x.ProductProductPhotos)
				.Access.CamelCaseField(Prefix.Underscore)
				.Cascade.AllDeleteOrphan()
				.Fetch.Select()
				.AsSet()
				.Inverse()
				.LazyLoad()
				.KeyColumns.Add("[ProductID]");
			HasMany(x=>x.ProductReviews)
				.Access.CamelCaseField(Prefix.Underscore)
				.Cascade.AllDeleteOrphan()
				.Fetch.Select()
				.AsSet()
				.Inverse()
				.LazyLoad()
				.KeyColumns.Add("[ProductID]");
			References(x=>x.ProductSubcategory)
				.Access.CamelCaseField(Prefix.Underscore)
				.Cascade.All()
				.Fetch.Select()
				.Columns("[ProductSubcategoryID]");
			HasMany(x=>x.ProductVendors)
				.Access.CamelCaseField(Prefix.Underscore)
				.Cascade.AllDeleteOrphan()
				.Fetch.Select()
				.AsSet()
				.Inverse()
				.LazyLoad()
				.KeyColumns.Add("[ProductID]");
			HasMany(x=>x.PurchaseOrderDetails)
				.Access.CamelCaseField(Prefix.Underscore)
				.Cascade.AllDeleteOrphan()
				.Fetch.Select()
				.AsSet()
				.Inverse()
				.LazyLoad()
				.KeyColumns.Add("[ProductID]");
			HasMany(x=>x.ShoppingCartItems)
				.Access.CamelCaseField(Prefix.Underscore)
				.Cascade.AllDeleteOrphan()
				.Fetch.Select()
				.AsSet()
				.Inverse()
				.LazyLoad()
				.KeyColumns.Add("[ProductID]");
			HasMany(x=>x.SpecialOfferProducts)
				.Access.CamelCaseField(Prefix.Underscore)
				.Cascade.AllDeleteOrphan()
				.Fetch.Select()
				.AsSet()
				.Inverse()
				.LazyLoad()
				.KeyColumns.Add("[ProductID]");
			HasMany(x=>x.TransactionHistories)
				.Access.CamelCaseField(Prefix.Underscore)
				.Cascade.AllDeleteOrphan()
				.Fetch.Select()
				.AsSet()
				.Inverse()
				.LazyLoad()
				.KeyColumns.Add("[ProductID]");
			References(x=>x.UnitMeasure)
				.Access.CamelCaseField(Prefix.Underscore)
				.Cascade.All()
				.Fetch.Select()
				.Columns("[SizeUnitMeasureCode]");
			References(x=>x.UnitMeasure1)
				.Access.CamelCaseField(Prefix.Underscore)
				.Cascade.All()
				.Fetch.Select()
				.Columns("[WeightUnitMeasureCode]");
			HasMany(x=>x.WorkOrders)
				.Access.CamelCaseField(Prefix.Underscore)
				.Cascade.AllDeleteOrphan()
				.Fetch.Select()
				.AsSet()
				.Inverse()
				.LazyLoad()
				.KeyColumns.Add("[ProductID]");

			AdditionalMappingInfo();
		} 
				
		/// <summary>Partial method for adding additional mapping information in a partial class.</summary>
		partial void AdditionalMappingInfo();
	} 
}  
