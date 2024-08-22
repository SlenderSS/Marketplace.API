using CSharpFunctionalExtensions;

namespace ApiMarketplace.Models
{
    public class ProductImage: Entity
    {
        public long ProductId { get; set; }
        public string ImageUrl { get; set; }
        public Product Product { get; set; }
    }
}
