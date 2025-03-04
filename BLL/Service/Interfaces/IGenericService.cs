using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buytopia.BLL.Service.Interfaces
{
    public interface IGenericService<TModel> where TModel : class
    {
        public List<TModel> GetAll();
        public TModel GetById(int key);
        public bool Update(TModel entity);
        public bool Delete(int key);
        public bool Add(TModel entity);

    }
}
