using CSharpFunctionalExtensions;

namespace ApiMarketplace.Models
{
    public class Review : Entity
    {
        public long UserId { get; set; }
        public User User { get; set; }
        public long ProductId { get; set; }
        public Product Product { get; set; }
        public int Rating { get; set; }
        public string Comment { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
