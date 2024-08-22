using ApiMarketplace.Models;

namespace ApiMarketplace.DTOs.User
{
    public class UserDTO
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public UserDTO(Models.User user)
        {
            Id = user.Id;
            Name = user.Name;
            CreatedAt = user.CreatedAt;
            UpdatedAt = user.UpdatedAt;
        }
    }
}
