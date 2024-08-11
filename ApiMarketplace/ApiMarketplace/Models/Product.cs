namespace ApiMarketplace.Models
{
    public class Product : BaseEntity
    {
        public Guid SellerId { get; set; }
        public User Seller { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public Guid CategoryId { get; set; }
        public Category Category { get; set; }
        public Guid ManufacturerId { get; set; }
        public Manufacturer Manufacturer { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public ICollection<ProductImage> Images { get; set; } = new List<ProductImage>();
        public ICollection<OrderItem> OrderItems { get; set; }= new List<OrderItem>();
        public ICollection<Review> Reviews { get; set; } = new List<Review>();
        public ICollection<BasketItem> BasketItems { get; set; } = new List<BasketItem>();
    }
}
