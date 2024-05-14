using Book_Shop.Data.Srevices;
using Book_Shop.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Book_Shop.Controllers
{
    public class BookController : Controller
    {
        private readonly IBooksService _booksService;

        public BookController(IBooksService booksService)
        {
            _booksService = booksService;
        }
        // GET: Book
        public async Task<IActionResult> Index()
        {
            var books = await _booksService.GetAllAsync();
            return books != null ?
                        View(await _booksService.GetAllAsync()) :
                        Problem("Entity set 'AppDbContext.Books'  is null.");
        }
        // GET: Book/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || await _booksService.GetAllAsync() == null)
            {
                return View("NotFound");
            }

            var book = await _booksService.GetByIdAsync((int)id);
            if (book == null)
            {
                return View("NotFound");
            }

            return View(book);
        }
        // GET: Book/Create
        public IActionResult Create()
        {
            return View();
        }
        // POST: Book/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Name,Description,Price,ImageURL,ReleaseDate,PagesNumber,BookCategory")] Book book)
        {
            if (ModelState.IsValid)
            {
                await _booksService.AddAsync(book);
                return RedirectToAction(nameof(Index));
            }
            return View(book);
        }

        // GET: Book/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || await _booksService.GetAllAsync() == null)
            {
                return View("NotFound");
            }

            var book = await _booksService.GetByIdAsync((int)id);
            if (book == null)
            {
                return View("NotFound");
            }
            return View(book);
        }
        // POST: Book/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Name,Description,Price,ImageURL,ReleaseDate,PagesNumber,BookCategory")] Book book)
        {
            if (id != book.ID)
            {
                return View("NotFound");
            }

            if (ModelState.IsValid)
            {
                try
                {
                    await _booksService.UpdateAsync(id, book);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!await BookExistsAsync(book.ID))
                    {
                        return View("NotFound");
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(book);
        }

        // GET: Book/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || await _booksService.GetAllAsync() == null)
            {
                return View("NotFound");
            }

            var book = await _booksService.GetByIdAsync((int)id);
            if (book == null)
            {
                return View("NotFound");
            }

            return View(book);
        }

        // POST: Book/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (await _booksService.GetAllAsync() == null)
            {
                return Problem("Entity set 'AppDbContext.Books'  is null.");
            }
            await _booksService.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }


        private async Task<bool> BookExistsAsync(int id)
        {
            var book = await _booksService.GetByIdAsync(id);
            return book != null;
        }
    }
}
