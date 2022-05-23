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
    public class AthorityMatricesController : Controller
    {
        private readonly FTSDContext _context;

        public AthorityMatricesController(FTSDContext context)
        {
            _context = context;
        }

        // GET: AthorityMatrices
        public async Task<IActionResult> Index()
        {
              return _context.AthorityMatrices != null ? 
                          View(await _context.AthorityMatrices.ToListAsync()) :
                          Problem("Entity set 'FTSDContext.AthorityMatrices'  is null.");
        }

        // GET: AthorityMatrices/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.AthorityMatrices == null)
            {
                return NotFound();
            }

            var athorityMatrix = await _context.AthorityMatrices
                .FirstOrDefaultAsync(m => m.Id == id);
            if (athorityMatrix == null)
            {
                return NotFound();
            }

            return View(athorityMatrix);
        }

        // GET: AthorityMatrices/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: AthorityMatrices/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,ArabicName,IsActive,IsDelete")] AthorityMatrix athorityMatrix)
        {
            if (ModelState.IsValid)
            {
                _context.Add(athorityMatrix);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(athorityMatrix);
        }

        // GET: AthorityMatrices/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.AthorityMatrices == null)
            {
                return NotFound();
            }

            var athorityMatrix = await _context.AthorityMatrices.FindAsync(id);
            if (athorityMatrix == null)
            {
                return NotFound();
            }
            return View(athorityMatrix);
        }

        // POST: AthorityMatrices/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,ArabicName,IsActive,IsDelete")] AthorityMatrix athorityMatrix)
        {
            if (id != athorityMatrix.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(athorityMatrix);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AthorityMatrixExists(athorityMatrix.Id))
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
            return View(athorityMatrix);
        }

        // GET: AthorityMatrices/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.AthorityMatrices == null)
            {
                return NotFound();
            }

            var athorityMatrix = await _context.AthorityMatrices
                .FirstOrDefaultAsync(m => m.Id == id);
            if (athorityMatrix == null)
            {
                return NotFound();
            }

            return View(athorityMatrix);
        }

        // POST: AthorityMatrices/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.AthorityMatrices == null)
            {
                return Problem("Entity set 'FTSDContext.AthorityMatrices'  is null.");
            }
            var athorityMatrix = await _context.AthorityMatrices.FindAsync(id);
            if (athorityMatrix != null)
            {
                _context.AthorityMatrices.Remove(athorityMatrix);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AthorityMatrixExists(int id)
        {
          return (_context.AthorityMatrices?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
