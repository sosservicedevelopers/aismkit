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
    public class ListOfTheatricalsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ListOfTheatricalsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Theatrical/ListOfTheatricals
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.ListOfTheatrical.Include(l => l.DictTheatricalFinSource).Include(l => l.DictTheatricalLegalForm);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Theatrical/ListOfTheatricals/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var listOfTheatrical = await _context.ListOfTheatrical
                .Include(l => l.DictTheatricalFinSource)
                .Include(l => l.DictTheatricalLegalForm)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (listOfTheatrical == null)
            {
                return NotFound();
            }

            return View(listOfTheatrical);
        }

        // GET: Theatrical/ListOfTheatricals/Create
        public IActionResult Create()
        {
            ViewData["DictTheatricalFinSourceId"] = new SelectList(_context.DictTheatricalFinSource, "Id", "NameRus");
            ViewData["DictTheatricalLegalFormId"] = new SelectList(_context.DictTheatricalLegalForm, "Id", "NameRus");
            return View();
        }

        // POST: Theatrical/ListOfTheatricals/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,NameRus,NameKyrg,DictTheatricalLegalFormId,INN,LastNameDirector,FirstNameDirector,PatronicNameDirector,LastNameOfArtsDirector,FirstNameOfArtsDirector,PatronicNameOfArtsDirector,NumEmployees,DictTheatricalFinSourceId,ReregistrationDate,DeactiveDate")] ListOfTheatrical listOfTheatrical)
        {
            if (ModelState.IsValid)
            {
                _context.Add(listOfTheatrical);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["DictTheatricalFinSourceId"] = new SelectList(_context.DictTheatricalFinSource, "Id", "NameRus", listOfTheatrical.DictTheatricalFinSourceId);
            ViewData["DictTheatricalLegalFormId"] = new SelectList(_context.DictTheatricalLegalForm, "Id", "NameRus", listOfTheatrical.DictTheatricalLegalFormId);
            return View(listOfTheatrical);
        }

        // GET: Theatrical/ListOfTheatricals/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var listOfTheatrical = await _context.ListOfTheatrical.FindAsync(id);
            if (listOfTheatrical == null)
            {
                return NotFound();
            }
            ViewData["DictTheatricalFinSourceId"] = new SelectList(_context.DictTheatricalFinSource, "Id", "NameRus", listOfTheatrical.DictTheatricalFinSourceId);
            ViewData["DictTheatricalLegalFormId"] = new SelectList(_context.DictTheatricalLegalForm, "Id", "NameRus", listOfTheatrical.DictTheatricalLegalFormId);
            return View(listOfTheatrical);
        }

        // POST: Theatrical/ListOfTheatricals/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,NameRus,NameKyrg,DictTheatricalLegalFormId,INN,LastNameDirector,FirstNameDirector,PatronicNameDirector,LastNameOfArtsDirector,FirstNameOfArtsDirector,PatronicNameOfArtsDirector,NumEmployees,DictTheatricalFinSourceId,ReregistrationDate,DeactiveDate")] ListOfTheatrical listOfTheatrical)
        {
            if (id != listOfTheatrical.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(listOfTheatrical);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ListOfTheatricalExists(listOfTheatrical.Id))
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
            ViewData["DictTheatricalFinSourceId"] = new SelectList(_context.DictTheatricalFinSource, "Id", "NameRus", listOfTheatrical.DictTheatricalFinSourceId);
            ViewData["DictTheatricalLegalFormId"] = new SelectList(_context.DictTheatricalLegalForm, "Id", "NameRus", listOfTheatrical.DictTheatricalLegalFormId);
            return View(listOfTheatrical);
        }

        // GET: Theatrical/ListOfTheatricals/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var listOfTheatrical = await _context.ListOfTheatrical
                .Include(l => l.DictTheatricalFinSource)
                .Include(l => l.DictTheatricalLegalForm)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (listOfTheatrical == null)
            {
                return NotFound();
            }

            return View(listOfTheatrical);
        }

        // POST: Theatrical/ListOfTheatricals/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var listOfTheatrical = await _context.ListOfTheatrical.FindAsync(id);
            _context.ListOfTheatrical.Remove(listOfTheatrical);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ListOfTheatricalExists(int id)
        {
            return _context.ListOfTheatrical.Any(e => e.Id == id);
        }
    }
}
