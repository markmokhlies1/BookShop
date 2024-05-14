using Book_Shop.Data.Base;
using Book_Shop.Models;

namespace Book_Shop.Data.Srevices
{
    public class PublishersService : EntityBaseRepository<Publisher>, IPublishersService
    {
        public PublishersService(AppDbContext context) : base(context) { }
    }
}
