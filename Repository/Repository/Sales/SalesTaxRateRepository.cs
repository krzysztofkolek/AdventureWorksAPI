namespace AdventureWorks.Repository.dbo
{
    using EntityClasses.Sales;
    using Main;

    public class SalesTaxRateRepository<T> : IRepository<T>, IEditableRepository<T>
        where T : SalesTaxRate, new()
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