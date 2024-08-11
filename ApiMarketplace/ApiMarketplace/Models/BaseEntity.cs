using System.ComponentModel.DataAnnotations;

namespace ApiMarketplace.Models
{
    public class BaseEntity
    {
        [Key]
        public Guid Id { get; set; }= Guid.NewGuid();
    }
}
