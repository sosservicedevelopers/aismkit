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
    public class DictDistribTerritoryMediasController : Controller
    {
        private readonly ApplicationDbContext _context;

        public DictDistribTerritoryMediasController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Media/DictDistribTerritoryMedias
        public async Task<IActionResult> Index()
        {
            return View(await _context.DictDistribTerritoryMedia.ToListAsync());
        }

        // GET: Media/DictDistribTerritoryMedias/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dictDistribTerritoryMedia = await _context.DictDistribTerritoryMedia
                .FirstOrDefaultAsync(m => m.Id == id);
            if (dictDistribTerritoryMedia == null)
            {
                return NotFound();
            }

            return View(dictDistribTerritoryMedia);
        }

        // GET: Media/DictDistribTerritoryMedias/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Media/DictDistribTerritoryMedias/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,NameRus,NameKyrg")] DictDistribTerritoryMedia dictDistribTerritoryMedia)
        {
            if (ModelState.IsValid)
            {
                _context.Add(dictDistribTerritoryMedia);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(dictDistribTerritoryMedia);
        }

        // GET: Media/DictDistribTerritoryMedias/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dictDistribTerritoryMedia = await _context.DictDistribTerritoryMedia.FindAsync(id);
            if (dictDistribTerritoryMedia == null)
            {
                return NotFound();
            }
            return View(dictDistribTerritoryMedia);
        }

        // POST: Media/DictDistribTerritoryMedias/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,NameRus,NameKyrg")] DictDistribTerritoryMedia dictDistribTerritoryMedia)
        {
            if (id != dictDistribTerritoryMedia.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(dictDistribTerritoryMedia);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DictDistribTerritoryMediaExists(dictDistribTerritoryMedia.Id))
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
            return View(dictDistribTerritoryMedia);
        }

        // GET: Media/DictDistribTerritoryMedias/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dictDistribTerritoryMedia = await _context.DictDistribTerritoryMedia
                .FirstOrDefaultAsync(m => m.Id == id);
            if (dictDistribTerritoryMedia == null)
            {
                return NotFound();
            }

            return View(dictDistribTerritoryMedia);
        }

        // POST: Media/DictDistribTerritoryMedias/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var dictDistribTerritoryMedia = await _context.DictDistribTerritoryMedia.FindAsync(id);
            _context.DictDistribTerritoryMedia.Remove(dictDistribTerritoryMedia);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DictDistribTerritoryMediaExists(int id)
        {
            return _context.DictDistribTerritoryMedia.Any(e => e.Id == id);
        }
    }
}
