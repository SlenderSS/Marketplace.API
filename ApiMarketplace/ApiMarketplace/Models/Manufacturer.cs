namespace ApiMarketplace.Models
{
    public class Manufacturer : BaseEntity
    {
        public required string Name { get; set; }
        public ICollection<Product>? Products { get; set; }
    }
}