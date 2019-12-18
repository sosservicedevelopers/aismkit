using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AisMKIT.Data;
using AisMKIT.Models;

namespace AisMKIT.Areas.SubInstitutions.Controllers
{
    [Area("SubInstitutions")]
    public class DictTypeOfSubsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public DictTypeOfSubsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: SubInstitutions/DictTypeOfSubs
        public async Task<IActionResult> Index()
        {
            return View(await _context.DictTypeOfSub.ToListAsync());
        }

        // GET: SubInstitutions/DictTypeOfSubs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dictTypeOfSub = await _context.DictTypeOfSub
                .FirstOrDefaultAsync(m => m.Id == id);
            if (dictTypeOfSub == null)
            {
                return NotFound();
            }

            return View(dictTypeOfSub);
        }

        // GET: SubInstitutions/DictTypeOfSubs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: SubInstitutions/DictTypeOfSubs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,NameKyrg,NameRus")] DictTypeOfSub dictTypeOfSub)
        {
            if (ModelState.IsValid)
            {
                _context.Add(dictTypeOfSub);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(dictTypeOfSub);
        }

        // GET: SubInstitutions/DictTypeOfSubs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dictTypeOfSub = await _context.DictTypeOfSub.FindAsync(id);
            if (dictTypeOfSub == null)
            {
                return NotFound();
            }
            return View(dictTypeOfSub);
        }

        // POST: SubInstitutions/DictTypeOfSubs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,NameKyrg,NameRus")] DictTypeOfSub dictTypeOfSub)
        {
            if (id != dictTypeOfSub.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(dictTypeOfSub);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DictTypeOfSubExists(dictTypeOfSub.Id))
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
            return View(dictTypeOfSub);
        }

        // GET: SubInstitutions/DictTypeOfSubs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dictTypeOfSub = await _context.DictTypeOfSub
                .FirstOrDefaultAsync(m => m.Id == id);
            if (dictTypeOfSub == null)
            {
                return NotFound();
            }

            return View(dictTypeOfSub);
        }

        // POST: SubInstitutions/DictTypeOfSubs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var dictTypeOfSub = await _context.DictTypeOfSub.FindAsync(id);
            _context.DictTypeOfSub.Remove(dictTypeOfSub);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DictTypeOfSubExists(int id)
        {
            return _context.DictTypeOfSub.Any(e => e.Id == id);
        }
    }
}
