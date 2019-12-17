using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AisMKIT.Models;
using AisMKIT.Data;

namespace AisMKIT.Areas.Media.Controllers
{
    [Area("Media")]
    public class DictAgencyPermsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public DictAgencyPermsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Media/DictAgencyPerms
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.DictAgencyPerm.Include(d => d.StatusForDict);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Media/DictAgencyPerms/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dictAgencyPerm = await _context.DictAgencyPerm
                .Include(d => d.StatusForDict)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (dictAgencyPerm == null)
            {
                return NotFound();
            }

            return View(dictAgencyPerm);
        }

        // GET: Media/DictAgencyPerms/Create
        public IActionResult Create()
        {
            ViewData["StatusForDictId"] = new SelectList(_context.Set<StatusForDict>(), "Id", "Name");
            return View();
        }

        // POST: Media/DictAgencyPerms/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,NameKyrg,NameRus,CreateDate,StatusForDictId,DeactiveDate")] DictAgencyPerm dictAgencyPerm)
        {
            if (ModelState.IsValid)
            {
                _context.Add(dictAgencyPerm);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["StatusForDictId"] = new SelectList(_context.Set<StatusForDict>(), "Id", "Name", dictAgencyPerm.StatusForDictId);
            return View(dictAgencyPerm);
        }

        // GET: Media/DictAgencyPerms/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dictAgencyPerm = await _context.DictAgencyPerm.FindAsync(id);
            if (dictAgencyPerm == null)
            {
                return NotFound();
            }
            ViewData["StatusForDictId"] = new SelectList(_context.Set<StatusForDict>(), "Id", "Name", dictAgencyPerm.StatusForDictId);
            return View(dictAgencyPerm);
        }

        // POST: Media/DictAgencyPerms/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,NameKyrg,NameRus,CreateDate,StatusForDictId,DeactiveDate")] DictAgencyPerm dictAgencyPerm)
        {
            if (id != dictAgencyPerm.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(dictAgencyPerm);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DictAgencyPermExists(dictAgencyPerm.Id))
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
            ViewData["StatusForDictId"] = new SelectList(_context.Set<StatusForDict>(), "Id", "Name", dictAgencyPerm.StatusForDictId);
            return View(dictAgencyPerm);
        }

        // GET: Media/DictAgencyPerms/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dictAgencyPerm = await _context.DictAgencyPerm
                .Include(d => d.StatusForDict)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (dictAgencyPerm == null)
            {
                return NotFound();
            }

            return View(dictAgencyPerm);
        }

        // POST: Media/DictAgencyPerms/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var dictAgencyPerm = await _context.DictAgencyPerm.FindAsync(id);
            _context.DictAgencyPerm.Remove(dictAgencyPerm);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DictAgencyPermExists(int id)
        {
            return _context.DictAgencyPerm.Any(e => e.Id == id);
        }
    }
}
