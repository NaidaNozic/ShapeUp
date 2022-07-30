using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Application.Data;
using Application.Models;

namespace Application.Controllers
{
    public class ProgramController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ProgramController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Program
        public async Task<IActionResult> Index()
        {
            return View(await _context.Program1.ToListAsync());
        }

        // GET: Program/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var program1 = await _context.Program1
                .FirstOrDefaultAsync(m => m.Id == id);
            if (program1 == null)
            {
                return NotFound();
            }

            return View(program1);
        }

        // GET: Program/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Program/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Duration,Type,Reps,Description,Image,Likes,Saved,User")] Program1 program1)
        {
            if (ModelState.IsValid)
            {
                _context.Add(program1);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(program1);
        }

        // GET: Program/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var program1 = await _context.Program1.FindAsync(id);
            if (program1 == null)
            {
                return NotFound();
            }
            return View(program1);
        }

        // POST: Program/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Duration,Type,Reps,Description,Image,Likes,Saved,User")] Program1 program1)
        {
            if (id != program1.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(program1);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Program1Exists(program1.Id))
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
            return View(program1);
        }

        // GET: Program/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var program1 = await _context.Program1
                .FirstOrDefaultAsync(m => m.Id == id);
            if (program1 == null)
            {
                return NotFound();
            }

            return View(program1);
        }

        // POST: Program/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var program1 = await _context.Program1.FindAsync(id);
            _context.Program1.Remove(program1);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Program1Exists(int id)
        {
            return _context.Program1.Any(e => e.Id == id);
        }
    }
}
