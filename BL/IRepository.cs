using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    interface IRepository<T>
    {
        List<T> GetAll();
        T Find(int id);
        T Get();
        int Add(T entity);
        int Delete(T entity);
        int Update(T entity);
        int SaveChanges();
    }
}
