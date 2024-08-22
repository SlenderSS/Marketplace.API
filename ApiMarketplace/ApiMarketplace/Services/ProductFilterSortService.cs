using ApiMarketplace.Helpers;
using ApiMarketplace.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiMarketplace.Services
{
    public class ProductFilterSortService
    {
        public IEnumerable<Product> FilterSortAndPaginate(
        IEnumerable<Product> products,
        FilterSortParameters parameters)
        {
            var filteredProducts = products.AsQueryable();

            // Фільтрування
            if (parameters.manufacturerId.HasValue)
            {
                filteredProducts = filteredProducts.Where(p => p.Manufacturer.Id == parameters.manufacturerId);
            }

            if (!string.IsNullOrEmpty(parameters.name))
            {
                filteredProducts = filteredProducts.Where(p => p.Name.Contains(parameters.name));
            }

            if (parameters.sellerId.HasValue)
            {
                filteredProducts = filteredProducts.Where(p => p.Seller.Id==parameters.sellerId);
            }

            if (parameters.minPrice.HasValue)
            {
                filteredProducts = filteredProducts.Where(p => p.Price >= parameters.minPrice.Value);
            }

            if (parameters.maxPrice.HasValue)
            {
                filteredProducts = filteredProducts.Where(p => p.Price <= parameters.maxPrice.Value);
            }

            // Сортування
            if (!string.IsNullOrEmpty(parameters.sortBy))
            {
                filteredProducts = parameters.ascending
                    ? filteredProducts.OrderBy(p => EF.Property<object>(p, parameters.sortBy))
                    : filteredProducts.OrderByDescending(p => EF.Property<object>(p, parameters.sortBy));
            }

            // Пагінація
            var paginatedProducts = filteredProducts
                .Skip((parameters.page - 1) * parameters.size   )
                .Take(parameters.size);

            return paginatedProducts.ToList();
        }
    }
}
