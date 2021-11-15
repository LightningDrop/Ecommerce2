using System.ComponentModel.DataAnnotations;

namespace Ecommcerce2.Core.Models
{
    public class Accounts
    {
        [Key]
        public int AccountId { get; set; }

        [Required]
        [MaxLength(50)]
        public string? FirstName { get; set; }

        [Required]
        [MaxLength(50)]
        public string? Last_Name { get; set; }

        [Required]
        [MaxLength(50)]
        public string? Email { get; set; }

        [Required]
        [MaxLength(10)]
        public string? PhoneNumber { get; set; }

        [Required]
        public string? Address { get; set; }
    }
}

