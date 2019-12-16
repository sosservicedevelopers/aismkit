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
    public class DictControlTypesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public DictControlTypesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Media/DictControlTypes
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.DictControlType.Include(d => d.StatusForDict);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Media/DictControlTypes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dictControlType = await _context.DictControlType
                .Include(d => d.StatusForDict)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (dictControlType == null)
            {
                return NotFound();
            }

            return View(dictControlType);
        }

        // GET: Media/DictControlTypes/Create
        public IActionResult Create()
        {
            ViewData["StatusForDictId"] = new SelectList(_context.Set<StatusForDict>(), "Id", "Name");
            return View();
        }

        // POST: Media/DictControlTypes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,NameKyrg,NameRus,CreateDate,StatusForDictId,DeactiveDate")] DictControlType dictControlType)
        {
            if (ModelState.IsValid)
            {
                _context.Add(dictControlType);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["StatusForDictId"] = new SelectList(_context.Set<StatusForDict>(), "Id", "Name", dictControlType.StatusForDictId);
            return View(dictControlType);
        }

        // GET: Media/DictControlTypes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dictControlType = await _context.DictControlType.FindAsync(id);
            if (dictControlType == null)
            {
                return NotFound();
            }
            ViewData["StatusForDictId"] = new SelectList(_context.Set<StatusForDict>(), "Id", "Name", dictControlType.StatusForDictId);
            return View(dictControlType);
        }

        // POST: Media/DictControlTypes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,NameKyrg,NameRus,CreateDate,StatusForDictId,DeactiveDate")] DictControlType dictControlType)
        {
            if (id != dictControlType.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(dictControlType);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DictControlTypeExists(dictControlType.Id))
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
            ViewData["StatusForDictId"] = new SelectList(_context.Set<StatusForDict>(), "Id", "Name", dictControlType.StatusForDictId);
            return View(dictControlType);
        }

        // GET: Media/DictControlTypes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dictControlType = await _context.DictControlType
                .Include(d => d.StatusForDict)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (dictControlType == null)
            {
                return NotFound();
            }

            return View(dictControlType);
        }

        // POST: Media/DictControlTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var dictControlType = await _context.DictControlType.FindAsync(id);
            _context.DictControlType.Remove(dictControlType);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DictControlTypeExists(int id)
        {
            return _context.DictControlType.Any(e => e.Id == id);
        }
    }
}
