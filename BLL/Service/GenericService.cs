using AutoMapper;
using Buytopia.BLL.Service.Interfaces;
using Buytopia.DAL.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buytopia.BLL.Service
{
    public class GenericService<TModel, TEntity> : IGenericService<TModel> where TModel : class where TEntity : class
    {
        private readonly IMapper _mapper;
        private readonly IGenericRepository<TEntity> _genericRepository;

        public GenericService(IMapper mapper, IGenericRepository<TEntity> genericRepository)
        {
            _mapper = mapper;
            _genericRepository = genericRepository;
        }

        public bool Add(TModel entity)
        {
            return _genericRepository.Add(_mapper.Map<TEntity>(entity));
        }

        public bool Delete(int key)
        {
            return _genericRepository.Delete(key);
        }

        public List<TModel> GetAll()
        {
            return _mapper.Map<List<TModel>>(_genericRepository.GetAll());
        }

        public TModel GetById(int key)
        {
            return _mapper.Map<TModel>(_genericRepository.GetById(key));
        }

        public bool Update(TModel entity)
        {
            if (_genericRepository.Update(_mapper.Map<TEntity>(entity)) != null) return true;
            else return false;
        }
    }
}
