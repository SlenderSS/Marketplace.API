namespace ApiMarketplace.DTOs.ProductImage
{
    public class ProductImageDTO
    {
        public Guid Id { get; set; }
        public Guid ProductId { get; set; }
        public string ImageUrl { get; set; }
    }
}
