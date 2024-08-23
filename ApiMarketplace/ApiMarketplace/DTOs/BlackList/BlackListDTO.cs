namespace ApiMarketplace.DTOs.BlackList
{
    public class BlackListDTO
    {
        public long Id { get; set; }
        public long UserId { get; set; }
        public string Reason { get; set; } = null!;
        public DateTime CreatedAt { get; set; }
    }
}
