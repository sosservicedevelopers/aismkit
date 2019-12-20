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

namespace AisMKIT.Areas.EduInstitutions.Controllers
{
    [Area("EduInstitutions")]
    public class MainController : Controller
    {
        private readonly ApplicationDbContext _context;

        private readonly IWebHostEnvironment _appEnvironment;

        private readonly string _titleOfFile = "Реестр_учебных_заведений";


        public MainController(ApplicationDbContext context, IWebHostEnvironment webHostEnvironment)
        {
            _context = context;

            _appEnvironment = webHostEnvironment;
        }


        // GET: EduInstitutions/Main
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> List()
        {
            var applicationDbContext = _context.EduInstitutions.Include(e => e.DictEduCategory);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: EduInstitutions/Main/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var eduInstitution = await _context.EduInstitutions
                .Include(e => e.DictEduCategory)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (eduInstitution == null)
            {
                return NotFound();
            }

            // Факультеты
            // выбрать факультеты из таблицы Faculties
            // где EduInstitutionId равняется id
            // т.е. факультеты этого учебного заведения
            IEnumerable<Faculty> faculties = _context.Faculties
                .Include(l => l.EduInstitution)
                .Where(m => m.EduInstitutionId == id)
                .ToList();

            // Факультеты-Специальности
            IEnumerable<FacultySpecialty> facultySpecialties = _context.FacultySpecialties
                .Include(f => f.Faculty) // иниц. самого факультета
                .Include(f => f.Specialty) // иниц. самого специальности
                .Where(m => m.Faculty.EduInstitutionId == id) // где Id == id
                .ToList();

            // Сотрудники-Должностьи
            IEnumerable<EmplPosHistory> emplPosHistories = _context.EmplPosHistories
                .Include(e => e.Employee)
                .Include(e => e.Faculty)
                .Include(e => e.Position)
                .Where(e => e.Faculty.EduInstitutionId == id)
                .ToList();

            // Сотрудники-Подразделения
            IEnumerable<EmplEducationalUnit> emplEducationalUnits = _context.EmplEducationalUnits
                .Include(e => e.Employee)
                .Include(e => e.EducationalUnit)
                .Include(e => e.Faculty)
                .Where(e => e.Faculty.EduInstitutionId == id)
                .ToList();

            // Все Должности в БД
            IEnumerable<Position> positions = _context.Positions.ToList();

            // Все Сотрудники в БД
            IEnumerable<Employee> employees = _context.Employees.ToList();

            // Все Специальности в БД
            IEnumerable<Specialty> specialties = _context.Specialties.ToList();

            // Все Подразделения в БД
            IEnumerable<EducationalUnit> educationalUnits = _context.EducationalUnits.ToList();

            // Все нужные перечисления в представлении, содержаться в модели ListsEduInstitutions
            ListsEduInstitutions listsForEduInstitution = new ListsEduInstitutions();

            listsForEduInstitution.EduInstitution = eduInstitution; // Рассматриваемая Учебное заведение
            listsForEduInstitution.Faculties = faculties;
            listsForEduInstitution.FacultySpecialties = facultySpecialties;
            listsForEduInstitution.EmplPosHistories = emplPosHistories;
            listsForEduInstitution.EmplEducationalUnits = emplEducationalUnits;
            listsForEduInstitution.Employees = employees;

            return View(listsForEduInstitution);
        }

        // GET: EduInstitutions/Main/Create
        public IActionResult Create()
        {
            ViewData["DictEduCategoryId"] = new SelectList(_context.DictEduCategories, "Id", "Name");
            return View();
        }

        // POST: EduInstitutions/Main/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,INN,Name,Address,DomenNames,Fax,Email,DateOfCreated,BriefInfo,DictEduCategoryId")] EduInstitution eduInstitution)
        {
            if (ModelState.IsValid)
            {
                _context.Add(eduInstitution);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["DictEduCategoryId"] = new SelectList(_context.DictEduCategories, "Id", "Name", eduInstitution.DictEduCategoryId);
            return View(eduInstitution);
        }

        // GET: EduInstitutions/Main/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var eduInstitution = await _context.EduInstitutions.FindAsync(id);
            if (eduInstitution == null)
            {
                return NotFound();
            }
            ViewData["ClUchZavedCategoryId"] = new SelectList(_context.DictEduCategories, "Id", "Name", eduInstitution.DictEduCategoryId);
            return View(eduInstitution);
        }

        // POST: EduInstitutions/Main/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,INN,Name,Address,DomenNames,Fax,Email,DateOfCreated,BriefInfo,ClUchZavedCategoryId")] EduInstitution eduInstitution)
        {
            if (id != eduInstitution.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(eduInstitution);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EduInstitutionExists(eduInstitution.Id))
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
            ViewData["ClUchZavedCategoryId"] = new SelectList(_context.DictEduCategories, "Id", "Name", eduInstitution.DictEduCategoryId);
            return View(eduInstitution);
        }

        // GET: EduInstitutions/Main/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var eduInstitution = await _context.EduInstitutions
                .Include(e => e.DictEduCategory)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (eduInstitution == null)
            {
                return NotFound();
            }

            return View(eduInstitution);
        }

        // POST: EduInstitutions/Main/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var eduInstitution = await _context.EduInstitutions.FindAsync(id);
            _context.EduInstitutions.Remove(eduInstitution);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EduInstitutionExists(int id)
        {
            return _context.EduInstitutions.Any(e => e.Id == id);
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

            MkitFile file = ffl.CreateExcel(_titleOfFile, _context.EduInstitutions.Include(c=>c.DictEduCategory).ToList(), _appEnvironment);

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
                Наименование 
            </td>
            <td>
                Адрес 
            </td>
            <td>
                Факс
            </td>
            <td>
                Электронная почта 
            </td>
            <td>
                Категория 
            </td>
        </tr>";

            string tbody = "";
            foreach (var item in _context.EduInstitutions.Include(c => c.DictEduCategory).ToList())
            {
                tbody += "<tr><td>" + item.Name + "</td>";
                tbody += "<td>" + item.Address + "</td>";
                tbody += "<td>" + item.Fax + "</td>";
                tbody += "<td>" + item.Email + "</td>";
                tbody += "<td>" + item.DictEduCategory.Name + "</td></tr>";
            }

            string result = "<table><thead>" + thead + "</thead><tbody> " + tbody + " </tbody></table>";

            return result;
        }

    }
}
