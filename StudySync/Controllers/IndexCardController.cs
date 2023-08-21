using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using StudySync.Data;
using StudySync.Models;

namespace StudySync.Controllers
{
    public class IndexCardController : Controller
    {
        private readonly ApplicationDbContext _context;

        public IndexCardController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: IndexCard
        public async Task<IActionResult> Index()
        {
              return _context.IndexCard != null ? 
                          View(await _context.IndexCard.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.IndexCard'  is null.");
        }

        // GET: IndexCard/ShowSearchForm
        public async Task<IActionResult> ShowSearchForm()
        {
            return _context.IndexCard != null ?
                        View() :
                        Problem("Entity set 'ApplicationDbContext.IndexCard'  is null.");
        }

        // GET: IndexCard/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.IndexCard == null)
            {
                return NotFound();
            }

            var indexCard = await _context.IndexCard
                .FirstOrDefaultAsync(m => m.Id == id);
            if (indexCard == null)
            {
                return NotFound();
            }

            return View(indexCard);
        }

        // GET: IndexCard/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: IndexCard/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,CardQuestion,CardAnswer")] IndexCard indexCard)
        {
            if (ModelState.IsValid)
            {
                _context.Add(indexCard);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(indexCard);
        }

        // GET: IndexCard/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.IndexCard == null)
            {
                return NotFound();
            }

            var indexCard = await _context.IndexCard.FindAsync(id);
            if (indexCard == null)
            {
                return NotFound();
            }
            return View(indexCard);
        }

        // POST: IndexCard/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,CardQuestion,CardAnswer")] IndexCard indexCard)
        {
            if (id != indexCard.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(indexCard);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!IndexCardExists(indexCard.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(indexCard);
        }

        // GET: IndexCard/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.IndexCard == null)
            {
                return NotFound();
            }

            var indexCard = await _context.IndexCard
                .FirstOrDefaultAsync(m => m.Id == id);
            if (indexCard == null)
            {
                return NotFound();
            }

            return View(indexCard);
        }

        // POST: IndexCard/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.IndexCard == null)
            {
                return Problem("Entity set 'ApplicationDbContext.IndexCard'  is null.");
            }
            var indexCard = await _context.IndexCard.FindAsync(id);
            if (indexCard != null)
            {
                _context.IndexCard.Remove(indexCard);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool IndexCardExists(int id)
        {
          return (_context.IndexCard?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
