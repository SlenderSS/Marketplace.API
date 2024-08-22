using CSharpFunctionalExtensions;

namespace ApiMarketplace.Models
{
    public class Order : Entity
    {
        public long UserId { get; set; }
        public User User { get; set; }
        public decimal TotalAmount { get; set; }
        public string Status { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public ICollection<OrderItem> OrderItems { get; set; }
    }
}
