using Microsoft.AspNetCore.Mvc;
using appharbor.Models;
using appharbor.Interfaces;
using System.Threading.Tasks;

namespace appharbor.Controllers
{
    [Route("api/[controller]")]
    public class BaseController<T> : Controller where T: class, new()
    {
        protected IRepository<T> repository;

        public BaseController(IRepository<T> repository)
        {
            this.repository = repository;
        }

        [HttpGet]
        public async Task<IActionResult> List()
        {
            return Ok(await repository.List());
        }
    }
}