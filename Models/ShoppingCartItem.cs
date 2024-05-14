using System.ComponentModel.DataAnnotations;

namespace Book_Shop.Models
{
    public class ShoppingCartItem
    {
        [Key]
        public int ID { get; set; }
        public int Amount { get; set; }
        public string ShoppingCartId { get; set; }

        public virtual Book book { get; set; }
    }
}
