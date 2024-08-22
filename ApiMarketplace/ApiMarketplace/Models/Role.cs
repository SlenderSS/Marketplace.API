using CSharpFunctionalExtensions;

namespace ApiMarketplace.Models
{
    public class Role : Entity
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public ICollection<User>? Users { get; set; }
    }
}
