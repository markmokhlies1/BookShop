using System.ComponentModel.DataAnnotations;

namespace Book_Shop.Models
{
    public class Order
    {
        [Key]
        public int ID { get; set; }

        public string Email { get; set; }

        public string UserId { get; set; }

        public virtual ApplicationUser User { get; set; }

        public virtual List<OrderItem> OrderItems { get; set; }
    }
}
