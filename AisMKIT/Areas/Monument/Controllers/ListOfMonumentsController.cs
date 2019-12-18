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
    public class ListOfMonumentsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ListOfMonumentsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Monument/ListOfMonuments
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.ListOfMonument.Include(l => l.DictDistrict).Include(l => l.DictRegion).Include(l => l.DictTypeOfMonument);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Monument/ListOfMonuments/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var listOfMonument = await _context.ListOfMonument
                .Include(l => l.DictDistrict)
                .Include(l => l.DictRegion)
                .Include(l => l.DictTypeOfMonument)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (listOfMonument == null)
            {
                return NotFound();
            }

            return View(listOfMonument);
        }

        // GET: Monument/ListOfMonuments/Create
        public IActionResult Create()
        {
            ViewData["DictDistrictId"] = new SelectList(_context.DictDistrict, "Id", "NameRus");
            ViewData["DictRegionId"] = new SelectList(_context.DictRegion, "Id", "NameRus");
            ViewData["DictTypeOfMonumentId"] = new SelectList(_context.Set<DictTypeOfMonument>(), "Id", "NameRus");
            return View();
        }

        // POST: Monument/ListOfMonuments/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,DictTypeOfMonumentId,DateOfMonument,DictRegionId,DictDistrictId,Address")] ListOfMonument listOfMonument)
        {
            if (ModelState.IsValid)
            {
                _context.Add(listOfMonument);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["DictDistrictId"] = new SelectList(_context.DictDistrict, "Id", "NameRus", listOfMonument.DictDistrictId);
            ViewData["DictRegionId"] = new SelectList(_context.DictRegion, "Id", "NameRus", listOfMonument.DictRegionId);
            ViewData["DictTypeOfMonumentId"] = new SelectList(_context.Set<DictTypeOfMonument>(), "Id", "NameRus", listOfMonument.DictTypeOfMonumentId);
            return View(listOfMonument);
        }

        // GET: Monument/ListOfMonuments/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var listOfMonument = await _context.ListOfMonument.FindAsync(id);
            if (listOfMonument == null)
            {
                return NotFound();
            }
            ViewData["DictDistrictId"] = new SelectList(_context.DictDistrict, "Id", "NameRus", listOfMonument.DictDistrictId);
            ViewData["DictRegionId"] = new SelectList(_context.DictRegion, "Id", "NameRus", listOfMonument.DictRegionId);
            ViewData["DictTypeOfMonumentId"] = new SelectList(_context.Set<DictTypeOfMonument>(), "Id", "NameRus", listOfMonument.DictTypeOfMonumentId);
            return View(listOfMonument);
        }

        // POST: Monument/ListOfMonuments/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,DictTypeOfMonumentId,DateOfMonument,DictRegionId,DictDistrictId,Address")] ListOfMonument listOfMonument)
        {
            if (id != listOfMonument.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(listOfMonument);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ListOfMonumentExists(listOfMonument.Id))
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
            ViewData["DictDistrictId"] = new SelectList(_context.DictDistrict, "Id", "NameRus", listOfMonument.DictDistrictId);
            ViewData["DictRegionId"] = new SelectList(_context.DictRegion, "Id", "NameRus", listOfMonument.DictRegionId);
            ViewData["DictTypeOfMonumentId"] = new SelectList(_context.Set<DictTypeOfMonument>(), "Id", "NameRus", listOfMonument.DictTypeOfMonumentId);
            return View(listOfMonument);
        }

        // GET: Monument/ListOfMonuments/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var listOfMonument = await _context.ListOfMonument
                .Include(l => l.DictDistrict)
                .Include(l => l.DictRegion)
                .Include(l => l.DictTypeOfMonument)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (listOfMonument == null)
            {
                return NotFound();
            }

            return View(listOfMonument);
        }

        // POST: Monument/ListOfMonuments/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var listOfMonument = await _context.ListOfMonument.FindAsync(id);
            _context.ListOfMonument.Remove(listOfMonument);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ListOfMonumentExists(int id)
        {
            return _context.ListOfMonument.Any(e => e.Id == id);
        }
    }
}
