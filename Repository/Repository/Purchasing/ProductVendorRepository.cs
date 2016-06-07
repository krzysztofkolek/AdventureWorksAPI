namespace AdventureWorks.Repository.dbo
{
    using EntityClasses.Purchasing;
    using Main;

    public class ProductVendorRepository<T> : IRepository<T>, IEditableRepository<T>
        where T : ProductVendor, new()
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