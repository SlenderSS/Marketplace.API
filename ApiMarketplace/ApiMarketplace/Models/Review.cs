namespace ApiMarketplace.Models
{
    public class Review : BaseEntity
    {
        public Guid UserId { get; set; }
        public User User { get; set; }
        public Guid ProductId { get; set; }
        public Product Product { get; set; }
        public int Rating { get; set; }
        public string Comment { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
