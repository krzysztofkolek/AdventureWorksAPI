namespace AdventureWorks.Repository.Main
{
    using System.Collections.Generic;
    using System.Linq;
    using NHibernate;
    using NHibernate.Linq; 

    public abstract class BaseRepository<T>
    {
        protected virtual System.Collections.Generic.IList<T> BaseSearchFor(System.Linq.Expressions.Expression<System.Func<T, bool>> predicate)
        {
            using (ISession session = SessionManager.OpenSession())
            {
                return session.Query<T>().Where(predicate).ToList();
            }
        }

        protected virtual System.Collections.Generic.IList<T> BaseGetAll()
        {
            using (ISession session = SessionManager.OpenSession())
            {
                return session.Query<T>().AsQueryable().ToList();
            }
        }

        protected virtual T BaseGetById(int id)
        {
            using (ISession session = SessionManager.OpenSession())
            {
                return session.Get<T>(id);
            }
        }

        protected virtual void BaseInsert(T entity)
        {
            using (ISession session = SessionManager.OpenSession())
            {
                session.SaveOrUpdate(entity);
            }
        }

        protected virtual void BaseDelete(T entity)
        {
            using (ISession session = SessionManager.OpenSession())
            {
                session.Delete(entity);
            }
        }
    }
}
