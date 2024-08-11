using ApiMarketplace.DTOs;
using ApiMarketplace.Helpers;
using ApiMarketplace.Models;
using ApiMarketplace.Repository.Interface;
using ApiMarketplace.Services;
using Microsoft.AspNetCore.Mvc;

namespace ApiMarketplace.Controllers
{
    public class ProductController : BaseAppController<Product>
    {
        ProductFilterSortService _productFilterSortService;
        public ProductController(IBaseRepository<Product> service, ProductFilterSortService productFilterSortService) : base(service)
        {
            _productFilterSortService = productFilterSortService;
        }
        [HttpGet("all")]
        public override async Task<ActionResult> GetAllAsync(FilterSortParameters? filter)
        {
            var products = await _service.GetAllAsync();
            if (filter != null)
            {
                return Ok(_productFilterSortService.FilterSortAndPaginate(products, filter).
                    Select(pr=>new ProductDTO(pr)));
            }
           return Ok(products);
        }
    }
}
