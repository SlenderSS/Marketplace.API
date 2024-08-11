using ApiMarketplace.Models;
using ApiMarketplace.Repository.Interface;
using Microsoft.AspNetCore.Mvc;

namespace ApiMarketplace.Controllers
{
    [ApiController]
    public class BlackListController : BaseAppController<BlackList>
    {
        public BlackListController(IBaseRepository<BlackList> service) : base(service)
        {
        }
    }
}
