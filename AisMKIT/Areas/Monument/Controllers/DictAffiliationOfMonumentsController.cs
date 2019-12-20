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
    public class DictAffiliationOfMonumentsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public DictAffiliationOfMonumentsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Monument/DictAffiliationOfMonuments
        public async Task<IActionResult> Index()
        {
            return View(await _context.DictAffiliationOfMonument.ToListAsync());
        }

        // GET: Monument/DictAffiliationOfMonuments/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dictAffiliationOfMonument = await _context.DictAffiliationOfMonument
                .FirstOrDefaultAsync(m => m.Id == id);
            if (dictAffiliationOfMonument == null)
            {
                return NotFound();
            }

            return View(dictAffiliationOfMonument);
        }

        // GET: Monument/DictAffiliationOfMonuments/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Monument/DictAffiliationOfMonuments/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,NameKyrg,NameRus")] DictAffiliationOfMonument dictAffiliationOfMonument)
        {
            if (ModelState.IsValid)
            {
                _context.Add(dictAffiliationOfMonument);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(dictAffiliationOfMonument);
        }

        // GET: Monument/DictAffiliationOfMonuments/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dictAffiliationOfMonument = await _context.DictAffiliationOfMonument.FindAsync(id);
            if (dictAffiliationOfMonument == null)
            {
                return NotFound();
            }
            return View(dictAffiliationOfMonument);
        }

        // POST: Monument/DictAffiliationOfMonuments/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,NameKyrg,NameRus")] DictAffiliationOfMonument dictAffiliationOfMonument)
        {
            if (id != dictAffiliationOfMonument.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(dictAffiliationOfMonument);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DictAffiliationOfMonumentExists(dictAffiliationOfMonument.Id))
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
            return View(dictAffiliationOfMonument);
        }

        // GET: Monument/DictAffiliationOfMonuments/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dictAffiliationOfMonument = await _context.DictAffiliationOfMonument
                .FirstOrDefaultAsync(m => m.Id == id);
            if (dictAffiliationOfMonument == null)
            {
                return NotFound();
            }

            return View(dictAffiliationOfMonument);
        }

        // POST: Monument/DictAffiliationOfMonuments/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var dictAffiliationOfMonument = await _context.DictAffiliationOfMonument.FindAsync(id);
            _context.DictAffiliationOfMonument.Remove(dictAffiliationOfMonument);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DictAffiliationOfMonumentExists(int id)
        {
            return _context.DictAffiliationOfMonument.Any(e => e.Id == id);
        }
    }
}
