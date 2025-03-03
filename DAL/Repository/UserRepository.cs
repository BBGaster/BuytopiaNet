using Buytopia.DAL.entityes;
using Buytopia.DAL.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buytopia.DAL.Repository
{
    class UserRepository : GenericRepository<User>, IUserRepository
    {
        public UserRepository(BuytopiaDbContext _context) : base(_context)
        {
        }

    }
}
