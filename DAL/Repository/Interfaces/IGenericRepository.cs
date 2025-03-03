using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buytopia.DAL.Repository.Interfaces
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        bool Add(TEntity entity);
        TEntity Update(TEntity entity);
        bool Delete(int key);
        IList<TEntity> GetAll();
        TEntity GetById(int id);
        void SaveChanges();
    }
}
