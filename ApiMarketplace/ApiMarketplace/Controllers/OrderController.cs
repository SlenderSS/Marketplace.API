using ApiMarketplace.Models;
using ApiMarketplace.Repository.Interface;
using Microsoft.AspNetCore.Mvc;

namespace ApiMarketplace.Controllers
{
    [ApiController]
    public class OrderController : BaseAppController<Order>
    {
        public OrderController(IBaseRepository<Order> service) : base(service)
        {
        }
    }
}
