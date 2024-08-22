using CSharpFunctionalExtensions;

namespace ApiMarketplace.Models
{
    public class BasketItem : Entity
    {
        public long BasketId { get; set; }
        public Basket Basket { get; set; }
        public long ProductId { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
    }
}
