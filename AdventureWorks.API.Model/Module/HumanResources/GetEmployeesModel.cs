namespace AdventureWorks.API.Model.Module.HumanResources
{
    using System.Collections.Generic;

    public class GetEmployeesModel
    {
        public List<HREmployee> Employees { get; set; }
    }
}