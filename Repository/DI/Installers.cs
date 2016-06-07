namespace AdventureWorks.Repository.DI
{
    using Castle.MicroKernel.Registration;
    using dbo;
    using EntityClasses.dbo;
    using EntityClasses.HumanResources;
    using EntityClasses.Person;
    using EntityClasses.Production;
    using EntityClasses.Purchasing;
    using EntityClasses.Sales;
    using Main; 

    public class Installers : IWindsorInstaller
    {
        public void Install(Castle.Windsor.IWindsorContainer container, Castle.MicroKernel.SubSystems.Configuration.IConfigurationStore store)
        {
            container
                     .Register(Component.For<IRepository<AwbuildVersion>, IEditableRepository<AwbuildVersion>, IReadWriteRepository<AwbuildVersion>>().ImplementedBy<AwbuildVersionRepository<AwbuildVersion>>().LifestyleTransient())
                     .Register(Component.For<IRepository<DatabaseLog>, IEditableRepository<DatabaseLog>, IReadWriteRepository<DatabaseLog>>().ImplementedBy<DatabaseLogRepository<DatabaseLog>>().LifestyleTransient())
                     .Register(Component.For<IRepository<ErrorLog>, IEditableRepository<ErrorLog>, IReadWriteRepository<ErrorLog>>().ImplementedBy<ErrorLogRepository<ErrorLog>>().LifestyleTransient())


                     .Register(Component.For<IRepository<Department>, IEditableRepository<Department>, IReadWriteRepository<Department>>().ImplementedBy<DepartmentRepository<Department>>().LifestyleTransient())
                     .Register(Component.For<IRepository<Employee>, IEditableRepository<Employee>, IReadWriteRepository<Employee>>().ImplementedBy<EmployeeRepository<Employee>>().LifestyleTransient())
                     .Register(Component.For<IRepository<EmployeeAddress>, IEditableRepository<EmployeeAddress>, IReadWriteRepository<EmployeeAddress>>().ImplementedBy<EmployeeAddressRepository<EmployeeAddress>>().LifestyleTransient())
                     .Register(Component.For<IRepository<EmployeeDepartmentHistory>, IEditableRepository<EmployeeDepartmentHistory>, IReadWriteRepository<EmployeeDepartmentHistory>>().ImplementedBy<EmployeeDepartmentHistoryRepository<EmployeeDepartmentHistory>>().LifestyleTransient())
                     .Register(Component.For<IRepository<EmployeePayHistory>, IEditableRepository<EmployeePayHistory>, IReadWriteRepository<EmployeePayHistory>>().ImplementedBy<EmployeePayHistoryRepository<EmployeePayHistory>>().LifestyleTransient())
                     .Register(Component.For<IRepository<JobCandidate>, IEditableRepository<JobCandidate>, IReadWriteRepository<JobCandidate>>().ImplementedBy<JobCandidateRepository<JobCandidate>>().LifestyleTransient())
                     .Register(Component.For<IRepository<Shift>, IEditableRepository<Shift>, IReadWriteRepository<Shift>>().ImplementedBy<ShiftRepository<Shift>>().LifestyleTransient())


                     .Register(Component.For<IRepository<Address>, IEditableRepository<Address>, IReadWriteRepository<Address>>().ImplementedBy<AddressRepository<Address>>().LifestyleTransient())
                     .Register(Component.For<IRepository<AddressType>, IEditableRepository<AddressType>, IReadWriteRepository<AddressType>>().ImplementedBy<AddressTypeRepository<AddressType>>().LifestyleTransient())
                     .Register(Component.For<IRepository<Contact>, IEditableRepository<Contact>, IReadWriteRepository<Contact>>().ImplementedBy<ContactRepository<Contact>>().LifestyleTransient())
                     .Register(Component.For<IRepository<ContactType>, IEditableRepository<ContactType>, IReadWriteRepository<ContactType>>().ImplementedBy<ContactTypeRepository<ContactType>>().LifestyleTransient())
                     .Register(Component.For<IRepository<CountryRegion>, IEditableRepository<CountryRegion>, IReadWriteRepository<CountryRegion>>().ImplementedBy<CountryRegionRepository<CountryRegion>>().LifestyleTransient())
                     .Register(Component.For<IRepository<StateProvince>, IEditableRepository<StateProvince>, IReadWriteRepository<StateProvince>>().ImplementedBy<StateProvinceRepository<StateProvince>>().LifestyleTransient())


                     .Register(Component.For<IRepository<BillOfMaterial>, IEditableRepository<BillOfMaterial>, IReadWriteRepository<BillOfMaterial>>().ImplementedBy<BillOfMaterialRepository<BillOfMaterial>>().LifestyleTransient())
                     .Register(Component.For<IRepository<Culture>, IEditableRepository<Culture>, IReadWriteRepository<Culture>>().ImplementedBy<CultureRepository<Culture>>().LifestyleTransient())
                     .Register(Component.For<IRepository<Document>, IEditableRepository<Document>, IReadWriteRepository<Document>>().ImplementedBy<DocumentRepository<Document>>().LifestyleTransient())
                     .Register(Component.For<IRepository<Illustration>, IEditableRepository<Illustration>, IReadWriteRepository<Illustration>>().ImplementedBy<IllustrationRepository<Illustration>>().LifestyleTransient())
                     .Register(Component.For<IRepository<Location>, IEditableRepository<Location>, IReadWriteRepository<Location>>().ImplementedBy<LocationRepository<Location>>().LifestyleTransient())
                     .Register(Component.For<IRepository<Product>, IEditableRepository<Product>, IReadWriteRepository<Product>>().ImplementedBy<ProductRepository<Product>>().LifestyleTransient())
                     .Register(Component.For<IRepository<ProductCategory>, IEditableRepository<ProductCategory>, IReadWriteRepository<ProductCategory>>().ImplementedBy<ProductCategoryRepository<ProductCategory>>().LifestyleTransient())
                     .Register(Component.For<IRepository<ProductCostHistory>, IEditableRepository<ProductCostHistory>, IReadWriteRepository<ProductCostHistory>>().ImplementedBy<ProductCostHistoryRepository<ProductCostHistory>>().LifestyleTransient())
                     .Register(Component.For<IRepository<ProductDescription>, IEditableRepository<ProductDescription>, IReadWriteRepository<ProductDescription>>().ImplementedBy<ProductDescriptionRepository<ProductDescription>>().LifestyleTransient())
                     .Register(Component.For<IRepository<ProductDocument>, IEditableRepository<ProductDocument>, IReadWriteRepository<ProductDocument>>().ImplementedBy<ProductDocumentRepository<ProductDocument>>().LifestyleTransient())
                     .Register(Component.For<IRepository<ProductInventory>, IEditableRepository<ProductInventory>, IReadWriteRepository<ProductInventory>>().ImplementedBy<ProductInventoryRepository<ProductInventory>>().LifestyleTransient())
                     .Register(Component.For<IRepository<ProductListPriceHistory>, IEditableRepository<ProductListPriceHistory>, IReadWriteRepository<ProductListPriceHistory>>().ImplementedBy<ProductListPriceHistoryRepository<ProductListPriceHistory>>().LifestyleTransient())
                     .Register(Component.For<IRepository<ProductModel>, IEditableRepository<ProductModel>, IReadWriteRepository<ProductModel>>().ImplementedBy<ProductModelRepository<ProductModel>>().LifestyleTransient())
                     .Register(Component.For<IRepository<ProductModelIllustration>, IEditableRepository<ProductModelIllustration>, IReadWriteRepository<ProductModelIllustration>>().ImplementedBy<ProductModelIllustrationRepository<ProductModelIllustration>>().LifestyleTransient())
                     .Register(Component.For<IRepository<ProductModelProductDescriptionCulture>, IEditableRepository<ProductModelProductDescriptionCulture>, IReadWriteRepository<ProductModelProductDescriptionCulture>>().ImplementedBy<ProductModelProductDescriptionCultureRepository<ProductModelProductDescriptionCulture>>().LifestyleTransient())
                     .Register(Component.For<IRepository<ProductPhoto>, IEditableRepository<ProductPhoto>, IReadWriteRepository<ProductPhoto>>().ImplementedBy<ProductPhotoRepository<ProductPhoto>>().LifestyleTransient())
                     .Register(Component.For<IRepository<ProductProductPhoto>, IEditableRepository<ProductProductPhoto>, IReadWriteRepository<ProductProductPhoto>>().ImplementedBy<ProductProductPhotoRepository<ProductProductPhoto>>().LifestyleTransient())
                     .Register(Component.For<IRepository<ProductReview>, IEditableRepository<ProductReview>, IReadWriteRepository<ProductReview>>().ImplementedBy<ProductReviewRepository<ProductReview>>().LifestyleTransient())
                     .Register(Component.For<IRepository<ProductSubcategory>, IEditableRepository<ProductSubcategory>, IReadWriteRepository<ProductSubcategory>>().ImplementedBy<ProductSubcategoryRepository<ProductSubcategory>>().LifestyleTransient())
                     .Register(Component.For<IRepository<ScrapReason>, IEditableRepository<ScrapReason>, IReadWriteRepository<ScrapReason>>().ImplementedBy<ScrapReasonRepository<ScrapReason>>().LifestyleTransient())
                     .Register(Component.For<IRepository<TransactionHistory>, IEditableRepository<TransactionHistory>, IReadWriteRepository<TransactionHistory>>().ImplementedBy<TransactionHistoryRepository<TransactionHistory>>().LifestyleTransient())
                     .Register(Component.For<IRepository<TransactionHistoryArchive>, IEditableRepository<TransactionHistoryArchive>, IReadWriteRepository<TransactionHistoryArchive>>().ImplementedBy<TransactionHistoryArchiveRepository<TransactionHistoryArchive>>().LifestyleTransient())
                     .Register(Component.For<IRepository<UnitMeasure>, IEditableRepository<UnitMeasure>, IReadWriteRepository<UnitMeasure>>().ImplementedBy<UnitMeasureRepository<UnitMeasure>>().LifestyleTransient())
                     .Register(Component.For<IRepository<WorkOrder>, IEditableRepository<WorkOrder>, IReadWriteRepository<WorkOrder>>().ImplementedBy<WorkOrderRepository<WorkOrder>>().LifestyleTransient())
                     .Register(Component.For<IRepository<WorkOrderRouting>, IEditableRepository<WorkOrderRouting>, IReadWriteRepository<WorkOrderRouting>>().ImplementedBy<WorkOrderRoutingRepository<WorkOrderRouting>>().LifestyleTransient())


                     .Register(Component.For<IRepository<ProductVendor>, IEditableRepository<ProductVendor>, IReadWriteRepository<ProductVendor>>().ImplementedBy<ProductVendorRepository<ProductVendor>>().LifestyleTransient())
                     .Register(Component.For<IRepository<PurchaseOrderDetail>, IEditableRepository<PurchaseOrderDetail>, IReadWriteRepository<PurchaseOrderDetail>>().ImplementedBy<PurchaseOrderDetailRepository<PurchaseOrderDetail>>().LifestyleTransient())
                     .Register(Component.For<IRepository<PurchaseOrderHeader>, IEditableRepository<PurchaseOrderHeader>, IReadWriteRepository<PurchaseOrderHeader>>().ImplementedBy<PurchaseOrderHeaderRepository<PurchaseOrderHeader>>().LifestyleTransient())
                     .Register(Component.For<IRepository<ShipMethod>, IEditableRepository<ShipMethod>, IReadWriteRepository<ShipMethod>>().ImplementedBy<ShipMethodRepository<ShipMethod>>().LifestyleTransient())
                     .Register(Component.For<IRepository<Vendor>, IEditableRepository<Vendor>, IReadWriteRepository<Vendor>>().ImplementedBy<VendorRepository<Vendor>>().LifestyleTransient())
                     .Register(Component.For<IRepository<VendorAddress>, IEditableRepository<VendorAddress>, IReadWriteRepository<VendorAddress>>().ImplementedBy<VendorAddressRepository<VendorAddress>>().LifestyleTransient())
                     .Register(Component.For<IRepository<VendorContact>, IEditableRepository<VendorContact>, IReadWriteRepository<VendorContact>>().ImplementedBy<VendorContactRepository<VendorContact>>().LifestyleTransient())


                     .Register(Component.For<IRepository<ContactCreditCard>, IEditableRepository<ContactCreditCard>, IReadWriteRepository<ContactCreditCard>>().ImplementedBy<ContactCreditCardRepository<ContactCreditCard>>().LifestyleTransient())
                     .Register(Component.For<IRepository<CountryRegionCurrency>, IEditableRepository<CountryRegionCurrency>, IReadWriteRepository<CountryRegionCurrency>>().ImplementedBy<CountryRegionCurrencyRepository<CountryRegionCurrency>>().LifestyleTransient())
                     .Register(Component.For<IRepository<CreditCard>, IEditableRepository<CreditCard>, IReadWriteRepository<CreditCard>>().ImplementedBy<CreditCardRepository<CreditCard>>().LifestyleTransient())
                     .Register(Component.For<IRepository<Currency>, IEditableRepository<Currency>, IReadWriteRepository<Currency>>().ImplementedBy<CurrencyRepository<Currency>>().LifestyleTransient())
                     .Register(Component.For<IRepository<CurrencyRate>, IEditableRepository<CurrencyRate>, IReadWriteRepository<CurrencyRate>>().ImplementedBy<CurrencyRateRepository<CurrencyRate>>().LifestyleTransient())
                     .Register(Component.For<IRepository<Customer>, IEditableRepository<Customer>, IReadWriteRepository<Customer>>().ImplementedBy<CustomerRepository<Customer>>().LifestyleTransient())
                     .Register(Component.For<IRepository<CustomerAddress>, IEditableRepository<CustomerAddress>, IReadWriteRepository<CustomerAddress>>().ImplementedBy<CustomerAddressRepository<CustomerAddress>>().LifestyleTransient())
                     .Register(Component.For<IRepository<Individual>, IEditableRepository<Individual>, IReadWriteRepository<Individual>>().ImplementedBy<IndividualRepository<Individual>>().LifestyleTransient())
                     .Register(Component.For<IRepository<SalesOrderDetail>, IEditableRepository<SalesOrderDetail>, IReadWriteRepository<SalesOrderDetail>>().ImplementedBy<SalesOrderDetailRepository<SalesOrderDetail>>().LifestyleTransient())
                     .Register(Component.For<IRepository<SalesOrderHeader>, IEditableRepository<SalesOrderHeader>, IReadWriteRepository<SalesOrderHeader>>().ImplementedBy<SalesOrderHeaderRepository<SalesOrderHeader>>().LifestyleTransient())
                     .Register(Component.For<IRepository<SalesOrderHeaderSalesReason>, IEditableRepository<SalesOrderHeaderSalesReason>, IReadWriteRepository<SalesOrderHeaderSalesReason>>().ImplementedBy<SalesOrderHeaderSalesReasonRepository<SalesOrderHeaderSalesReason>>().LifestyleTransient())
                     .Register(Component.For<IRepository<SalesPerson>, IEditableRepository<SalesPerson>, IReadWriteRepository<SalesPerson>>().ImplementedBy<SalesPersonRepository<SalesPerson>>().LifestyleTransient())
                     .Register(Component.For<IRepository<SalesPersonQuotaHistory>, IEditableRepository<SalesPersonQuotaHistory>, IReadWriteRepository<SalesPersonQuotaHistory>>().ImplementedBy<SalesPersonQuotaHistoryRepository<SalesPersonQuotaHistory>>().LifestyleTransient())
                     .Register(Component.For<IRepository<SalesReason>, IEditableRepository<SalesReason>, IReadWriteRepository<SalesReason>>().ImplementedBy<SalesReasonRepository<SalesReason>>().LifestyleTransient())
                     .Register(Component.For<IRepository<SalesTaxRate>, IEditableRepository<SalesTaxRate>, IReadWriteRepository<SalesTaxRate>>().ImplementedBy<SalesTaxRateRepository<SalesTaxRate>>().LifestyleTransient())
                     .Register(Component.For<IRepository<SalesTerritory>, IEditableRepository<SalesTerritory>, IReadWriteRepository<SalesTerritory>>().ImplementedBy<SalesTerritoryRepository<SalesTerritory>>().LifestyleTransient())
                     .Register(Component.For<IRepository<SalesTerritoryHistory>, IEditableRepository<SalesTerritoryHistory>, IReadWriteRepository<SalesTerritoryHistory>>().ImplementedBy<SalesTerritoryHistoryRepository<SalesTerritoryHistory>>().LifestyleTransient())
                     .Register(Component.For<IRepository<ShoppingCartItem>, IEditableRepository<ShoppingCartItem>, IReadWriteRepository<ShoppingCartItem>>().ImplementedBy<ShoppingCartItemRepository<ShoppingCartItem>>().LifestyleTransient())
                     .Register(Component.For<IRepository<SpecialOffer>, IEditableRepository<SpecialOffer>, IReadWriteRepository<SpecialOffer>>().ImplementedBy<SpecialOfferRepository<SpecialOffer>>().LifestyleTransient())
                     .Register(Component.For<IRepository<SpecialOfferProduct>, IEditableRepository<SpecialOfferProduct>, IReadWriteRepository<SpecialOfferProduct>>().ImplementedBy<SpecialOfferProductRepository<SpecialOfferProduct>>().LifestyleTransient())
                     .Register(Component.For<IRepository<Store>, IEditableRepository<Store>, IReadWriteRepository<Store>>().ImplementedBy<StoreRepository<Store>>().LifestyleTransient())
                     .Register(Component.For<IRepository<StoreContact>, IEditableRepository<StoreContact>, IReadWriteRepository<StoreContact>>().ImplementedBy<StoreContactRepository<StoreContact>>().LifestyleTransient());
        }
    }
}
