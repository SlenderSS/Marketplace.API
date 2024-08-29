using CSharpFunctionalExtensions;

namespace ApiMarketplace.Models
{
    public class OrderItem : Entity
    {
        public long OrderId { get; set; }
        public Order Order { get; set; }
        public long ProductId { get; set; }
        public Product Product { get; set; }
    }
}
