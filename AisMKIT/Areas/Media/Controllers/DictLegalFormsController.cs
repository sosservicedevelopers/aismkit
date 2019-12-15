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
    public class DictLegalFormsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public DictLegalFormsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Media/DictLegalForms
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.DictLegalForm.Include(d => d.StatusForDict);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Media/DictLegalForms/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dictLegalForm = await _context.DictLegalForm
                .Include(d => d.StatusForDict)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (dictLegalForm == null)
            {
                return NotFound();
            }

            return View(dictLegalForm);
        }

        // GET: Media/DictLegalForms/Create
        public IActionResult Create()
        {
            ViewData["StatusForDictId"] = new SelectList(_context.Set<StatusForDict>(), "Id", "Name");
            return View();
        }

        // POST: Media/DictLegalForms/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,NameKyrg,NameRus,CreateDate,StatusForDictId,DeactiveDate")] DictLegalForm dictLegalForm)
        {
            if (ModelState.IsValid)
            {
                _context.Add(dictLegalForm);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["StatusForDictId"] = new SelectList(_context.Set<StatusForDict>(), "Id", "Name", dictLegalForm.StatusForDictId);
            return View(dictLegalForm);
        }

        // GET: Media/DictLegalForms/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dictLegalForm = await _context.DictLegalForm.FindAsync(id);
            if (dictLegalForm == null)
            {
                return NotFound();
            }
            ViewData["StatusForDictId"] = new SelectList(_context.Set<StatusForDict>(), "Id", "Name", dictLegalForm.StatusForDictId);
            return View(dictLegalForm);
        }

        // POST: Media/DictLegalForms/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,NameKyrg,NameRus,CreateDate,StatusForDictId,DeactiveDate")] DictLegalForm dictLegalForm)
        {
            if (id != dictLegalForm.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(dictLegalForm);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DictLegalFormExists(dictLegalForm.Id))
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
            ViewData["StatusForDictId"] = new SelectList(_context.Set<StatusForDict>(), "Id", "Name", dictLegalForm.StatusForDictId);
            return View(dictLegalForm);
        }

        // GET: Media/DictLegalForms/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dictLegalForm = await _context.DictLegalForm
                .Include(d => d.StatusForDict)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (dictLegalForm == null)
            {
                return NotFound();
            }

            return View(dictLegalForm);
        }

        // POST: Media/DictLegalForms/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var dictLegalForm = await _context.DictLegalForm.FindAsync(id);
            _context.DictLegalForm.Remove(dictLegalForm);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DictLegalFormExists(int id)
        {
            return _context.DictLegalForm.Any(e => e.Id == id);
        }
    }
}
