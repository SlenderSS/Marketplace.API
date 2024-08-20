namespace ApiMarketplace.DTOs.BasketItem
{
    public class BasketItemDTO
    {
        public Guid Id { get; set; }
        public Guid BasketId { get; set; }
        public Guid ProductId { get; set; }
        public int Quantity { get; set; }
    }
}
