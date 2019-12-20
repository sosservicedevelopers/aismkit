using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AisMKIT.Data;
using AisMKIT.Models;

using Microsoft.AspNetCore.Hosting;
using AisMKIT.ExtraClasses;

namespace AisMKIT.Areas.Media.Controllers
{
    [Area("Media")]
    public class ListOfMediasController : Controller
    {
        private readonly ApplicationDbContext _context;

        private readonly IWebHostEnvironment _appEnvironment;

        private readonly string _titleOfFile = "Реестр_СМИ";


        public ListOfMediasController(ApplicationDbContext context, IWebHostEnvironment webHostEnvironment)
        {
            _context = context;

            _appEnvironment = webHostEnvironment;
        }


        // GET: Media/GetDicts/5
        public JsonResult GetDicts(int id)
        {
            List<DictDistrict> dicts = _context.DictDistrict
                .Include(d => d.DictRegion)
                .Where(d => d.DictRegionId == id)
                .ToList();

            List<SelectListItem> data = new List<SelectListItem>();

            foreach (var item in dicts)
            {
                data.Add(new SelectListItem { Text = item.NameRus, Value = item.Id + "" });
            }

            return Json(new SelectList(data, "Value", "Text"));
        }

        // GET: Media/ListOfMedias
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.ListOfMedia
                .Include(l => l.DictAgencyPerm)
                .Include(l => l.DictDistrict)
                .Include(l => l.DictLangMediaType)
                .Include(l => l.DictMediaFinSource)
                .Include(l => l.DictMediaFreqRelease)
                .Include(l => l.DictLegalForm)
                .Include(l => l.DictDistribTerritoryMedia)
                .Include(l => l.DictRegion)
                .Include(l => l.DictMediaType); 



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
                .Include(l => l.DictLegalForm)
                .Include(l => l.DictDistribTerritoryMedia)
                .Include(l => l.DictRegion)
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
            ViewData["DictAgencyPermId"] = new SelectList(_context.Set<DictAgencyPerm>(), "Id", "NameRus");
            ViewData["DictDistrictId"] = new SelectList(_context.DictDistrict, "Id", "NameRus");
            ViewData["DictLangMediaTypeId"] = new SelectList(_context.DictLangMediaType, "Id", "NameRus");
            ViewData["DictMediaFinSourceId"] = new SelectList(_context.DictMediaFinSource, "Id", "NameRus");
            ViewData["DictMediaFreqReleaseId"] = new SelectList(_context.DictMediaFreqRelease, "Id", "NameRus");
            ViewData["DictMediaTypeId"] = new SelectList(_context.DictMediaType, "Id", "NameRus");
            ViewData["DictDistribTerritoryMediaId"] = new SelectList(_context.DictDistribTerritoryMedia, "Id", "NameRus");
            ViewData["DictRegionId"] = new SelectList(_context.DictRegion, "Id", "NameRus");
            ViewData["DictLegalFormId"] = new SelectList(_context.DictLegalForm, "Id", "NameRus");
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
            ViewData["DictAgencyPermId"] = new SelectList(_context.Set<DictAgencyPerm>(), "Id", "NameRus");
            ViewData["DictDistrictId"] = new SelectList(_context.DictDistrict, "Id", "NameRus");
            ViewData["DictLangMediaTypeId"] = new SelectList(_context.DictLangMediaType, "Id", "NameRus");
            ViewData["DictMediaFinSourceId"] = new SelectList(_context.DictMediaFinSource, "Id", "NameRus");
            ViewData["DictMediaFreqReleaseId"] = new SelectList(_context.DictMediaFreqRelease, "Id", "NameRus");
            ViewData["DictMediaTypeId"] = new SelectList(_context.DictMediaType, "Id", "NameRus");
            ViewData["DictDistribTerritoryMediaId"] = new SelectList(_context.DictDistribTerritoryMedia, "Id", "NameRus");
            ViewData["DictRegionId"] = new SelectList(_context.DictRegion, "Id", "NameRus");
            ViewData["DictLegalFormId"] = new SelectList(_context.DictLegalForm, "Id", "NameRus");
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
            ViewData["DictAgencyPermId"] = new SelectList(_context.Set<DictAgencyPerm>(), "Id", "NameRus");
            ViewData["DictDistrictId"] = new SelectList(_context.DictDistrict, "Id", "NameRus");
            ViewData["DictLangMediaTypeId"] = new SelectList(_context.DictLangMediaType, "Id", "NameRus");
            ViewData["DictMediaFinSourceId"] = new SelectList(_context.DictMediaFinSource, "Id", "NameRus");
            ViewData["DictMediaFreqReleaseId"] = new SelectList(_context.DictMediaFreqRelease, "Id", "NameRus");
            ViewData["DictMediaTypeId"] = new SelectList(_context.DictMediaType, "Id", "NameRus");
            ViewData["DictDistribTerritoryMediaId"] = new SelectList(_context.DictDistribTerritoryMedia, "Id", "NameRus");
            ViewData["DictRegionId"] = new SelectList(_context.DictRegion, "Id", "NameRus");
            ViewData["DictLegalFormId"] = new SelectList(_context.DictLegalForm, "Id", "NameRus");
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
            ViewData["DictAgencyPermId"] = new SelectList(_context.Set<DictAgencyPerm>(), "Id", "NameRus");
            ViewData["DictDistrictId"] = new SelectList(_context.DictDistrict, "Id", "NameRus");
            ViewData["DictLangMediaTypeId"] = new SelectList(_context.DictLangMediaType, "Id", "NameRus");
            ViewData["DictMediaFinSourceId"] = new SelectList(_context.DictMediaFinSource, "Id", "NameRus");
            ViewData["DictMediaFreqReleaseId"] = new SelectList(_context.DictMediaFreqRelease, "Id", "NameRus");
            ViewData["DictMediaTypeId"] = new SelectList(_context.DictMediaType, "Id", "NameRus");
            ViewData["DictDistribTerritoryMediaId"] = new SelectList(_context.DictDistribTerritoryMedia, "Id", "NameRus");
            ViewData["DictRegionId"] = new SelectList(_context.DictRegion, "Id", "NameRus");
            ViewData["DictLegalFormId"] = new SelectList(_context.DictLegalForm, "Id", "NameRus");
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
                .Include(l => l.DictLegalForm)
                .Include(l => l.DictDistribTerritoryMedia)
                .Include(l => l.DictRegion)
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


        public FileResult GetPdf()
        {
            string html = GetHtml();

            FilesFromLists ffl = new FilesFromLists();

            MkitFile file = ffl.CreatePdf(_titleOfFile, html, _appEnvironment);

            return File(file.Bytes, file.Type, file.Name);
        }

        public FileResult GetExcel()
        {

            FilesFromLists ffl = new FilesFromLists();

            MkitFile file = ffl.CreateExcel<ListOfMedia>(_titleOfFile, _context.ListOfMedia.ToList(), _appEnvironment);

            return File(file.Bytes, file.Type, file.Name);
        }

        public string GetHtml()
        {
            var model = _context.ListOfMedia.FirstOrDefault();

            if (model == null)
            {
                return "<h1>нет данных в таблице</h1>";
            }

            string thead = @"
        <tr>
            <td>
                Наименование органа СМИ (Рус.) 
            </td>
            <td>
                ИНН 
            </td>
            <td>
               Дата регистрации
            </td>
            <td>
                Язык вещания СМИ (Русск)
            </td>
            <td>
                Наименование вида СМИ (Русск) 
            </td>
            <td>
               Адрес (Руск) 
            </td>
            <td>
                Район (кырг.) 
            </td>
            <td>
               Источник финансирования (Русск) 
            </td>
            <td>
               Дата перерегистрации
            </td>
            <td>
                Дата ликвидации
            </td>
            <td>
               Номер разрешения
            </td>
        </tr>";

            string tbody = "";

            var list = _context.ListOfMedia
                .Include(c => c.DictLangMediaType)
                .Include(c => c.DictDistrict)
                .Include(c => c.DictMediaFinSource)
                .ToList();

            foreach (var item in list)
            {
                tbody += "<tr><td>" + item.NameRus + "</td>";
                tbody += "<td>" + item.INN + "</td>";
                tbody += "<td>" + item.RegistrationDate + "</td>";
                tbody += "<td>" + item.DictLangMediaType.NameRus + "</td>";
                tbody += "<td>" + item.Name + "</td>";
                tbody += "<td>" + item.AddressRus + "</td>";
                tbody += "<td>" + item.DictDistrict.NameRus + "</td>";
                tbody += "<td>" + item.DictMediaFinSource.NameRus + "</td>";
                tbody += "<td>" + item.ReregistrationDate + "</td>";
                tbody += "<td>" + item.EliminationDate + "</td>";
                tbody += "<td>" + item.NumberOfPermission + "</td></tr>";
            }

            string result = "<table><thead>" + thead + "</thead><tbody> " + tbody + " </tbody></table>";

            return result;
        }

    }
}
