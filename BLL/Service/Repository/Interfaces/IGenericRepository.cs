using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buytopia.BLL.Service.Repository.Interfaces
{
    interface IGenericRepository<T> where T : class
    {
        bool Create(T entity);
        T Update(T entity);
        bool Delete(int key);
        IList<T> GetAll();
        T GetById(int id);
        void SaveChanges();
    }
}
