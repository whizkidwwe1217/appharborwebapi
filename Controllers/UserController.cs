using Microsoft.AspNetCore.Mvc;
using appharbor.Models;
using appharbor.Repositories;

namespace appharbor.Controllers
{
    [Route("api/[controller]")]
    public class UserController : BaseController<User>
    {
        public UserController(IUserRepository repository)
            : base(repository)
        {

        }
    }
}