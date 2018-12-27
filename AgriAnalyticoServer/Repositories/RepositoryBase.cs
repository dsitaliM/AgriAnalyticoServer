using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using AgriAnalyticoServer.Models;

namespace AgriAnalyticoServer.Repositories
{
    public abstract class RepositoryBase<T> : IDataRepository<T> where T: class 
    {
        protected DataContext DataContext { get; set; }

        protected RepositoryBase(DataContext dataContext)
        {
            this.DataContext = dataContext;
        }
        public IEnumerable<T> GetAll()
        {
            return this.DataContext.Set<T>();
        }

        public IEnumerable<T> GetByCondition(Expression<Func<T, bool>> expression)
        {
            return this.DataContext.Set<T>().Where(expression);
        }

        public void Add(T entity)
        {
            this.DataContext.Set<T>().Add(entity);
        }

        public void Update(T entity)
        {
            this.DataContext.Set<T>().Update(entity);
        }

        public void Delete(T entity)
        {
            this.DataContext.Set<T>().Remove(entity);
        }

        public void Save()
        {
            this.DataContext.SaveChanges();
        }
    }
}