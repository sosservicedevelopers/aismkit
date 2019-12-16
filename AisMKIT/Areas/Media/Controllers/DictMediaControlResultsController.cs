﻿using System;
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
    public class DictMediaControlResultsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public DictMediaControlResultsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Media/DictMediaControlResults
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.DictMediaControlResult.Include(d => d.StatusForDict);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Media/DictMediaControlResults/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dictMediaControlResult = await _context.DictMediaControlResult
                .Include(d => d.StatusForDict)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (dictMediaControlResult == null)
            {
                return NotFound();
            }

            return View(dictMediaControlResult);
        }

        // GET: Media/DictMediaControlResults/Create
        public IActionResult Create()
        {
            ViewData["StatusForDictId"] = new SelectList(_context.Set<StatusForDict>(), "Id", "Name");
            return View();
        }

        // POST: Media/DictMediaControlResults/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,NameKyrg,NameRus,CreateDate,StatusForDictId,DeactiveDate")] DictMediaControlResult dictMediaControlResult)
        {
            if (ModelState.IsValid)
            {
                _context.Add(dictMediaControlResult);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["StatusForDictId"] = new SelectList(_context.Set<StatusForDict>(), "Id", "Name", dictMediaControlResult.StatusForDictId);
            return View(dictMediaControlResult);
        }

        // GET: Media/DictMediaControlResults/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dictMediaControlResult = await _context.DictMediaControlResult.FindAsync(id);
            if (dictMediaControlResult == null)
            {
                return NotFound();
            }
            ViewData["StatusForDictId"] = new SelectList(_context.Set<StatusForDict>(), "Id", "Name", dictMediaControlResult.StatusForDictId);
            return View(dictMediaControlResult);
        }

        // POST: Media/DictMediaControlResults/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,NameKyrg,NameRus,CreateDate,StatusForDictId,DeactiveDate")] DictMediaControlResult dictMediaControlResult)
        {
            if (id != dictMediaControlResult.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(dictMediaControlResult);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DictMediaControlResultExists(dictMediaControlResult.Id))
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
            ViewData["StatusForDictId"] = new SelectList(_context.Set<StatusForDict>(), "Id", "Name", dictMediaControlResult.StatusForDictId);
            return View(dictMediaControlResult);
        }

        // GET: Media/DictMediaControlResults/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dictMediaControlResult = await _context.DictMediaControlResult
                .Include(d => d.StatusForDict)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (dictMediaControlResult == null)
            {
                return NotFound();
            }

            return View(dictMediaControlResult);
        }

        // POST: Media/DictMediaControlResults/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var dictMediaControlResult = await _context.DictMediaControlResult.FindAsync(id);
            _context.DictMediaControlResult.Remove(dictMediaControlResult);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DictMediaControlResultExists(int id)
        {
            return _context.DictMediaControlResult.Any(e => e.Id == id);
        }
    }
}
