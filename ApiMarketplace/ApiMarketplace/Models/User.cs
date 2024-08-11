using System.Data;

namespace ApiMarketplace.Models
{
    public class User:BaseEntity
    {
        public string Name { get; set; }
        public required string Email { get; set; }
        public required string Password { get; set; }
        public Guid RoleId { get; set; }
        public Role Role { get; set; }
        public Guid BasketId { get; set; }
        public Basket Basket { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public ICollection<Order>? Orders { get; set; }
        public ICollection<Review>? Reviews { get; set; }
        public ICollection<Product>? Products { get; set; }
        public ICollection<BlackList>? BlackLists { get; set; }
    }
}
