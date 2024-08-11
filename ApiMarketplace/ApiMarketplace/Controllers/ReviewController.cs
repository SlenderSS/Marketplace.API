using ApiMarketplace.Models;
using ApiMarketplace.Repository.Interface;
using Microsoft.AspNetCore.Mvc;

namespace ApiMarketplace.Controllers
{
    public class ReviewController : BaseAppController<Review>
    {
        public ReviewController(IBaseRepository<Review> service) : base(service)
        {
        }
    }
}
