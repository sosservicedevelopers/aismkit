using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AisMKIT.Data;
using AisMKIT.Models;

namespace AisMKIT.Areas.Media.Controllers
{
    [Area("Media")]
    public class DictMediaFinSourcesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public DictMediaFinSourcesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Media/DictMediaFinSources
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.DictMediaFinSource.Include(d => d.StatusForDict);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Media/DictMediaFinSources/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dictMediaFinSource = await _context.DictMediaFinSource
                .Include(d => d.StatusForDict)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (dictMediaFinSource == null)
            {
                return NotFound();
            }

            return View(dictMediaFinSource);
        }

        // GET: Media/DictMediaFinSources/Create
        public IActionResult Create()
        {
            ViewData["StatusForDictId"] = new SelectList(_context.Set<StatusForDict>(), "Id", "Name");
            return View();
        }

        // POST: Media/DictMediaFinSources/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,NameKyrg,NameRus,CreateDate,StatusForDictId,DeactiveDate")] DictMediaFinSource dictMediaFinSource)
        {
            if (ModelState.IsValid)
            {
                _context.Add(dictMediaFinSource);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["StatusForDictId"] = new SelectList(_context.Set<StatusForDict>(), "Id", "Name", dictMediaFinSource.StatusForDictId);
            return View(dictMediaFinSource);
        }

        // GET: Media/DictMediaFinSources/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dictMediaFinSource = await _context.DictMediaFinSource.FindAsync(id);
            if (dictMediaFinSource == null)
            {
                return NotFound();
            }
            ViewData["StatusForDictId"] = new SelectList(_context.Set<StatusForDict>(), "Id", "Name", dictMediaFinSource.StatusForDictId);
            return View(dictMediaFinSource);
        }

        // POST: Media/DictMediaFinSources/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,NameKyrg,NameRus,CreateDate,StatusForDictId,DeactiveDate")] DictMediaFinSource dictMediaFinSource)
        {
            if (id != dictMediaFinSource.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(dictMediaFinSource);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DictMediaFinSourceExists(dictMediaFinSource.Id))
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
            ViewData["StatusForDictId"] = new SelectList(_context.Set<StatusForDict>(), "Id", "Name", dictMediaFinSource.StatusForDictId);
            return View(dictMediaFinSource);
        }

        // GET: Media/DictMediaFinSources/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dictMediaFinSource = await _context.DictMediaFinSource
                .Include(d => d.StatusForDict)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (dictMediaFinSource == null)
            {
                return NotFound();
            }

            return View(dictMediaFinSource);
        }

        // POST: Media/DictMediaFinSources/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var dictMediaFinSource = await _context.DictMediaFinSource.FindAsync(id);
            _context.DictMediaFinSource.Remove(dictMediaFinSource);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DictMediaFinSourceExists(int id)
        {
            return _context.DictMediaFinSource.Any(e => e.Id == id);
        }
    }
}
