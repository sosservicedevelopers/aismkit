using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AisMKIT.Data;
using AisMKIT.Models;

namespace AisMKIT.Areas.EduInstitutions.Controllers
{
    [Area("EduInstitutions")]
    public class DictEduCategoriesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public DictEduCategoriesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: ClUchZavedCategories
        public async Task<IActionResult> Index()
        {
            return View(await _context.DictEduCategories.ToListAsync());
        }

        // GET: ClUchZavedCategories/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dictEduCategory = await _context.DictEduCategories
                .FirstOrDefaultAsync(m => m.Id == id);
            if (dictEduCategory == null)
            {
                return NotFound();
            }

            return View(dictEduCategory);
        }

        // GET: ClUchZavedCategories/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ClUchZavedCategories/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Desciption")] DictEduCategory dictEduCategory)
        {
            if (ModelState.IsValid)
            {
                _context.Add(dictEduCategory);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(dictEduCategory);
        }

        // GET: ClUchZavedCategories/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dictEduCategory = await _context.DictEduCategories.FindAsync(id);
            if (dictEduCategory == null)
            {
                return NotFound();
            }
            return View(dictEduCategory);
        }

        // POST: ClUchZavedCategories/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Desciption")] DictEduCategory dictEduCategory)
        {
            if (id != dictEduCategory.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(dictEduCategory);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ClUchZavedCategoryExists(dictEduCategory.Id))
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
            return View(dictEduCategory);
        }

        // GET: ClUchZavedCategories/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dictEduCategory = await _context.DictEduCategories
                .FirstOrDefaultAsync(m => m.Id == id);
            if (dictEduCategory == null)
            {
                return NotFound();
            }

            return View(dictEduCategory);
        }

        // POST: ClUchZavedCategories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var dictEduCategory = await _context.DictEduCategories.FindAsync(id);
            _context.DictEduCategories.Remove(dictEduCategory);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ClUchZavedCategoryExists(int id)
        {
            return _context.DictEduCategories.Any(e => e.Id == id);
        }
    }
}