using Buytopia.DAL.Entities;
using Buytopia.DAL.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buytopia.DAL.Repository
{
    class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        public ProductRepository(BuytopiaDbContext _context) : base(_context)
        {
        }
    }
}
