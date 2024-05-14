using Book_Shop.Data.Srevices;
using Book_Shop.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Book_Shop.Controllers
{
    public class AuthorController : Controller
    {
        private readonly IAuthorsService _authorsService;

        public AuthorController(IAuthorsService authorsService)
        {
            _authorsService = authorsService;
        }

        // GET: Author
        public async Task<IActionResult> Index()
        {
            var authors = await _authorsService.GetAllAsync();
            return authors != null ?
                        View(await _authorsService.GetAllAsync()) :
                        Problem("Entity set 'AppDbContext.Authors'  is null.");
        }
        // GET: Author/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || await _authorsService.GetByIdAsync((int)id) == null)
            {
                return View("NotFound");
            }

            var author = await _authorsService.GetByIdAsync((int)id);
            if (author == null)
            {
                return View("NotFound");
            }

            return View(author);
        }
        // GET: Author/Create
        public IActionResult Create()
        {
            return View();
        }
        // POST: Author/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,FullName,Bio,ImageURL")] Author author)
        {
            if (ModelState.IsValid)
            {
                await _authorsService.AddAsync(author);
                return RedirectToAction(nameof(Index));
            }
            return View(author);
        }

        // GET: Author/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || await _authorsService.GetAllAsync() == null)
            {
                return View("NotFound");

            }

            var author = await _authorsService.GetByIdAsync((int)id);
            if (author == null)
            {
                return View("NotFound");
            }
            return View(author);
        }

        // POST: Author/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,FullName,Bio,ImageURL")] Author author)
        {
            if (id != author.ID)
            {
                return View("NotFound");
            }

            if (ModelState.IsValid)
            {
                try
                {
                    await _authorsService.UpdateAsync(id, author);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!await AuthorExistsAsync(author.ID))
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
            return View(author);
        }

        // GET: Author/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || await _authorsService.GetAllAsync() == null)
            {
                return View("NotFound");
            }

            var author = await _authorsService.GetByIdAsync((int)id);
            if (author == null)
            {
                return View("NotFound");
            }

            return View(author);
        }

        // POST: Author/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (await _authorsService.GetAllAsync() == null)
            {
                return Problem("Entity set 'AppDbContext.Authors'  is null.");
            }
            await _authorsService.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }

        private async Task<bool> AuthorExistsAsync(int id)
        {
            var author = await _authorsService.GetByIdAsync(id);
            return author != null ? true : false;
        }
    }
}
    
