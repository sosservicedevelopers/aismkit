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
    public class DictLangMediaTypesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public DictLangMediaTypesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Media/DictLangMediaTypes
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.DictLangMediaType.Include(d => d.StatusForDict);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Media/DictLangMediaTypes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dictLangMediaType = await _context.DictLangMediaType
                .Include(d => d.StatusForDict)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (dictLangMediaType == null)
            {
                return NotFound();
            }

            return View(dictLangMediaType);
        }

        // GET: Media/DictLangMediaTypes/Create
        public IActionResult Create()
        {
            ViewData["StatusForDictId"] = new SelectList(_context.Set<StatusForDict>(), "Id", "Name");
            return View();
        }

        // POST: Media/DictLangMediaTypes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,NameKyrg,NameRus,CreateDate,StatusForDictId,DeactiveDate")] DictLangMediaType dictLangMediaType)
        {
            if (ModelState.IsValid)
            {
                _context.Add(dictLangMediaType);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["StatusForDictId"] = new SelectList(_context.Set<StatusForDict>(), "Id", "Name", dictLangMediaType.StatusForDictId);
            return View(dictLangMediaType);
        }

        // GET: Media/DictLangMediaTypes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dictLangMediaType = await _context.DictLangMediaType.FindAsync(id);
            if (dictLangMediaType == null)
            {
                return NotFound();
            }
            ViewData["StatusForDictId"] = new SelectList(_context.Set<StatusForDict>(), "Id", "Name", dictLangMediaType.StatusForDictId);
            return View(dictLangMediaType);
        }

        // POST: Media/DictLangMediaTypes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,NameKyrg,NameRus,CreateDate,StatusForDictId,DeactiveDate")] DictLangMediaType dictLangMediaType)
        {
            if (id != dictLangMediaType.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(dictLangMediaType);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DictLangMediaTypeExists(dictLangMediaType.Id))
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
            ViewData["StatusForDictId"] = new SelectList(_context.Set<StatusForDict>(), "Id", "Name", dictLangMediaType.StatusForDictId);
            return View(dictLangMediaType);
        }

        // GET: Media/DictLangMediaTypes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dictLangMediaType = await _context.DictLangMediaType
                .Include(d => d.StatusForDict)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (dictLangMediaType == null)
            {
                return NotFound();
            }

            return View(dictLangMediaType);
        }

        // POST: Media/DictLangMediaTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var dictLangMediaType = await _context.DictLangMediaType.FindAsync(id);
            _context.DictLangMediaType.Remove(dictLangMediaType);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DictLangMediaTypeExists(int id)
        {
            return _context.DictLangMediaType.Any(e => e.Id == id);
        }
    }
}
