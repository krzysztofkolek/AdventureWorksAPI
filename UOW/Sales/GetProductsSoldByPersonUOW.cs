namespace AdventureWorks.UOW.Sales
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using EntityClasses.HumanResources;
    using EntityClasses.Production;
    using EntityClasses.Purchasing;
    using EntityClasses.Sales;
    using Main;
    using Model.Sales;
    using Repository.dbo;

    public class GetProductsSoldByPersonUOW : BaseUOW<GetProductsSoldByPersonModel>
    {
        private String _login { get; set; }

        private EmployeeRepository<Employee> _employeeRepository { get; set; } 
        private PurchaseOrderHeaderRepository<PurchaseOrderHeader> _purchaseOrderHeaderRepository { get; set; }


        public GetProductsSoldByPersonUOW(EmployeeRepository<Employee> employeeRepository, PurchaseOrderHeaderRepository<PurchaseOrderHeader> purchaseOrderHeaderRepository)
        {
            _employeeRepository = employeeRepository;
            _purchaseOrderHeaderRepository = purchaseOrderHeaderRepository;
        }

        public GetProductsSoldByPersonUOW SetEmployeeLogin(String login)
        {
            _login = login;
            return this;
        }

        public override GetProductsSoldByPersonModel GetResult()
        {
            var employee = _employeeRepository.SearchFor(x => x.Contact.EmailAddress.Equals(_login)).FirstOrDefault();
            if (employee != null)
            {
                var employeeLogin = employee.Contact.EmailAddress;

                var dbProducts = _purchaseOrderHeaderRepository.SearchFor(x => x.Employee.SalesPerson.Employee.Contact.Equals(employeeLogin))
                                                       .Select(x => x.PurchaseOrderDetails.Select(y => y.Product)).ToList();

                Dictionary<String, int> products = new Dictionary<string, int>();
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

                GetProductsSoldByPersonModel model = new GetProductsSoldByPersonModel()
                {
                    EmployeeName = "",
                    Products = products.Select(x => new GetProductsSoldByPersonItemModel()
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
