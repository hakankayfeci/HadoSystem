using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Hado.BL.UnitOfWork.Abstract
{
    public interface IBaseRepository<T> where T : class, new()
    {
        bool Insert(T model);
        bool Update(T model);
        bool Remove(T model);
        bool Remove(int id);
        List<T> GetAll();
        T Get(int id);
        List<T> GetByFilter(Expression<Func<T,bool>> filter);
    }
}
