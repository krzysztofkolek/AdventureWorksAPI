
namespace AdventureWorks.Repository.dbo
{
    using Main;
    using AdventureWorks.EntityClasses.HumanResources;

    public class EmployeePayHistoryRepository<T> : IRepository<T>, IEditableRepository<T>
        where T : EmployeePayHistory, new()
    {
        public System.Collections.Generic.IList<T> SearchFor(System.Linq.Expressions.Expression<System.Func<T, bool>> predicate)
        {
            throw new System.NotImplementedException();
        }

        public System.Collections.Generic.IList<T> GetAll()
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