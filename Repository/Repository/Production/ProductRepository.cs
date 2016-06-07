namespace AdventureWorks.Repository.dbo
{
    using System.Collections.Generic;
    using System.Linq;
    using EntityClasses.Production;
    using Main;
    using NHibernate;
    using NHibernate.Linq;

    public class ProductRepository<T> : IRepository<T>, IEditableRepository<T>
        where T : Product, new()
    {
        public System.Linq.IQueryable<T> SearchFor(System.Linq.Expressions.Expression<System.Func<T, bool>> predicate)
        {
            throw new System.NotImplementedException();
        }

        public System.Linq.IQueryable<T> GetAll()
        {
            using (ISession sessionTest = SessionManager.OpenSession())
            {
                IList<Product> books = sessionTest.CreateCriteria(typeof(Product)).List<Product>();
                IList<Product> books345t78 = sessionTest.Query<Product>().ToList();
            }
            return null;
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