namespace AdventureWorks.UOW.Sales
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using EntityClasses.HumanResources;
    using EntityClasses.Production;
    using EntityClasses.Purchasing;
    using Main;
    using Model.Sales;
    using Repository.dbo;
    using Repository.HumanResources;

    public class GetProductsSoldByPersonUOW : BaseUOW<GetProductsSoldByPersonModel>
    {
        public GetProductsSoldByPersonUOW(EmployeeRepository<Employee> employeeRepository,
            PurchaseOrderHeaderRepository<PurchaseOrderHeader> purchaseOrderHeaderRepository)
        {
            _employeeRepository = employeeRepository;
            _purchaseOrderHeaderRepository = purchaseOrderHeaderRepository;
        }

        private String _login { get; set; }

        private EmployeeRepository<Employee> _employeeRepository { get; set; }
        private PurchaseOrderHeaderRepository<PurchaseOrderHeader> _purchaseOrderHeaderRepository { get; set; }


        public GetProductsSoldByPersonUOW SetEmployeeLogin(String login)
        {
            _login = login;
            return this;
        }

        public override GetProductsSoldByPersonModel GetResult()
        {
            Employee employee =
                _employeeRepository.SearchFor(x => x.Contact.EmailAddress.Equals(_login)).FirstOrDefault();
            if (employee != null)
            {
                string employeeLogin = employee.Contact.EmailAddress;

                List<IEnumerable<Product>> dbProducts =
                    _purchaseOrderHeaderRepository.SearchFor(
                        x => x.Employee.SalesPerson.Employee.Contact.Equals(employeeLogin))
                        .Select(x => x.PurchaseOrderDetails.Select(y => y.Product)).ToList();

                var products = new Dictionary<string, int>();
                foreach (Product dbProduct in dbProducts)
                {
                    if (products.ContainsKey(dbProduct.Name))
                    {
                        products[dbProduct.Name] ++;
                    }
                    else
                    {
                        products.Add(dbProduct.Name, 1);
                    }
                }

                var model = new GetProductsSoldByPersonModel
                {
                    EmployeeName = "",
                    Products = products.Select(x => new GetProductsSoldByPersonItemModel
                    {
                        ProductName = x.Key,
                        ProductSoldItemsCount = x.Value
                    }).ToList()
                };
            }
            return new GetProductsSoldByPersonModel();
        }
    }
}