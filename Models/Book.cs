using Book_Shop.Data.Base;
using Book_Shop.Data.Enums;

namespace Book_Shop.Models
{
    public class Book : IEntityBase
    {
        public int ID { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public double Price { get; set; }
        public string? ImageURL { get; set; }
        public int ReleaseDate { get; set; }
        public int PagesNumber { get; set; }
        public BookCategory BookCategory { get; set; }

        public virtual Publisher? Publisher { get; set; }
        public virtual Author? Author { get; set; }
    }
}
