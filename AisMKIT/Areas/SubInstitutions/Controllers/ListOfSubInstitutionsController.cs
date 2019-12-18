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
    public class ListOfSubInstitutionsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ListOfSubInstitutionsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: SubInstitutions/ListOfSubInstitutions
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.ListOfSubInstitutions.Include(l => l.DictDistrict).Include(l => l.DictRegion).Include(l => l.DictTypeOfSub);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: SubInstitutions/ListOfSubInstitutions/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var listOfSubInstitutions = await _context.ListOfSubInstitutions
                .Include(l => l.DictDistrict)
                .Include(l => l.DictRegion)
                .Include(l => l.DictTypeOfSub)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (listOfSubInstitutions == null)
            {
                return NotFound();
            }

            return View(listOfSubInstitutions);
        }

        // GET: SubInstitutions/ListOfSubInstitutions/Create
        public IActionResult Create()
        {
            ViewData["DictDistrictId"] = new SelectList(_context.DictDistrict, "Id", "NameRus");
            ViewData["DictRegionId"] = new SelectList(_context.DictRegion, "Id", "NameRus");
            ViewData["DictTypeOfSubId"] = new SelectList(_context.DictTypeOfSub, "Id", "NameRus");
            return View();
        }

        // POST: SubInstitutions/ListOfSubInstitutions/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,NameRus,NameKyrg,INN,DictTypeOfSubId,Fax,Email,DateOfCreated,BriefInfo,DictRegionId,DictDistrictId,AddressRus,AddressKyrg")] ListOfSubInstitutions listOfSubInstitutions)
        {
            if (ModelState.IsValid)
            {
                _context.Add(listOfSubInstitutions);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["DictDistrictId"] = new SelectList(_context.DictDistrict, "Id", "NameRus", listOfSubInstitutions.DictDistrictId);
            ViewData["DictRegionId"] = new SelectList(_context.DictRegion, "Id", "NameRus", listOfSubInstitutions.DictRegionId);
            ViewData["DictTypeOfSubId"] = new SelectList(_context.DictTypeOfSub, "Id", "NameRus", listOfSubInstitutions.DictTypeOfSubId);
            return View(listOfSubInstitutions);
        }

        // GET: SubInstitutions/ListOfSubInstitutions/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var listOfSubInstitutions = await _context.ListOfSubInstitutions.FindAsync(id);
            if (listOfSubInstitutions == null)
            {
                return NotFound();
            }
            ViewData["DictDistrictId"] = new SelectList(_context.DictDistrict, "Id", "NameRus", listOfSubInstitutions.DictDistrictId);
            ViewData["DictRegionId"] = new SelectList(_context.DictRegion, "Id", "NameRus", listOfSubInstitutions.DictRegionId);
            ViewData["DictTypeOfSubId"] = new SelectList(_context.DictTypeOfSub, "Id", "NameRus", listOfSubInstitutions.DictTypeOfSubId);
            return View(listOfSubInstitutions);
        }

        // POST: SubInstitutions/ListOfSubInstitutions/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,NameRus,NameKyrg,INN,DictTypeOfSubId,Fax,Email,DateOfCreated,BriefInfo,DictRegionId,DictDistrictId,AddressRus,AddressKyrg")] ListOfSubInstitutions listOfSubInstitutions)
        {
            if (id != listOfSubInstitutions.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(listOfSubInstitutions);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ListOfSubInstitutionsExists(listOfSubInstitutions.Id))
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
            ViewData["DictDistrictId"] = new SelectList(_context.DictDistrict, "Id", "NameRus", listOfSubInstitutions.DictDistrictId);
            ViewData["DictRegionId"] = new SelectList(_context.DictRegion, "Id", "NameRus", listOfSubInstitutions.DictRegionId);
            ViewData["DictTypeOfSubId"] = new SelectList(_context.DictTypeOfSub, "Id", "NameRus", listOfSubInstitutions.DictTypeOfSubId);
            return View(listOfSubInstitutions);
        }

        // GET: SubInstitutions/ListOfSubInstitutions/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var listOfSubInstitutions = await _context.ListOfSubInstitutions
                .Include(l => l.DictDistrict)
                .Include(l => l.DictRegion)
                .Include(l => l.DictTypeOfSub)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (listOfSubInstitutions == null)
            {
                return NotFound();
            }

            return View(listOfSubInstitutions);
        }

        // POST: SubInstitutions/ListOfSubInstitutions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var listOfSubInstitutions = await _context.ListOfSubInstitutions.FindAsync(id);
            _context.ListOfSubInstitutions.Remove(listOfSubInstitutions);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ListOfSubInstitutionsExists(int id)
        {
            return _context.ListOfSubInstitutions.Any(e => e.Id == id);
        }
    }
}
