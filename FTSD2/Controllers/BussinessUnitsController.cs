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
    public class BussinessUnitsController : Controller
    {
        private readonly FTSDContext _context;

        public BussinessUnitsController(FTSDContext context)
        {
            _context = context;
        }

        // GET: BussinessUnits
        public async Task<IActionResult> Index()
        {
              return _context.BussinessUnits != null ? 
                          View(await _context.BussinessUnits.ToListAsync()) :
                          Problem("Entity set 'FTSDContext.BussinessUnits'  is null.");
        }

        // GET: BussinessUnits/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.BussinessUnits == null)
            {
                return NotFound();
            }

            var bussinessUnit = await _context.BussinessUnits
                .FirstOrDefaultAsync(m => m.Id == id);
            if (bussinessUnit == null)
            {
                return NotFound();
            }

            return View(bussinessUnit);
        }

        // GET: BussinessUnits/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: BussinessUnits/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,ArabicName,IsActive,NoDelete")] BussinessUnit bussinessUnit)
        {
            if (ModelState.IsValid)
            {
                _context.Add(bussinessUnit);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(bussinessUnit);
        }

        // GET: BussinessUnits/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.BussinessUnits == null)
            {
                return NotFound();
            }

            var bussinessUnit = await _context.BussinessUnits.FindAsync(id);
            if (bussinessUnit == null)
            {
                return NotFound();
            }
            return View(bussinessUnit);
        }

        // POST: BussinessUnits/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,ArabicName,IsActive,NoDelete")] BussinessUnit bussinessUnit)
        {
            if (id != bussinessUnit.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(bussinessUnit);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BussinessUnitExists(bussinessUnit.Id))
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
            return View(bussinessUnit);
        }

        // GET: BussinessUnits/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.BussinessUnits == null)
            {
                return NotFound();
            }

            var bussinessUnit = await _context.BussinessUnits
                .FirstOrDefaultAsync(m => m.Id == id);
            if (bussinessUnit == null)
            {
                return NotFound();
            }

            return View(bussinessUnit);
        }

        // POST: BussinessUnits/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.BussinessUnits == null)
            {
                return Problem("Entity set 'FTSDContext.BussinessUnits'  is null.");
            }
            var bussinessUnit = await _context.BussinessUnits.FindAsync(id);
            if (bussinessUnit != null)
            {
                _context.BussinessUnits.Remove(bussinessUnit);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BussinessUnitExists(int id)
        {
          return (_context.BussinessUnits?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
