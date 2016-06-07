namespace AdventureWorks.Repository.dbo
{
    using EntityClasses.Person;
    using Main;

    public class ContactRepository<T> : IRepository<T>, IEditableRepository<T>
        where T : Contact, new()
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