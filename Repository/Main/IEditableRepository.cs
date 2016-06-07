namespace AdventureWorks.Repository.Main
{
    public interface IEditableRepository<T>
    {
        void Insert(T entity);
        void Delete(T entity);
    }
}