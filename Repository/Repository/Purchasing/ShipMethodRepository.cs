namespace AdventureWorks.Repository.dbo
{
    using EntityClasses.Purchasing;
    using Main;

    public class ShipMethodRepository<T> : IRepository<T>, IEditableRepository<T>
        where T : ShipMethod, new()
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