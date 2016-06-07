namespace AdventureWorks.Repository.Main
{
    using System.Collections.Generic;
    using System.Linq;
    using NHibernate;
    using NHibernate.Linq; 

    public abstract class BaseRepository<T>
    {
        public virtual System.Collections.Generic.IList<T> BaseSearchFor(System.Linq.Expressions.Expression<System.Func<T, bool>> predicate)
        {
            using (ISession session = SessionManager.OpenSession())
            {
                return session.Query<T>().Where(predicate).ToList();
            }
        }

        public virtual System.Collections.Generic.IList<T> BaseGetAll()
        {
            using (ISession session = SessionManager.OpenSession())
            {
                return session.Query<T>().AsQueryable().ToList();
            }
        }

        public virtual T BaseGetById(int id)
        {
            using (ISession session = SessionManager.OpenSession())
            {
                return session.Get<T>(id);
            }
        }

        public virtual void BaseInsert(T entity)
        {
            using (ISession session = SessionManager.OpenSession())
            {
                session.SaveOrUpdate(entity);
            }
        }

        public virtual void BaseDelete(T entity)
        {
            using (ISession session = SessionManager.OpenSession())
            {
                session.Delete(entity);
            }
        }
    }
}
