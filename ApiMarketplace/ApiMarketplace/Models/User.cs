using System.Data;
using CSharpFunctionalExtensions;

namespace ApiMarketplace.Models
{
    public class User: Entity
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public long RoleId { get; set; }
        public Role Role { get; set; }
        public long BasketId { get; set; }
        public Basket Basket { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public ICollection<Order>? Orders { get; set; }
        public ICollection<Review>? Reviews { get; set; }
        public ICollection<Product>? Products { get; set; }
        public ICollection<BlackList>? BlackLists { get; set; }
    }
}
