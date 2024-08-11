namespace ApiMarketplace.Models
{
    public class BasketItem : BaseEntity
    {
        public Guid BasketId { get; set; }
        public Basket Basket { get; set; }
        public Guid ProductId { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
    }
}
