namespace AdventureWorks.Repository.Main
{
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;

    public interface IRepository<T>
    {
        IList<T> SearchFor(Expression<Func<T, bool>> predicate);
        IList<T> GetAll();
        T GetById(int id);
    }
}