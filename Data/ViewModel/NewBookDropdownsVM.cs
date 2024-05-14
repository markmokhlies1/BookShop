using Book_Shop.Models;

namespace Book_Shop.Data.ViewModel
{
    public class NewBookDropdownsVM
    {
        public NewBookDropdownsVM()
        {
            Authors = new List<Author>();
            Publishers = new List<Publisher>();
        }

        public List<Author> Authors { get; set; }
        public List<Publisher> Publishers { get; set; }
    }
}
