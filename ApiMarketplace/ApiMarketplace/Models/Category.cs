using CSharpFunctionalExtensions;

namespace ApiMarketplace.Models
{
    public class Category : Entity
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public ICollection<Product>? Products { get; set; }
    }
}
