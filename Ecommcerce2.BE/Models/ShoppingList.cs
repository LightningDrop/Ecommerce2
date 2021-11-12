using System.ComponentModel.DataAnnotations;

namespace Ecommcerce2.BE
{
    public class ShoppingList
    {
        [Key]
        public int ShoppingListId { get; set; }

        [Required]
        public string? TypeOfList { get; set; }

        [Required]
        public List<ShoppingItems>? Items { get; set; }
    }
}
