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

namespace AisMKIT.Areas.Monument.Controllers
{
    [Area("Monument")]
    public class ListOfMonumentsController : Controller
    {
        private readonly ApplicationDbContext _context;

        private readonly IWebHostEnvironment _appEnvironment;

        private readonly string _titleOfFile = "Список_памятников";


        public ListOfMonumentsController(ApplicationDbContext context, IWebHostEnvironment webHostEnvironment)
        {
            _context = context;

            _appEnvironment = webHostEnvironment;
        }



        // GET: Monument/GetDicts/5
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

        // GET: Monument/ListOfMonuments
        public async Task<IActionResult> Index()
        {


            var applicationDbContext = _context.ListOfMonument
                .Include(l => l.DictDistrict)
                .Include(l => l.DictRegion)
                .Include(l => l.DictAffiliationOfMonument)
                .Include(l => l.DictTypeOfOjbectMonument)
                .Include(l => l.DictTypeOfMonument);

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
                .Include(l => l.DictTypeOfOjbectMonument)
                .Include(l => l.DictAffiliationOfMonument)
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
            DictRegion region = _context.DictRegion.FirstOrDefault();

            try
            {
                // чтобы по умолчанию не передавать все районы, здесь 
                // передаётся только районы к-е входят в первый регион в БД
                List<DictDistrict> dicts = _context.DictDistrict
                    .Include(d => d.DictRegion)
                    .Where(d => d.DictRegionId == region.Id)
                    .ToList();

                ViewData["DictDistrictId"] = new SelectList(dicts, "Id", "NameRus");
                ViewData["DictRegionId"] = new SelectList(_context.DictRegion, "Id", "NameRus");

            }
            catch
            {

            }
            ViewData["DictTypeOfOjbectMonumentId"] = new SelectList(_context.DictTypeOfOjbectMonument, "Id", "NameRus");
            ViewData["DictTypeOfMonumentId"] = new SelectList(_context.DictTypeOfMonument, "Id", "NameRus");
            ViewData["DictAffiliationOfMonumentId"] = new SelectList(_context.DictAffiliationOfMonument, "Id", "NameRus");
            return View();
        }

        // POST: Monument/ListOfMonuments/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,NameRus,NameKyrg,DictTypeOfMonumentId,DateOfMonument,DictRegionId,DictDistrictId,DictAffiliationOfMonumentId,Address, DictTypeOfOjbectMonumentId")] ListOfMonument listOfMonument)
        {
            if (ModelState.IsValid)
            {
                _context.Add(listOfMonument);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            DictRegion region = _context.DictRegion.FirstOrDefault();

            try
            {
                // чтобы по умолчанию не передавать все районы, здесь 
                // передаётся только районы к-е входят в первый регион в БД
                List<DictDistrict> dicts = _context.DictDistrict
                    .Include(d => d.DictRegion)
                    .Where(d => d.DictRegionId == region.Id)
                    .ToList();

                ViewData["DictDistrictId"] = new SelectList(dicts, "Id", "NameRus");
                ViewData["DictRegionId"] = new SelectList(_context.DictRegion, "Id", "NameRus");

            }
            catch
            {

            }
            ViewData["DictTypeOfOjbectMonumentId"] = new SelectList(_context.DictTypeOfOjbectMonument, "Id", "NameRus");

            ViewData["DictTypeOfMonumentId"] = new SelectList(_context.DictTypeOfMonument, "Id", "NameRus", listOfMonument.DictTypeOfMonumentId);
            ViewData["DictAffiliationOfMonumentId"] = new SelectList(_context.DictAffiliationOfMonument, "Id", "NameRus", listOfMonument.DictAffiliationOfMonumentId);
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
            DictRegion region = _context.DictRegion.FirstOrDefault();

            try
            {
                // чтобы по умолчанию не передавать все районы, здесь 
                // передаётся только районы к-е входят в первый регион в БД
                List<DictDistrict> dicts = _context.DictDistrict
                    .Include(d => d.DictRegion)
                    .Where(d => d.DictRegionId == region.Id)
                    .ToList();

                ViewData["DictDistrictId"] = new SelectList(dicts, "Id", "NameRus");
                ViewData["DictRegionId"] = new SelectList(_context.DictRegion, "Id", "NameRus");

            }
            catch
            {

            }
            ViewData["DictTypeOfOjbectMonumentId"] = new SelectList(_context.DictTypeOfOjbectMonument, "Id", "NameRus");

            ViewData["DictTypeOfMonumentId"] = new SelectList(_context.DictTypeOfMonument, "Id", "NameRus", listOfMonument.DictTypeOfMonumentId);
            ViewData["DictAffiliationOfMonumentId"] = new SelectList(_context.DictAffiliationOfMonument, "Id", "NameRus", listOfMonument.DictAffiliationOfMonumentId);
            return View(listOfMonument);
        }

        // POST: Monument/ListOfMonuments/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,NameRus,NameKyrg,DictTypeOfMonumentId,DateOfMonument,DictRegionId,DictDistrictId,DictAffiliationOfMonumentId,Address, DictTypeOfOjbectMonumentId")] ListOfMonument listOfMonument)
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
            DictRegion region = _context.DictRegion.FirstOrDefault();

            try
            {
                // чтобы по умолчанию не передавать все районы, здесь 
                // передаётся только районы к-е входят в первый регион в БД
                List<DictDistrict> dicts = _context.DictDistrict
                    .Include(d => d.DictRegion)
                    .Where(d => d.DictRegionId == region.Id)
                    .ToList();

                ViewData["DictDistrictId"] = new SelectList(dicts, "Id", "NameRus");
                ViewData["DictRegionId"] = new SelectList(_context.DictRegion, "Id", "NameRus");

            }
            catch
            {

            }
            ViewData["DictTypeOfOjbectMonumentId"] = new SelectList(_context.DictTypeOfOjbectMonument, "Id", "NameRus");

            ViewData["DictTypeOfMonumentId"] = new SelectList(_context.DictTypeOfMonument, "Id", "NameRus", listOfMonument.DictTypeOfMonumentId);
            ViewData["DictAffiliationOfMonumentId"] = new SelectList(_context.DictAffiliationOfMonument, "Id", "NameRus", listOfMonument.DictAffiliationOfMonumentId);
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
                .Include(l => l.DictTypeOfOjbectMonument)
                .Include(l => l.DictAffiliationOfMonument)
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

            MkitFile file = ffl.CreateExcel<ListOfMonument>(_titleOfFile, _context.ListOfMonument.ToList(), _appEnvironment);

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
                Наименование памятника (рус.)
            </td>
            <td>
                Типологическая принадлежность
            </td>
            <td>
               Датировка
            </td>
            <td>
                Регион
            </td>
            <td>
                Район
            </td>
            <td>
               Адрес
            </td>
        </tr>";

            string tbody = "";
            foreach (var item in _context.ListOfMonument.ToList())
            {
                tbody += "<tr><td>" + item.NameRus + "</td>";
                tbody += "<td>" + item.DictTypeOfMonument + "</td>";
                tbody += "<td>" + item.DateOfMonument + "</td>";
                tbody += "<td>" + item.DictRegion + "</td>";
                tbody += "<td>" + item.DictDistrict + "</td>";
                tbody += "<td>" + item.Address + "</td></tr>";
            }

            string result = "<table><thead>" + thead + "</thead><tbody> " + tbody +" </tbody></table>";
    
            return result;
        }

    }
}
