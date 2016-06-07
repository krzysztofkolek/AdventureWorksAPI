namespace AdventureWorks.Repository.dbo
{
    using AdventureWorks.Repository.Main;
    using EntityClasses.HumanResources;

    public class EmployeeDepartmentHistoryRepository<T> : IRepository<T>, IEditableRepository<T>
        where T : EmployeeDepartmentHistory, new()
    {
        public System.Linq.IQueryable<T> SearchFor(System.Linq.Expressions.Expression<System.Func<T, bool>> predicate)
        {
            throw new System.NotImplementedException();
        }

        public System.Linq.IQueryable<T> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public T GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public void Insert(T entity)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(T entity)
        {
            throw new System.NotImplementedException();
        }
    }
}