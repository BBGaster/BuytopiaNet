using Buytopia.BLL.Service.Repository.Interfaces;
using Buytopia.DAL;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buytopia.BLL.Service.Repository
{
    class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly BuytopiaDbContext _context;
        private readonly DbSet<T> _dbSet;

        public GenericRepository(BuytopiaDbContext _context)
        {
            this._context = _context;
            _dbSet = _context.Set<T>();
        }

        public bool Create(T entity)
        {
            _dbSet.Add(entity);
            return _context.SaveChanges() > 0;
        }

        public T Update(T entity)
        {
            _dbSet.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
            _context.SaveChanges();
            return entity;
        }

        public bool Delete(int key)
        {
            T entity = _dbSet.Find(key);
            if (entity == null)
            {
                return false;
            }

            _dbSet.Remove(entity);

            return _context.SaveChanges() > 0;
        }

        public IList<T> GetAll()
        {
            return _dbSet.ToList();
        }

        public T GetById(int id)
        {
            return _dbSet.Find(id);
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
