
using ApiMarketplace.Models;

namespace ApiMarketplace.DTOs
{
    public class UserDTO
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public UserDTO(User user)
        {
            Id = user.Id;
            Name = user.Name;
            CreatedAt = user.CreatedAt;
            UpdatedAt = user.UpdatedAt;
        }
    }
}
