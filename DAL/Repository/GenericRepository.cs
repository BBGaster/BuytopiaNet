using Buytopia.DAL;
using Buytopia.DAL.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buytopia.DAL.Repository
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        private readonly BuytopiaDbContext _context;
        private readonly DbSet<TEntity> _dbSet;

        public GenericRepository(BuytopiaDbContext _context)
        {
            this._context = _context;
            _dbSet = _context.Set<TEntity>();
        }

        public bool Add(TEntity entity)
        {
            _dbSet.Add(entity);
            return _context.SaveChanges() > 0;
        }

        public TEntity Update(TEntity entity)
        {
            _dbSet.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
            _context.SaveChanges();
            return entity;
        }

        public bool Delete(int key)
        {
            TEntity entity = _dbSet.Find(key);
            if (entity == null)
            {
                return false;
            }

            _dbSet.Remove(entity);

            return _context.SaveChanges() > 0;
        }

        public IList<TEntity> GetAll()
        {
            return _dbSet.ToList();
        }

        public TEntity GetById(int id)
        {
            return _dbSet.Find(id);
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
