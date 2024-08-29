using CSharpFunctionalExtensions;

namespace ApiMarketplace.Models
{
    public class Manufacturer : Entity
    {
        public string Name { get; set; }
        public ICollection<Product>? Products { get; set; } = null!;
    }
}