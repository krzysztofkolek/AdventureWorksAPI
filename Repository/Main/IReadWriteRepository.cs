namespace AdventureWorks.Repository.Main
{
    public interface IReadWriteRepository<T> : IRepository<T>, IEditableRepository<T>
    {
    }
}