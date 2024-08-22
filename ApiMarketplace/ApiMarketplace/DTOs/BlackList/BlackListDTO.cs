namespace ApiMarketplace.DTOs.BlackList
{
    public class BlackListDTO
    {
        public long Id { get; set; }
        public long UserId { get; set; }
        public string Reason { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
