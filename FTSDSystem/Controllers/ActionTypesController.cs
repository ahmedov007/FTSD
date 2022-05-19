﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FTSDSystem.Domain;

namespace FTSDSystem.Controllers
{
    public class ActionTypesController : Controller
    {
        private readonly FTSDContext _context;

        public ActionTypesController(FTSDContext context)
        {
            _context = context;
        }

        // GET: ActionTypes
        public async Task<IActionResult> Index()
        {
            var OperationalContracts = _context.ActionTypes.ToList();
            return View(OperationalContracts.ToList());

            //return _context.ActionTypes != null ? 
            //            View(await _context.ActionTypes.ToListAsync()) :
            //            Problem("Entity set 'FTSDContext.ActionTypes'  is null.");
        }

        // GET: ActionTypes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.ActionTypes == null)
            {
                return NotFound();
            }

            var actionType = await _context.ActionTypes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (actionType == null)
            {
                return NotFound();
            }

            return View(actionType);
        }

        // GET: ActionTypes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ActionTypes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,ArabicName,IsActive,NoDelete")] ActionType actionType)
        {
            if (ModelState.IsValid)
            {
                _context.Add(actionType);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(actionType);
        }

        // GET: ActionTypes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.ActionTypes == null)
            {
                return NotFound();
            }

            var actionType = await _context.ActionTypes.FindAsync(id);
            if (actionType == null)
            {
                return NotFound();
            }
            return View(actionType);
        }

        // POST: ActionTypes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,ArabicName,IsActive,NoDelete")] ActionType actionType)
        {
            if (id != actionType.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(actionType);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ActionTypeExists(actionType.Id))
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
            return View(actionType);
        }

        // GET: ActionTypes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.ActionTypes == null)
            {
                return NotFound();
            }

            var actionType = await _context.ActionTypes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (actionType == null)
            {
                return NotFound();
            }

            return View(actionType);
        }

        // POST: ActionTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.ActionTypes == null)
            {
                return Problem("Entity set 'FTSDContext.ActionTypes'  is null.");
            }
            var actionType = await _context.ActionTypes.FindAsync(id);
            if (actionType != null)
            {
                _context.ActionTypes.Remove(actionType);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ActionTypeExists(int id)
        {
          return (_context.ActionTypes?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
