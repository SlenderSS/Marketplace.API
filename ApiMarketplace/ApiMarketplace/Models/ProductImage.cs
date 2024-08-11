namespace ApiMarketplace.Models
{
    public class ProductImage:BaseEntity
    {
        public required Guid ProductId { get; set; }
        public required string ImageUrl { get; set; }
        public required Product Product { get; set; }
    }
}
