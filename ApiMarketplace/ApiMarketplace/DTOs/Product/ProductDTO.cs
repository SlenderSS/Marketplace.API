using ApiMarketplace.DTOs.Category;
using ApiMarketplace.Models;

namespace ApiMarketplace.DTOs.Product
{
    public class ProductDTO
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public long CategoryId { get; set; }
        public ProductDTO(Models.Product product)
        {
            Id = product.Id;
            Name = product.Title;
            Description = product.Description;
            Price = product.Price;
            CategoryId = product.CategoryId;

        }
    }
}
