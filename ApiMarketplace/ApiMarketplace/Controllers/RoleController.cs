using ApiMarketplace.Models;
using ApiMarketplace.Repository.Interface;
using Microsoft.AspNetCore.Mvc;

namespace ApiMarketplace.Controllers
{
    public class RoleController : BaseAppController<Role>
    {
        public RoleController(IBaseRepository<Role> service) : base(service)
        {
        }
    }
}
