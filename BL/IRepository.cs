using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace BL
{
    interface IRepository<T>
    {
        List<T> GetAll();
        List<T> GetAll(Expression<Func<T, bool>> expression);
        IQueryable<T> GetAllInclude(string table);
        T Find(int id);
        T Get();
        T Get(Expression<Func<T, bool>> expression);
        int Add(T entity);
        int Delete(T entity);
        int Update(T entity);
        int SaveChanges();
    }
}
