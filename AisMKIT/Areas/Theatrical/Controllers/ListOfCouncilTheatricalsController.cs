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
    public class ListOfCouncilTheatricalsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ListOfCouncilTheatricalsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Theatrical/ListOfCouncilTheatricals
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.ListOfCouncilTheatrical
                .Include(l => l.ListOfTheatrical);

            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Theatrical/ListOfCouncilTheatricals/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var listOfCouncilTheatrical = await _context.ListOfCouncilTheatrical
                .Include(l => l.ListOfTheatrical)
                .FirstOrDefaultAsync(m => m.Id == id);

            if (listOfCouncilTheatrical == null)
            {
                return NotFound();
            }

            return View(listOfCouncilTheatrical);
        }

        // GET: Theatrical/ListOfCouncilTheatricals/Create
        public IActionResult Create()
        {
            ViewData["ListOfTheatricalId"] = new SelectList(_context.ListOfTheatrical, "Id", "NameRus");

            return View();
        }

        // POST: Theatrical/ListOfCouncilTheatricals/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,LastNameOfArts,FirstNameOfArts,PatronicNameOfArts,DateInArtCouncil,DateOutArtCouncil, ListOfTheatricalId")] ListOfCouncilTheatrical listOfCouncilTheatrical)
        {
            if (ModelState.IsValid)
            {
                _context.Add(listOfCouncilTheatrical);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            else
            {

            } 

            ViewData["ListOfTheatricalId"] = new SelectList(_context.ListOfTheatrical, "Id", "NameRus");

            return View(listOfCouncilTheatrical);
        }

        // GET: Theatrical/ListOfCouncilTheatricals/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var listOfCouncilTheatrical = await _context.ListOfCouncilTheatrical.FindAsync(id);
            if (listOfCouncilTheatrical == null)
            {
                return NotFound();
            }
            ViewData["ListOfTheatricalId"] = new SelectList(_context.ListOfTheatrical, "Id", "NameRus");

            return View(listOfCouncilTheatrical);
        }

        // POST: Theatrical/ListOfCouncilTheatricals/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,LastNameOfArts,FirstNameOfArts,PatronicNameOfArts,DateInArtCouncil,DateOutArtCouncil, ListOfTheatricalId")] ListOfCouncilTheatrical listOfCouncilTheatrical)
        {
            if (id != listOfCouncilTheatrical.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(listOfCouncilTheatrical);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ListOfCouncilTheatricalExists(listOfCouncilTheatrical.Id))
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
            ViewData["ListOfTheatricalId"] = new SelectList(_context.ListOfTheatrical, "Id", "NameRus");

            return View(listOfCouncilTheatrical);
        }

        // GET: Theatrical/ListOfCouncilTheatricals/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var listOfCouncilTheatrical = await _context.ListOfCouncilTheatrical
                .Include(m => m.ListOfTheatrical)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (listOfCouncilTheatrical == null)
            {
                return NotFound();
            }

            return View(listOfCouncilTheatrical);
        }

        // POST: Theatrical/ListOfCouncilTheatricals/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var listOfCouncilTheatrical = await _context.ListOfCouncilTheatrical.FindAsync(id);
            _context.ListOfCouncilTheatrical.Remove(listOfCouncilTheatrical);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ListOfCouncilTheatricalExists(int id)
        {
            return _context.ListOfCouncilTheatrical.Any(e => e.Id == id);
        }
    }
}
