namespace ApiMarketplace.Models
{
    public class BlackList : BaseEntity
    {
        public Guid UserId { get; set; }
        public User User { get; set; }
        public string Reason { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
