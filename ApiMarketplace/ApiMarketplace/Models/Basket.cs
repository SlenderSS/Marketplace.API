namespace ApiMarketplace.Models
{
    public class Basket : BaseEntity
    {
        public Guid UserId { get; set; }
        public User User { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public ICollection<BasketItem> BasketItems { get; set; }
    }
}
