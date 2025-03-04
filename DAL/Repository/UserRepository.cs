
using Buytopia.DAL.Entities;
using Buytopia.DAL.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buytopia.DAL.Repository
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        public UserRepository(BuytopiaDbContext _context) : base(_context)
        {
        }

    }
}
