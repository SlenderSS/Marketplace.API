using ApiMarketplace.Models;
using ApiMarketplace.Repository.Interface;
using Microsoft.AspNetCore.Mvc;

namespace ApiMarketplace.Controllers
{
    public class OrderItemController : BaseAppController<OrderItem>
    {
        public OrderItemController(IBaseRepository<OrderItem> service) : base(service)
        {
        }

    }
}
