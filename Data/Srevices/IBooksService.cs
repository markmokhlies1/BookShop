using Book_Shop.Data.Base;
using Book_Shop.Models;

namespace Book_Shop.Data.Srevices
{
    public interface IBooksService : IEntityBaseRepository<Book>
    {
    }
}
