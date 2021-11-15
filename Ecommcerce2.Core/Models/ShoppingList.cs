using System.ComponentModel.DataAnnotations;

namespace Ecommcerce2.Core.Models
{
    public class ShoppingList
    {
        [Key]
        public int ShoppingListId { get; set; }

        [Required]
        [MaxLength(50)]
        public string? TypeOfList { get; set; }

        [Required]
        public List<AvailableItems>? Items { get; set; }
    }
}
