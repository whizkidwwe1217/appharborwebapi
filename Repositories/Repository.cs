using System.Collections.Generic;
using System.Threading.Tasks;
using appharbor.Interfaces;
using appharbor.Models;
using Microsoft.EntityFrameworkCore;

namespace appharbor.Repositories
{
    public class Repository<T> : IRepository<T> where T : class, new()
    {
        private readonly AppDbContext context;

        public Repository(AppDbContext context)
        {
            this.context = context;
        }
        public async Task<List<T>> List()
        {
            var query = context.Set<T>().AsNoTracking();
            return await query.ToListAsync();
        }
    }
}