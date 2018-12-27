using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace AgriAnalyticoServer.Repositories
{
    public interface IDataRepository<T>
    {
        IEnumerable<T> GetAll();
        IEnumerable<T> GetByCondition(Expression<Func<T, bool>> expression);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        void Save();
    }
}