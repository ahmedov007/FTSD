using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FTSD2.Domain;

namespace FTSD2.Controllers
{
    public class AmedmentTypesController : Controller
    {
        private readonly FTSDContext _context;

        public AmedmentTypesController(FTSDContext context)
        {
            _context = context;
        }

        // GET: AmedmentTypes
        public async Task<IActionResult> Index()
        {
              return _context.AmedmentTypes != null ? 
                          View(await _context.AmedmentTypes.ToListAsync()) :
                          Problem("Entity set 'FTSDContext.AmedmentTypes'  is null.");
        }

        // GET: AmedmentTypes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.AmedmentTypes == null)
            {
                return NotFound();
            }

            var amedmentType = await _context.AmedmentTypes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (amedmentType == null)
            {
                return NotFound();
            }

            return View(amedmentType);
        }

        // GET: AmedmentTypes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: AmedmentTypes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,ArabicName,IsActive,NoDelete")] AmedmentType amedmentType)
        {
            if (ModelState.IsValid)
            {
                _context.Add(amedmentType);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(amedmentType);
        }

        // GET: AmedmentTypes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.AmedmentTypes == null)
            {
                return NotFound();
            }

            var amedmentType = await _context.AmedmentTypes.FindAsync(id);
            if (amedmentType == null)
            {
                return NotFound();
            }
            return View(amedmentType);
        }

        // POST: AmedmentTypes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,ArabicName,IsActive,NoDelete")] AmedmentType amedmentType)
        {
            if (id != amedmentType.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(amedmentType);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AmedmentTypeExists(amedmentType.Id))
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
            return View(amedmentType);
        }

        // GET: AmedmentTypes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.AmedmentTypes == null)
            {
                return NotFound();
            }

            var amedmentType = await _context.AmedmentTypes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (amedmentType == null)
            {
                return NotFound();
            }

            return View(amedmentType);
        }

        // POST: AmedmentTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.AmedmentTypes == null)
            {
                return Problem("Entity set 'FTSDContext.AmedmentTypes'  is null.");
            }
            var amedmentType = await _context.AmedmentTypes.FindAsync(id);
            if (amedmentType != null)
            {
                _context.AmedmentTypes.Remove(amedmentType);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AmedmentTypeExists(int id)
        {
          return (_context.AmedmentTypes?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
