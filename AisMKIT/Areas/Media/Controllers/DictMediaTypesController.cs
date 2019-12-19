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
    public class DictMediaTypesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public DictMediaTypesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Media/DictMediaTypes
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.DictMediaType.Include(d => d.StatusForDict);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Media/DictMediaTypes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dictMediaType = await _context.DictMediaType
                .Include(d => d.StatusForDict)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (dictMediaType == null)
            {
                return NotFound();
            }

            return View(dictMediaType);
        }

        // GET: Media/DictMediaTypes/Create
        public IActionResult Create()
        {
            ViewData["StatusForDictId"] = new SelectList(_context.Set<StatusForDict>(), "Id", "Name");
            return View();
        }

        // POST: Media/DictMediaTypes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,NameKyrg,NameRus,CreateDate,StatusForDictId,DeactiveDate")] DictMediaType dictMediaType)
        {
            if (ModelState.IsValid)
            {
                _context.Add(dictMediaType);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["StatusForDictId"] = new SelectList(_context.Set<StatusForDict>(), "Id", "Name", dictMediaType.StatusForDictId);
            return View(dictMediaType);
        }

        // GET: Media/DictMediaTypes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dictMediaType = await _context.DictMediaType.FindAsync(id);
            if (dictMediaType == null)
            {
                return NotFound();
            }
            ViewData["StatusForDictId"] = new SelectList(_context.Set<StatusForDict>(), "Id", "Name", dictMediaType.StatusForDictId);
            return View(dictMediaType);
        }

        // POST: Media/DictMediaTypes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,NameKyrg,NameRus,CreateDate,StatusForDictId,DeactiveDate")] DictMediaType dictMediaType)
        {
            if (id != dictMediaType.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(dictMediaType);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DictMediaTypeExists(dictMediaType.Id))
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
            ViewData["StatusForDictId"] = new SelectList(_context.Set<StatusForDict>(), "Id", "Name", dictMediaType.StatusForDictId);
            return View(dictMediaType);
        }

        // GET: Media/DictMediaTypes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dictMediaType = await _context.DictMediaType
                .Include(d => d.StatusForDict)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (dictMediaType == null)
            {
                return NotFound();
            }

            return View(dictMediaType);
        }

        // POST: Media/DictMediaTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var dictMediaType = await _context.DictMediaType.FindAsync(id);
            _context.DictMediaType.Remove(dictMediaType);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DictMediaTypeExists(int id)
        {
            return _context.DictMediaType.Any(e => e.Id == id);
        }
    }
}
