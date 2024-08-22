namespace ApiMarketplace.DTOs.BasketItem
{
    public class BasketItemDTO
    {
        public long Id { get; set; }
        public long BasketId { get; set; }
        public long ProductId { get; set; }
        public int Quantity { get; set; }
    }
}
