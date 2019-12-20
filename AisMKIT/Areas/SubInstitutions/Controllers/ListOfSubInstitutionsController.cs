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

namespace AisMKIT.Areas.SubInstitutions.Controllers
{
    [Area("SubInstitutions")]
    public class ListOfSubInstitutionsController : Controller
    {
        private readonly ApplicationDbContext _context;

        private readonly IWebHostEnvironment _appEnvironment;

        private readonly string _titleOfFile = "Реестр_подведомстенных_учреждений";


        public ListOfSubInstitutionsController(ApplicationDbContext context, IWebHostEnvironment webHostEnvironment)
        {
            _context = context;

            _appEnvironment = webHostEnvironment;
        }

        // GET: SubInstitutions/GetDicts/5
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

            MkitFile file = ffl.CreateExcel<ListOfSubInstitutions>(_titleOfFile, _context.ListOfSubInstitutions.ToList(), _appEnvironment);

            return File(file.Bytes, file.Type, file.Name);
        }

        public string GetHtml()
        {
            var model = _context.ListOfMonument.FirstOrDefault();

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
                Электронная почта 
            </td>
            <td>
               Адрес (Руск) 
            </td>
            <td>
                Регион (Руск.) 
            </td> 
            <td>
                Район (Руск.) 
            </td>
        </tr>";

            string tbody = "";
            var list = _context.ListOfSubInstitutions
                .Include(c => c.DictDistrict)
                .Include(c => c.DictRegion)
                .ToList();

            foreach (var item in list)
            {
                tbody += "<tr><td>" + item.NameRus + "</td>";
                tbody += "<td>" + item.INN + "</td>";
                tbody += "<td>" + item.Email + "</td>";
                tbody += "<td>" + item.AddressRus + "</td>";
                tbody += "<td>" + item.DictRegion.NameRus + "</td>";
                tbody += "<td>" + item.DictDistrict.NameRus + "</td></tr>";
            }

            string result = "<table><thead>" + thead + "</thead><tbody> " + tbody + " </tbody></table>";

            return result;
        }

    }
}
