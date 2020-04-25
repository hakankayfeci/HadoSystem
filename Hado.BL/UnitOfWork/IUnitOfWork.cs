using Hado.BL.UnitOfWork.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hado.BL.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        //IBaseRepository<T> GetRepositorys<T>() where T : class;

        int SaveChanges();
    }
}
