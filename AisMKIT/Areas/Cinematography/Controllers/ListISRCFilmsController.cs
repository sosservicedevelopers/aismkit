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

namespace AisMKIT.Areas.Cinematography.Controllers
{
    [Area("Cinematography")]
    public class ListISRCFilmsController : Controller
    {
        private readonly ApplicationDbContext _context;

        private readonly IWebHostEnvironment _appEnvironment;

        private readonly string _titleOfFile = "Реестр_сертифицированных_фильмов";


        public ListISRCFilmsController(ApplicationDbContext context, IWebHostEnvironment webHostEnvironment)
        {
            _context = context;

            _appEnvironment = webHostEnvironment;
        }

        // GET: Cinematography/ListISRCFilms
        public async Task<IActionResult> Index()
        {
            return View(await _context.listISRCFilms.ToListAsync());
        }

        // GET: Cinematography/ListISRCFilms/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var listISRCFilms = await _context.listISRCFilms
                .FirstOrDefaultAsync(m => m.Id == id);
            if (listISRCFilms == null)
            {
                return NotFound();
            }

            return View(listISRCFilms);
        }

        // GET: Cinematography/ListISRCFilms/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Cinematography/ListISRCFilms/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,MovieTitle,Country,ReleaseYear,Director,Duration,AgeRestrictions,DateCertificated")] ListISRCFilms listISRCFilms)
        {
            if (ModelState.IsValid)
            {
                _context.Add(listISRCFilms);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(listISRCFilms);
        }

        // GET: Cinematography/ListISRCFilms/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var listISRCFilms = await _context.listISRCFilms.FindAsync(id);
            if (listISRCFilms == null)
            {
                return NotFound();
            }
            return View(listISRCFilms);
        }

        // POST: Cinematography/ListISRCFilms/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,MovieTitle,Country,ReleaseYear,Director,Duration,AgeRestrictions,DateCertificated")] ListISRCFilms listISRCFilms)
        {
            if (id != listISRCFilms.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(listISRCFilms);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ListISRCFilmsExists(listISRCFilms.Id))
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
            return View(listISRCFilms);
        }

        // GET: Cinematography/ListISRCFilms/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var listISRCFilms = await _context.listISRCFilms
                .FirstOrDefaultAsync(m => m.Id == id);
            if (listISRCFilms == null)
            {
                return NotFound();
            }

            return View(listISRCFilms);
        }

        // POST: Cinematography/ListISRCFilms/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var listISRCFilms = await _context.listISRCFilms.FindAsync(id);
            _context.listISRCFilms.Remove(listISRCFilms);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ListISRCFilmsExists(int id)
        {
            return _context.listISRCFilms.Any(e => e.Id == id);
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

            MkitFile file = ffl.CreateExcel(_titleOfFile, _context.listISRCFilms.ToList(), _appEnvironment);

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
                Название фильма 
            </td>
            <td>
                Страна 
            </td>
            <td>
               Год выпуска 
            </td>
            <td>
                Режиссер
            </td>
            <td>
                Продолжительность
            </td>
            <td>
               Возрастные ограничения 
            </td>
            <td>
               Дата выдачи удостоверения 
            </td>
        </tr>";

            string tbody = "";
            foreach (var item in _context.listISRCFilms.ToList())
            {
                tbody += "<tr><td>" + item.MovieTitle + "</td>";
                tbody += "<td>" + item.Country + "</td>";
                tbody += "<td>" + item.ReleaseYear + "</td>";
                tbody += "<td>" + item.Director + "</td>";
                tbody += "<td>" + item.Duration + "</td>";
                tbody += "<td>" + item.AgeRestrictions + "</td>";
                tbody += "<td>" + item.DateCertificated + "</td></tr>";
            }

            string result = "<table><thead>" + thead + "</thead><tbody> " + tbody + " </tbody></table>";

            return result;
        }

    }
}
