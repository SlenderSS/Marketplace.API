using ApiMarketplace.Models;
using ApiMarketplace.Repository.Interface;
using Microsoft.AspNetCore.Mvc;

namespace ApiMarketplace.Controllers
{
    [ApiController]
    [Route("api/users")]
    public class UserController : BaseAppController<User>
    {
        public UserController(IBaseRepository<User> service) : base(service)
        {
        }
    }
}
