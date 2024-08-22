using CSharpFunctionalExtensions;

namespace ApiMarketplace.Models
{
    public class BlackList : Entity
    {
        public long UserId { get; set; }
        public User User { get; set; }
        public string Reason { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
