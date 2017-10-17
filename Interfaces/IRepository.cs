using System.Collections.Generic;
using System.Threading.Tasks;

namespace appharbor.Interfaces
{
    public interface IRepository<T> where T: class, new()
    {
        Task<List<T>> List();    
    }
}