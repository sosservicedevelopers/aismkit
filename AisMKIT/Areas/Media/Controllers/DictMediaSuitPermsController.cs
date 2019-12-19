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
    public class DictMediaSuitPermsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public DictMediaSuitPermsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Media/DictMediaSuitPerms
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.DictMediaSuitPerm.Include(d => d.StatusForDict);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Media/DictMediaSuitPerms/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dictMediaSuitPerm = await _context.DictMediaSuitPerm
                .Include(d => d.StatusForDict)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (dictMediaSuitPerm == null)
            {
                return NotFound();
            }

            return View(dictMediaSuitPerm);
        }

        // GET: Media/DictMediaSuitPerms/Create
        public IActionResult Create()
        {
            ViewData["StatusForDictId"] = new SelectList(_context.Set<StatusForDict>(), "Id", "Name");
            return View();
        }

        // POST: Media/DictMediaSuitPerms/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,NameKyrg,NameRus,CreateDate,StatusForDictId,DeactiveDate")] DictMediaSuitPerm dictMediaSuitPerm)
        {
            if (ModelState.IsValid)
            {
                _context.Add(dictMediaSuitPerm);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["StatusForDictId"] = new SelectList(_context.Set<StatusForDict>(), "Id", "Name", dictMediaSuitPerm.StatusForDictId);
            return View(dictMediaSuitPerm);
        }

        // GET: Media/DictMediaSuitPerms/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dictMediaSuitPerm = await _context.DictMediaSuitPerm.FindAsync(id);
            if (dictMediaSuitPerm == null)
            {
                return NotFound();
            }
            ViewData["StatusForDictId"] = new SelectList(_context.Set<StatusForDict>(), "Id", "Name", dictMediaSuitPerm.StatusForDictId);
            return View(dictMediaSuitPerm);
        }

        // POST: Media/DictMediaSuitPerms/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,NameKyrg,NameRus,CreateDate,StatusForDictId,DeactiveDate")] DictMediaSuitPerm dictMediaSuitPerm)
        {
            if (id != dictMediaSuitPerm.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(dictMediaSuitPerm);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DictMediaSuitPermExists(dictMediaSuitPerm.Id))
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
            ViewData["StatusForDictId"] = new SelectList(_context.Set<StatusForDict>(), "Id", "Name", dictMediaSuitPerm.StatusForDictId);
            return View(dictMediaSuitPerm);
        }

        // GET: Media/DictMediaSuitPerms/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dictMediaSuitPerm = await _context.DictMediaSuitPerm
                .Include(d => d.StatusForDict)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (dictMediaSuitPerm == null)
            {
                return NotFound();
            }

            return View(dictMediaSuitPerm);
        }

        // POST: Media/DictMediaSuitPerms/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var dictMediaSuitPerm = await _context.DictMediaSuitPerm.FindAsync(id);
            _context.DictMediaSuitPerm.Remove(dictMediaSuitPerm);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DictMediaSuitPermExists(int id)
        {
            return _context.DictMediaSuitPerm.Any(e => e.Id == id);
        }
    }
}
