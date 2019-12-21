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
    public class ListOfControlMediasController : Controller
    {
        private readonly ApplicationDbContext _context;

        private readonly IWebHostEnvironment _appEnvironment;

        private readonly string _titleOfFile = "Проверки_СМИ";


        public ListOfControlMediasController(ApplicationDbContext context, IWebHostEnvironment webHostEnvironment)
        {
            _context = context;

            _appEnvironment = webHostEnvironment;
        }


        // GET: Media/ListOfControlMedias
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.ListOfControlMedia
                .Include(l => l.DictControlType)
                .Include(l => l.DictMediaControlResult)
                .Include(l => l.DictMediaSuitPerm)
                .Include(l => l.ListOfMedia);
            
            return View(await applicationDbContext.ToListAsync());
        }


        // GET: Media/ListOfMedias
        public async Task<IActionResult> ListOfPermissionsMedia()
        {
            var applicationDbContext = _context.ListOfControlMedia
                .Include(l => l.DictControlType)
                .Include(l => l.DictMediaControlResult)
                .Include(l => l.DictMediaSuitPerm)
                .Include(l => l.ListOfMedia)
                .Include(l => l.ListOfMedia.DictMediaType)
                .Include(l => l.ListOfMedia.DictAgencyPerm)
                .Include(l => l.ListOfMedia.DictLegalForm);

            return View(await applicationDbContext.ToListAsync());
        }


        // GET: Media/ListOfControlMedias/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var listOfControlMedia = await _context.ListOfControlMedia
                .Include(l => l.DictControlType)
                .Include(l => l.DictMediaControlResult)
                .Include(l => l.DictMediaSuitPerm)
                .Include(l => l.ListOfMedia)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (listOfControlMedia == null)
            {
                return NotFound();
            }

            return View(listOfControlMedia);
        }

        // GET: Media/ListOfControlMedias/Create
        public IActionResult Create()
        {
            ViewData["DictControlTypeId"] = new SelectList(_context.DictControlType, "Id", "NameRus");
            ViewData["DictMediaControlResultId"] = new SelectList(_context.DictMediaControlResult, "Id", "NameRus");
            ViewData["DictMediaSuitPermId"] = new SelectList(_context.DictMediaSuitPerm, "Id", "NameRus");
            ViewData["ListOfMediaId"] = new SelectList(_context.ListOfMedia, "Id", "NameRus");
            return View();
        }

        // POST: Media/ListOfControlMedias/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ListOfMediaId,DictControlTypeId,StartDate,EndDate,StartDatePeriod,EndDatePeriod,LastName,FirstName,PatronicName,ActDateControl,NumberOfAct,DictMediaControlResultId,NumberOfWarning,WarningDate,WarningEndDate,DateOfPenalty,DocNumPenalty,PenaltySum,DateOfPenaltyPay,AnulmentDate,NumberOfAnulment,DateOfSuit,NumberOfSuit,DateOfSuitPerm,NumberOfSuitPerm,DictMediaSuitPermId,WarningRemovalDate")] ListOfControlMedia listOfControlMedia)
        {
            if (ModelState.IsValid)
            {

                _context.Add(listOfControlMedia);
                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }
            ViewData["DictControlTypeId"] = new SelectList(_context.DictControlType, "Id", "NameRus", listOfControlMedia.DictControlTypeId);
            ViewData["DictMediaControlResultId"] = new SelectList(_context.DictMediaControlResult, "Id", "NameRus", listOfControlMedia.DictMediaControlResultId);
            ViewData["DictMediaSuitPermId"] = new SelectList(_context.DictMediaSuitPerm, "Id", "NameRus", listOfControlMedia.DictMediaSuitPermId);
            ViewData["ListOfMediaId"] = new SelectList(_context.ListOfMedia, "Id", "NameRus", listOfControlMedia.ListOfMediaId);
            return View(listOfControlMedia);
        }

        // GET: Media/ListOfControlMedias/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var listOfControlMedia = await _context.ListOfControlMedia.FindAsync(id);
            if (listOfControlMedia == null)
            {
                return NotFound();
            }
            ViewData["DictControlTypeId"] = new SelectList(_context.DictControlType, "Id", "NameRus", listOfControlMedia.DictControlTypeId);
            ViewData["DictMediaControlResultId"] = new SelectList(_context.DictMediaControlResult, "Id", "NameRus", listOfControlMedia.DictMediaControlResultId);
            ViewData["DictMediaSuitPermId"] = new SelectList(_context.DictMediaSuitPerm, "Id", "NameRus", listOfControlMedia.DictMediaSuitPermId);
            ViewData["ListOfMediaId"] = new SelectList(_context.ListOfMedia, "Id", "NameRus", listOfControlMedia.ListOfMediaId);
            return View(listOfControlMedia);
        }

        // POST: Media/ListOfControlMedias/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ListOfMediaId,DictControlTypeId,StartDate,EndDate,StartDatePeriod,EndDatePeriod,LastName,FirstName,PatronicName,ActDateControl,NumberOfAct,DictMediaControlResultId,NumberOfWarning,WarningDate,WarningEndDate,DateOfPenalty,DocNumPenalty,PenaltySum,DateOfPenaltyPay,AnulmentDate,NumberOfAnulment,DateOfSuit,NumberOfSuit,DateOfSuitPerm,NumberOfSuitPerm,DictMediaSuitPermId,WarningRemovalDate")] ListOfControlMedia listOfControlMedia)
        {
            if (id != listOfControlMedia.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(listOfControlMedia);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ListOfControlMediaExists(listOfControlMedia.Id))
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
            ViewData["DictControlTypeId"] = new SelectList(_context.DictControlType, "Id", "NameRus", listOfControlMedia.DictControlTypeId);
            ViewData["DictMediaControlResultId"] = new SelectList(_context.DictMediaControlResult, "Id", "NameRus", listOfControlMedia.DictMediaControlResultId);
            ViewData["DictMediaSuitPermId"] = new SelectList(_context.DictMediaSuitPerm, "Id", "NameRus", listOfControlMedia.DictMediaSuitPermId);
            ViewData["ListOfMediaId"] = new SelectList(_context.ListOfMedia, "Id", "NameRus", listOfControlMedia.ListOfMediaId);
            return View(listOfControlMedia);
        }

        // GET: Media/ListOfControlMedias/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var listOfControlMedia = await _context.ListOfControlMedia
                .Include(l => l.DictControlType)
                .Include(l => l.DictMediaControlResult)
                .Include(l => l.DictMediaSuitPerm)
                .Include(l => l.ListOfMedia)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (listOfControlMedia == null)
            {
                return NotFound();
            }

            return View(listOfControlMedia);
        }

        // POST: Media/ListOfControlMedias/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var listOfControlMedia = await _context.ListOfControlMedia.FindAsync(id);
            _context.ListOfControlMedia.Remove(listOfControlMedia);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ListOfControlMediaExists(int id)
        {
            return _context.ListOfControlMedia.Any(e => e.Id == id);
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

            MkitFile file = ffl.CreateExcel<ListOfControlMedia>(_titleOfFile, _context.ListOfControlMedia.ToList(), _appEnvironment);

            return File(file.Bytes, file.Type, file.Name);
        }

        public string GetHtml()
        {
            var model = _context.ListOfControlMedia.FirstOrDefault();

            if (model == null)
            {
                return "<h1>нет данных в таблице</h1>";
            }

            string thead = @"
        <tr>
            <td>
                Вид проверки
            </td>
            <td>
                Дата начала проверки
            </td>
            <td>
                Дата конца проверки
            </td>
            <td>
                Результат проверки
            </td>
        </tr>";

            string tbody = "";

            var list = _context.ListOfControlMedia
                .Include(l => l.DictControlType)
                .Include(l => l.DictMediaControlResult)
                .Include(l => l.DictMediaSuitPerm)
                .Include(l => l.ListOfMedia)
                .ToList();

            foreach (var item in list)
            {

                tbody += "<tr><td>" + item.ListOfMedia.NameRus + "</td>";
                tbody += "<td>" + item.DictControlType.NameRus + "</td>";
                tbody += "<td>" + item.StartDate + "</td>";
                tbody += "<td>" + item.EndDate + "</td>";
                tbody += "<td>" + item.DictMediaControlResult.NameRus + "</td></tr>";
            }

            string result = "<table><thead>" + thead + "</thead><tbody> " + tbody + " </tbody></table>";

            return result;
        }
    }
}
