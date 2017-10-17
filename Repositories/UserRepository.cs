using System.Collections.Generic;
using System.Threading.Tasks;
using appharbor.Interfaces;
using appharbor.Models;
using Microsoft.EntityFrameworkCore;

namespace appharbor.Repositories
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(AppDbContext context)
            : base(context)
        {

        }
    }
}