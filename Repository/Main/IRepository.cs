namespace AdventureWorks.Repository.Main
{
    using System;
    using System.Linq;
    using System.Linq.Expressions;

    public interface IRepository<T>
    {
        IQueryable<T> SearchFor(Expression<Func<T, bool>> predicate);
        IQueryable<T> GetAll();
        T GetById(int id);
    }
}