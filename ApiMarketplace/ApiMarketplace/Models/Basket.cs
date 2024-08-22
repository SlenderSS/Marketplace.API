using CSharpFunctionalExtensions;

namespace ApiMarketplace.Models
{
    public class Basket : Entity
    {
        public long UserId { get; set; }
        public User User { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public ICollection<BasketItem> BasketItems { get; set; }
    }
}
