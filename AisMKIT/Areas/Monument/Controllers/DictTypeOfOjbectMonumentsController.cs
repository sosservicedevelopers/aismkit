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
    public class DictTypeOfOjbectMonumentsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public DictTypeOfOjbectMonumentsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Monument/DictTypeOfOjbectMonuments
        public async Task<IActionResult> Index()
        {
            return View(await _context.DictTypeOfOjbectMonument.ToListAsync());
        }

        // GET: Monument/DictTypeOfOjbectMonuments/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dictTypeOfOjbectMonument = await _context.DictTypeOfOjbectMonument
                .FirstOrDefaultAsync(m => m.Id == id);
            if (dictTypeOfOjbectMonument == null)
            {
                return NotFound();
            }

            return View(dictTypeOfOjbectMonument);
        }

        // GET: Monument/DictTypeOfOjbectMonuments/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Monument/DictTypeOfOjbectMonuments/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,NameKyrg,NameRus")] DictTypeOfOjbectMonument dictTypeOfOjbectMonument)
        {
            if (ModelState.IsValid)
            {
                _context.Add(dictTypeOfOjbectMonument);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(dictTypeOfOjbectMonument);
        }

        // GET: Monument/DictTypeOfOjbectMonuments/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dictTypeOfOjbectMonument = await _context.DictTypeOfOjbectMonument.FindAsync(id);
            if (dictTypeOfOjbectMonument == null)
            {
                return NotFound();
            }
            return View(dictTypeOfOjbectMonument);
        }

        // POST: Monument/DictTypeOfOjbectMonuments/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,NameKyrg,NameRus")] DictTypeOfOjbectMonument dictTypeOfOjbectMonument)
        {
            if (id != dictTypeOfOjbectMonument.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(dictTypeOfOjbectMonument);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DictTypeOfOjbectMonumentExists(dictTypeOfOjbectMonument.Id))
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
            return View(dictTypeOfOjbectMonument);
        }

        // GET: Monument/DictTypeOfOjbectMonuments/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dictTypeOfOjbectMonument = await _context.DictTypeOfOjbectMonument
                .FirstOrDefaultAsync(m => m.Id == id);
            if (dictTypeOfOjbectMonument == null)
            {
                return NotFound();
            }

            return View(dictTypeOfOjbectMonument);
        }

        // POST: Monument/DictTypeOfOjbectMonuments/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var dictTypeOfOjbectMonument = await _context.DictTypeOfOjbectMonument.FindAsync(id);
            _context.DictTypeOfOjbectMonument.Remove(dictTypeOfOjbectMonument);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DictTypeOfOjbectMonumentExists(int id)
        {
            return _context.DictTypeOfOjbectMonument.Any(e => e.Id == id);
        }
    }
}
