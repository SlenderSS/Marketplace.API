namespace ApiMarketplace.DTOs.BlackList
{
    public class BlackListDTO
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public string Reason { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
