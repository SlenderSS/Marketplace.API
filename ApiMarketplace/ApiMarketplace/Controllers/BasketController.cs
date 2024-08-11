using ApiMarketplace.Models;
using ApiMarketplace.Repository.Interface;
using Microsoft.AspNetCore.Mvc;

namespace ApiMarketplace.Controllers
{
    [ApiController]
    [Route("api/Basket")]
    public class BasketController : BaseAppController<Basket>
    {
        public BasketController(IBaseRepository<Basket> service) : base(service)
        {
        }
    }
}
