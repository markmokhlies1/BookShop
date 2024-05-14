using Book_Shop.Data.Enums;
using System.ComponentModel.DataAnnotations;

namespace Book_Shop.Data.ViewModel
{
    public class NewBookVm
    {
        public int ID { get; set; }

        [Display(Name = "Book name")]
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

        [Display(Name = "Book description")]
        [Required(ErrorMessage = "Description is required")]
        public string Description { get; set; }

        [Display(Name = "Price in $")]
        [Required(ErrorMessage = "Price is required")]
        public double Price { get; set; }

        [Display(Name = "Book image URL")]
        [Required(ErrorMessage = "Book image URL is required")]
        public string ImageURL { get; set; }

        [Display(Name = "Book Release date")]
        [Required(ErrorMessage = "Release date is required")]
        public int ReleaseDate { get; set; }

        [Display(Name = "Pages Number")]
        [Required(ErrorMessage = "Number of pages is required")]
        public int PagesNumber { get; set; }


        [Display(Name = "Select a category")]
        [Required(ErrorMessage = "Book category is required")]
        public BookCategory BookCategory { get; set; }

        //Relationships
        [Display(Name = "Select publisher")]
        [Required(ErrorMessage = "Book Publisher(s) is required")]
        public List<int> PublisherIds { get; set; }

        [Display(Name = "Select an author")]
        [Required(ErrorMessage = "Book author is required")]
        public int AuthorId { get; set; }
    }
}
