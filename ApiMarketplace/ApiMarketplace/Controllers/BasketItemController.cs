using ApiMarketplace.Models;
using ApiMarketplace.Repository.Interface;
using Microsoft.AspNetCore.Mvc;

namespace ApiMarketplace.Controllers
{
    [ApiController]
    public class BasketItemController : BaseAppController<BasketItem>
    {
        public BasketItemController(IBaseRepository<BasketItem> service) : base(service)
        {
        }
    }
}
