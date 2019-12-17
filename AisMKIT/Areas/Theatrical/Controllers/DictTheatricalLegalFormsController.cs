using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AisMKIT.Data;
using AisMKIT.Models;

namespace AisMKIT.Areas.Theatrical.Controllers
{
    [Area("Theatrical")]
    public class DictTheatricalLegalFormsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public DictTheatricalLegalFormsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Theatrical/DictTheatricalLegalForms
        public async Task<IActionResult> Index()
        {
            return View(await _context.DictTheatricalLegalForm.ToListAsync());
        }

        // GET: Theatrical/DictTheatricalLegalForms/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dictTheatricalLegalForm = await _context.DictTheatricalLegalForm
                .FirstOrDefaultAsync(m => m.Id == id);
            if (dictTheatricalLegalForm == null)
            {
                return NotFound();
            }

            return View(dictTheatricalLegalForm);
        }

        // GET: Theatrical/DictTheatricalLegalForms/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Theatrical/DictTheatricalLegalForms/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,NameKyrg,NameRus")] DictTheatricalLegalForm dictTheatricalLegalForm)
        {
            if (ModelState.IsValid)
            {
                _context.Add(dictTheatricalLegalForm);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(dictTheatricalLegalForm);
        }

        // GET: Theatrical/DictTheatricalLegalForms/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dictTheatricalLegalForm = await _context.DictTheatricalLegalForm.FindAsync(id);
            if (dictTheatricalLegalForm == null)
            {
                return NotFound();
            }
            return View(dictTheatricalLegalForm);
        }

        // POST: Theatrical/DictTheatricalLegalForms/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,NameKyrg,NameRus")] DictTheatricalLegalForm dictTheatricalLegalForm)
        {
            if (id != dictTheatricalLegalForm.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(dictTheatricalLegalForm);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DictTheatricalLegalFormExists(dictTheatricalLegalForm.Id))
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
            return View(dictTheatricalLegalForm);
        }

        // GET: Theatrical/DictTheatricalLegalForms/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dictTheatricalLegalForm = await _context.DictTheatricalLegalForm
                .FirstOrDefaultAsync(m => m.Id == id);
            if (dictTheatricalLegalForm == null)
            {
                return NotFound();
            }

            return View(dictTheatricalLegalForm);
        }

        // POST: Theatrical/DictTheatricalLegalForms/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var dictTheatricalLegalForm = await _context.DictTheatricalLegalForm.FindAsync(id);
            _context.DictTheatricalLegalForm.Remove(dictTheatricalLegalForm);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DictTheatricalLegalFormExists(int id)
        {
            return _context.DictTheatricalLegalForm.Any(e => e.Id == id);
        }
    }
}
