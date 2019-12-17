﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AisMKIT.Data;
using AisMKIT.Models;

namespace AisMKIT.Areas.Theatrical.Controllers
{
    [Area("Theatrical")]
    public class ListOfEventsTheatricalsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ListOfEventsTheatricalsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Theatrical/ListOfEventsTheatricals
        public async Task<IActionResult> Index()
        {
            return View(await _context.ListOfEventsTheatrical.ToListAsync());
        }

        // GET: Theatrical/ListOfEventsTheatricals/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var listOfEventsTheatrical = await _context.ListOfEventsTheatrical
                .FirstOrDefaultAsync(m => m.Id == id);
            if (listOfEventsTheatrical == null)
            {
                return NotFound();
            }

            return View(listOfEventsTheatrical);
        }

        // GET: Theatrical/ListOfEventsTheatricals/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Theatrical/ListOfEventsTheatricals/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Year,Month,DayOfMonth,Time,NameOfEvent,NameOfHall")] ListOfEventsTheatrical listOfEventsTheatrical)
        {
            if (ModelState.IsValid)
            {
                _context.Add(listOfEventsTheatrical);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(listOfEventsTheatrical);
        }

        // GET: Theatrical/ListOfEventsTheatricals/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var listOfEventsTheatrical = await _context.ListOfEventsTheatrical.FindAsync(id);
            if (listOfEventsTheatrical == null)
            {
                return NotFound();
            }
            return View(listOfEventsTheatrical);
        }

        // POST: Theatrical/ListOfEventsTheatricals/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Year,Month,DayOfMonth,Time,NameOfEvent,NameOfHall")] ListOfEventsTheatrical listOfEventsTheatrical)
        {
            if (id != listOfEventsTheatrical.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(listOfEventsTheatrical);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ListOfEventsTheatricalExists(listOfEventsTheatrical.Id))
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
            return View(listOfEventsTheatrical);
        }

        // GET: Theatrical/ListOfEventsTheatricals/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var listOfEventsTheatrical = await _context.ListOfEventsTheatrical
                .FirstOrDefaultAsync(m => m.Id == id);
            if (listOfEventsTheatrical == null)
            {
                return NotFound();
            }

            return View(listOfEventsTheatrical);
        }

        // POST: Theatrical/ListOfEventsTheatricals/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var listOfEventsTheatrical = await _context.ListOfEventsTheatrical.FindAsync(id);
            _context.ListOfEventsTheatrical.Remove(listOfEventsTheatrical);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ListOfEventsTheatricalExists(int id)
        {
            return _context.ListOfEventsTheatrical.Any(e => e.Id == id);
        }
    }
}
