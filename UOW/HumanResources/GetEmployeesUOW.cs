namespace AdventureWorks.UOW.HumanResources
{
    using System.Linq;
    using Configuration;
    using EntityClasses.HumanResources;
    using Main;
    using Model.HumanResources;
    using Repository.HumanResources;
    using AdventureWorks.Repository.HumanResources;

    public class GetEmployeesUOW : BaseUOW<GetEmployeesViewModel>
    {
        public GetEmployeesUOW(EmployeeExtendedRepository<Employee> employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        private EmployeeExtendedRepository<Employee> _employeeRepository { get; set; }
        private int _page { get; set; }

        public GetEmployeesUOW SetPage(int page)
        {
            _page = page;
            return this;
        }

        public override GetEmployeesViewModel GetResult()
        {
            var model = new GetEmployeesViewModel();
            var repositoryResult = _employeeRepository.GetEmployeesPaging(1, Configuration.Instance.PageSize);

            model.Employees = repositoryResult.Select(item => new GetEmployeesItems
            {
                Id = item.Id,
                FullName = item.FullName,
                HireDate = item.HireDate,
                Title = item.Title,
                ManagerFullName = item.ManagerFullName,
                Salary = item.Salary
            }).ToList();
            
            return model;
        }
    }
}