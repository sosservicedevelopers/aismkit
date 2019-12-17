using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AisMKIT.Data;
using AisMKIT.Models;

namespace AisMKIT.Areas.Theatrical.Controllers
{
    [Area("Theatrical")]
    public class DictTheatricalFinSourcesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public DictTheatricalFinSourcesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Theatrical/DictTheatricalFinSources
        public async Task<IActionResult> Index()
        {
            return View(await _context.DictTheatricalFinSource.ToListAsync());
        }

        // GET: Theatrical/DictTheatricalFinSources/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dictTheatricalFinSource = await _context.DictTheatricalFinSource
                .FirstOrDefaultAsync(m => m.Id == id);
            if (dictTheatricalFinSource == null)
            {
                return NotFound();
            }

            return View(dictTheatricalFinSource);
        }

        // GET: Theatrical/DictTheatricalFinSources/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Theatrical/DictTheatricalFinSources/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,NameKyrg,NameRus")] DictTheatricalFinSource dictTheatricalFinSource)
        {
            if (ModelState.IsValid)
            {
                _context.Add(dictTheatricalFinSource);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(dictTheatricalFinSource);
        }

        // GET: Theatrical/DictTheatricalFinSources/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dictTheatricalFinSource = await _context.DictTheatricalFinSource.FindAsync(id);
            if (dictTheatricalFinSource == null)
            {
                return NotFound();
            }
            return View(dictTheatricalFinSource);
        }

        // POST: Theatrical/DictTheatricalFinSources/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,NameKyrg,NameRus")] DictTheatricalFinSource dictTheatricalFinSource)
        {
            if (id != dictTheatricalFinSource.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(dictTheatricalFinSource);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DictTheatricalFinSourceExists(dictTheatricalFinSource.Id))
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
            return View(dictTheatricalFinSource);
        }

        // GET: Theatrical/DictTheatricalFinSources/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dictTheatricalFinSource = await _context.DictTheatricalFinSource
                .FirstOrDefaultAsync(m => m.Id == id);
            if (dictTheatricalFinSource == null)
            {
                return NotFound();
            }

            return View(dictTheatricalFinSource);
        }

        // POST: Theatrical/DictTheatricalFinSources/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var dictTheatricalFinSource = await _context.DictTheatricalFinSource.FindAsync(id);
            _context.DictTheatricalFinSource.Remove(dictTheatricalFinSource);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DictTheatricalFinSourceExists(int id)
        {
            return _context.DictTheatricalFinSource.Any(e => e.Id == id);
        }
    }
}
