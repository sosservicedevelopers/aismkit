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

namespace AisMKIT.Areas.Theatrical.Controllers
{
    [Area("Theatrical")]
    public class ListOfTheatricalsController : Controller
    {
        private readonly ApplicationDbContext _context;

        private readonly IWebHostEnvironment _appEnvironment;

        private readonly string _titleOfFile = "Реестр_театрально_зрелищных_учреждений";


        public ListOfTheatricalsController(ApplicationDbContext context, IWebHostEnvironment webHostEnvironment)
        {
            _context = context;

            _appEnvironment = webHostEnvironment;
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

            MkitFile file = ffl.CreateExcel<ListOfTheatrical>(_titleOfFile, _context.ListOfTheatrical.ToList(), _appEnvironment);

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
                Наименование ТЗУ (рус.) 
            </td>
            <td>
                ИНН
            </td>
            <td>
               Количество штатных единиц 
            </td>
        </tr>";

            string tbody = "";
            foreach (var item in _context.ListOfTheatrical.ToList())
            {
                tbody += "<tr><td>" + item.NameRus + "</td>";
                tbody += "<td>" + item.INN + "</td>";
                tbody += "<td>" + item.NumEmployees + "</td></tr>";
            }

            string result = "<table><thead>" + thead + "</thead><tbody> " + tbody + " </tbody></table>";

            return result;
        }

    }
}
