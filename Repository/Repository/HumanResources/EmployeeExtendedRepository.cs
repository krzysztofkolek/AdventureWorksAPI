namespace AdventureWorks.Repository.HumanResources
{
    using AdventureWorks.EntityClasses.HumanResources;
    using AdventureWorks.Repository.Extension.Model.HumanResources;
    using System.Collections.Generic;

    public class EmployeeExtendedRepository<T> : EmployeeRepository<T>
        where T : Employee, new()
    {



        public IList<EmployeesPaging> GetEmployeesPaging(int page, int entityCount)
        {
            throw new System.NotImplementedException();
        }
    }
}
