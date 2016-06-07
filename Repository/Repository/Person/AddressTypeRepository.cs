namespace AdventureWorks.Repository.dbo
{
    using EntityClasses.Person;
    using Main;

    public class AddressTypeRepository<T> : BaseRepository<T>,  IRepository<T>, IEditableRepository<T>
        where T : AddressType, new()
    {
        public System.Collections.Generic.IList<T> SearchFor(System.Linq.Expressions.Expression<System.Func<T, bool>> predicate)
        {
            return BaseSearchFor(predicate);
        }

        public System.Collections.Generic.IList<T> GetAll()
        {
            return BaseGetAll();
        }

        public T GetById(int id)
        {
            return BaseGetById(id);
        }

        public void Insert(T entity)
        {
            BaseInsert(entity);
        }

        public void Delete(T entity)
        {
            BaseDelete(entity);
        }
    }
}