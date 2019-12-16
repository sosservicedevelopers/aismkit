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
    public class ListOfMediasController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ListOfMediasController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Media/ListOfMedias
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.ListOfMedia.Include(l => l.DictAgencyPerm).Include(l => l.DictDistrict).Include(l => l.DictLangMediaType).Include(l => l.DictMediaFinSource).Include(l => l.DictMediaFreqRelease).Include(l => l.DictMediaType);
            return View(await applicationDbContext.ToListAsync());
        }

        public async Task<IActionResult> IndexKyrg()
        {
            var applicationDbContext = _context.ListOfMedia.Include(l => l.DictAgencyPerm).Include(l => l.DictDistrict).Include(l => l.DictLangMediaType).Include(l => l.DictMediaFinSource).Include(l => l.DictMediaFreqRelease).Include(l => l.DictMediaType);
            return View(await applicationDbContext.ToListAsync());
        }

        public async Task<IActionResult> IndexRus()
        {
            var applicationDbContext = _context.ListOfMedia.Include(l => l.DictAgencyPerm).Include(l => l.DictDistrict).Include(l => l.DictLangMediaType).Include(l => l.DictMediaFinSource).Include(l => l.DictMediaFreqRelease).Include(l => l.DictMediaType);
            return View(await applicationDbContext.ToListAsync());
        }


        // GET: Media/ListOfMedias/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var listOfMedia = await _context.ListOfMedia
                .Include(l => l.DictAgencyPerm)
                .Include(l => l.DictDistrict)
                .Include(l => l.DictLangMediaType)
                .Include(l => l.DictMediaFinSource)
                .Include(l => l.DictMediaFreqRelease)
                .Include(l => l.DictMediaType)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (listOfMedia == null)
            {
                return NotFound();
            }

            return View(listOfMedia);
        }

        // GET: Media/ListOfMedias/Create
        public IActionResult Create()
        {
            ViewData["DictAgencyPermId"] = new SelectList(_context.Set<DictAgencyPerm>(), "Id", "NameAllLangs");
            ViewData["DictDistrictId"] = new SelectList(_context.DictDistrict, "Id", "NameAllLangs");
            ViewData["DictLangMediaTypeId"] = new SelectList(_context.DictLangMediaType, "Id", "NameAllLangs");
            ViewData["DictMediaFinSourceId"] = new SelectList(_context.DictMediaFinSource, "Id", "NameAllLangs");
            ViewData["DictMediaFreqReleaseId"] = new SelectList(_context.DictMediaFreqRelease, "Id", "NameAllLangs");
            ViewData["DictMediaTypeId"] = new SelectList(_context.DictMediaType, "Id", "NameAllLangs");
            return View();
        }

        // POST: Media/ListOfMedias/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,NameRus,NameKyrg,INN,RegistrationDate,Name,DictLangMediaTypeId,DictMediaTypeId,AddressRus,AddressKyrg,DictDistrictId,DictMediaFreqReleaseId,DictMediaFinSourceId,ReregistrationDate,EliminationDate,NumberOfPermission,PermissionDate,DictAgencyPermId,DateOfPay,NumOfPermGas,PermGASDate,PermElimGASDate")] ListOfMedia listOfMedia)
        {
            if (ModelState.IsValid)
            {
                _context.Add(listOfMedia);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["DictAgencyPermId"] = new SelectList(_context.Set<DictAgencyPerm>(), "Id", "NameAllLangs", listOfMedia.DictAgencyPermId);
            ViewData["DictDistrictId"] = new SelectList(_context.DictDistrict, "Id", "NameAllLangs", listOfMedia.DictDistrictId);
            ViewData["DictLangMediaTypeId"] = new SelectList(_context.DictLangMediaType, "Id", "NameAllLangs", listOfMedia.DictLangMediaTypeId);
            ViewData["DictMediaFinSourceId"] = new SelectList(_context.DictMediaFinSource, "Id", "NameAllLangs", listOfMedia.DictMediaFinSourceId);
            ViewData["DictMediaFreqReleaseId"] = new SelectList(_context.DictMediaFreqRelease, "Id", "NameAllLangs", listOfMedia.DictMediaFreqReleaseId);
            ViewData["DictMediaTypeId"] = new SelectList(_context.DictMediaType, "Id", "NameAllLangs", listOfMedia.DictMediaTypeId);
            return View(listOfMedia);
        }

        // GET: Media/ListOfMedias/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var listOfMedia = await _context.ListOfMedia.FindAsync(id);
            if (listOfMedia == null)
            {
                return NotFound();
            }
            ViewData["DictAgencyPermId"] = new SelectList(_context.Set<DictAgencyPerm>(), "Id", "NameAllLangs", listOfMedia.DictAgencyPermId);
            ViewData["DictDistrictId"] = new SelectList(_context.DictDistrict, "Id", "NameAllLangs", listOfMedia.DictDistrictId);
            ViewData["DictLangMediaTypeId"] = new SelectList(_context.DictLangMediaType, "Id", "NameAllLangs", listOfMedia.DictLangMediaTypeId);
            ViewData["DictMediaFinSourceId"] = new SelectList(_context.DictMediaFinSource, "Id", "NameAllLangs", listOfMedia.DictMediaFinSourceId);
            ViewData["DictMediaFreqReleaseId"] = new SelectList(_context.DictMediaFreqRelease, "Id", "NameAllLangs", listOfMedia.DictMediaFreqReleaseId);
            ViewData["DictMediaTypeId"] = new SelectList(_context.DictMediaType, "Id", "NameAllLangs", listOfMedia.DictMediaTypeId);
            return View(listOfMedia);
        }

        // POST: Media/ListOfMedias/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,NameRus,NameKyrg,INN,RegistrationDate,Name,DictLangMediaTypeId,DictMediaTypeId,AddressRus,AddressKyrg,DictDistrictId,DictMediaFreqReleaseId,DictMediaFinSourceId,ReregistrationDate,EliminationDate,NumberOfPermission,PermissionDate,DictAgencyPermId,DateOfPay,NumOfPermGas,PermGASDate,PermElimGASDate")] ListOfMedia listOfMedia)
        {
            if (id != listOfMedia.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(listOfMedia);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ListOfMediaExists(listOfMedia.Id))
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
            ViewData["DictAgencyPermId"] = new SelectList(_context.Set<DictAgencyPerm>(), "Id", "NameAllLangs", listOfMedia.DictAgencyPermId);
            ViewData["DictDistrictId"] = new SelectList(_context.DictDistrict, "Id", "NameAllLangs", listOfMedia.DictDistrictId);
            ViewData["DictLangMediaTypeId"] = new SelectList(_context.DictLangMediaType, "Id", "NameAllLangs", listOfMedia.DictLangMediaTypeId);
            ViewData["DictMediaFinSourceId"] = new SelectList(_context.DictMediaFinSource, "Id", "NameAllLangs", listOfMedia.DictMediaFinSourceId);
            ViewData["DictMediaFreqReleaseId"] = new SelectList(_context.DictMediaFreqRelease, "Id", "NameAllLangs", listOfMedia.DictMediaFreqReleaseId);
            ViewData["DictMediaTypeId"] = new SelectList(_context.DictMediaType, "Id", "NameAllLangs", listOfMedia.DictMediaTypeId);
            return View(listOfMedia);
        }

        // GET: Media/ListOfMedias/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var listOfMedia = await _context.ListOfMedia
                .Include(l => l.DictAgencyPerm)
                .Include(l => l.DictDistrict)
                .Include(l => l.DictLangMediaType)
                .Include(l => l.DictMediaFinSource)
                .Include(l => l.DictMediaFreqRelease)
                .Include(l => l.DictMediaType)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (listOfMedia == null)
            {
                return NotFound();
            }

            return View(listOfMedia);
        }

        // POST: Media/ListOfMedias/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var listOfMedia = await _context.ListOfMedia.FindAsync(id);
            _context.ListOfMedia.Remove(listOfMedia);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ListOfMediaExists(int id)
        {
            return _context.ListOfMedia.Any(e => e.Id == id);
        }
    }
}
