using Book_Shop.Data.Base;
using Book_Shop.Models;

namespace Book_Shop.Data.Srevices
{
    public class AuthorsService : EntityBaseRepository<Author>, IAuthorsService
    {
        public AuthorsService(AppDbContext context) : base(context) { }
    }
}
