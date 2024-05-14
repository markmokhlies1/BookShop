using Book_Shop.Data.Srevices;
using Book_Shop.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Book_Shop.Controllers
{
    public class PublisherController : Controller
    {
        private readonly IPublishersService _publishersService;

        public PublisherController(IPublishersService publishersService)
        {
            _publishersService = publishersService;
        }

        // GET: Author
        public async Task<IActionResult> Index()
        {
            var authors = await _publishersService.GetAllAsync();
            return authors != null ?
                        View(await _publishersService.GetAllAsync()) :
                        Problem("Entity set 'AppDbContext.Authors'  is null.");
        }

        // GET: Author/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || await _publishersService.GetByIdAsync((int)id) == null)
            {
                return View("NotFound"); ;
            }

            var publisher = await _publishersService.GetByIdAsync((int)id);
            if (publisher == null)
            {
                return View("NotFound");
            }

            return View(publisher);
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
        public async Task<IActionResult> Create([Bind("ID,Name,Bio,ImageURL")] Publisher publisher)
        {
            if (ModelState.IsValid)
            {
                await _publishersService.AddAsync(publisher);
                return RedirectToAction(nameof(Index));
            }
            return View(publisher);
        }

        // GET: Author/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || await _publishersService.GetAllAsync() == null)
            {
                return View("NotFound");
            }

            var publisher = await _publishersService.GetByIdAsync((int)id);
            if (publisher == null)
            {
                return View("NotFound");
            }
            return View(publisher);
        }

        // POST: Author/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Name,Bio,ImageURL")] Publisher publisher)
        {
            if (id != publisher.ID)
            {
                return View("NotFound");
            }

            if (ModelState.IsValid)
            {
                try
                {
                    await _publishersService.UpdateAsync(id, publisher);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!await AuthorExistsAsync(publisher.ID))
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
            return View(publisher);
        }

        // GET: Author/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || await _publishersService.GetAllAsync() == null)
            {
                return View("NotFound");
            }

            var author = await _publishersService.GetByIdAsync((int)id);
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
            if (await _publishersService.GetAllAsync() == null)
            {
                return Problem("Entity set 'AppDbContext.Authors'  is null.");
            }
            await _publishersService.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }

        private async Task<bool> AuthorExistsAsync(int id)
        {
            var publisher = await _publishersService.GetByIdAsync(id);
            return publisher != null ? true : false;
        }
    }
}
