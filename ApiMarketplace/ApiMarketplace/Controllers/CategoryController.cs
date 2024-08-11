using ApiMarketplace.Models;
using ApiMarketplace.Repository.Interface;
using Microsoft.AspNetCore.Mvc;

namespace ApiMarketplace.Controllers
{
    [ApiController]
    public class CategoryController : BaseAppController<Category>
    {
        public CategoryController(IBaseRepository<Category> service) : base(service)
        {
        }
    }
}
