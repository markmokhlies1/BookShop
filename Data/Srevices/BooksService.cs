using Book_Shop.Data.Base;
using Book_Shop.Models;

namespace Book_Shop.Data.Srevices
{
    public class BooksService : EntityBaseRepository<Book>, IBooksService
    {
        public BooksService(AppDbContext context) : base(context) { }
    }
}
