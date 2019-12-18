using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AisMKIT.Data;
using AisMKIT.Models;

namespace AisMKIT.Areas.Monument.Controllers
{
    [Area("Monument")]
    public class DictTypeOfMonumentsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public DictTypeOfMonumentsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Monument/DictTypeOfMonuments
        public async Task<IActionResult> Index()
        {
            return View(await _context.DictTypeOfMonument.ToListAsync());
        }

        // GET: Monument/DictTypeOfMonuments/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dictTypeOfMonument = await _context.DictTypeOfMonument
                .FirstOrDefaultAsync(m => m.Id == id);
            if (dictTypeOfMonument == null)
            {
                return NotFound();
            }

            return View(dictTypeOfMonument);
        }

        // GET: Monument/DictTypeOfMonuments/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Monument/DictTypeOfMonuments/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,NameKyrg,NameRus")] DictTypeOfMonument dictTypeOfMonument)
        {
            if (ModelState.IsValid)
            {
                _context.Add(dictTypeOfMonument);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(dictTypeOfMonument);
        }

        // GET: Monument/DictTypeOfMonuments/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dictTypeOfMonument = await _context.DictTypeOfMonument.FindAsync(id);
            if (dictTypeOfMonument == null)
            {
                return NotFound();
            }
            return View(dictTypeOfMonument);
        }

        // POST: Monument/DictTypeOfMonuments/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,NameKyrg,NameRus")] DictTypeOfMonument dictTypeOfMonument)
        {
            if (id != dictTypeOfMonument.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(dictTypeOfMonument);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DictTypeOfMonumentExists(dictTypeOfMonument.Id))
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
            return View(dictTypeOfMonument);
        }

        // GET: Monument/DictTypeOfMonuments/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dictTypeOfMonument = await _context.DictTypeOfMonument
                .FirstOrDefaultAsync(m => m.Id == id);
            if (dictTypeOfMonument == null)
            {
                return NotFound();
            }

            return View(dictTypeOfMonument);
        }

        // POST: Monument/DictTypeOfMonuments/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var dictTypeOfMonument = await _context.DictTypeOfMonument.FindAsync(id);
            _context.DictTypeOfMonument.Remove(dictTypeOfMonument);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DictTypeOfMonumentExists(int id)
        {
            return _context.DictTypeOfMonument.Any(e => e.Id == id);
        }
    }
}
