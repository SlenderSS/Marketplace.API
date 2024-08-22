namespace ApiMarketplace.DTOs.Order
{
    public class OrderDTO
    {
        public long Id { get; set; }
        public long UserId { get; set; }
        public decimal TotalAmount { get; set; }
        public string Status { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
