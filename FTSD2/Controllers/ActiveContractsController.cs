using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FTSD2.Domain;
using FTSD2.Models;

namespace FTSD2.Controllers
{
    public class ActiveContractsController : Controller
    {
        private readonly FTSDContext _context;

        public ActiveContractsController(FTSDContext context)
        {
            _context = context;
        }

        // GET: ActiveContracts
        public async Task<IActionResult> Index()
        {
              return _context.OperationContractsActiveAddViewModel != null ? 
                          View(await _context.OperationContractsActiveAddViewModel.ToListAsync()) :
                          Problem("Entity set 'FTSDContext.OperationContractsActiveAddViewModel'  is null.");
        }

        // GET: ActiveContracts/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null || _context.OperationContractsActiveAddViewModel == null)
            {
                return NotFound();
            }

            var operationContractsActiveAddViewModel = await _context.OperationContractsActiveAddViewModel
                .FirstOrDefaultAsync(m => m.Id == id);
            if (operationContractsActiveAddViewModel == null)
            {
                return NotFound();
            }

            return View(operationContractsActiveAddViewModel);
        }

        // GET: ActiveContracts/Create
        public IActionResult Create()
        {
            ViewData["RegionId"] = new SelectList(_context.Regions, "Id", "ArabicName");
            ViewData["ContractTypeId"] = new SelectList(_context.ContractsTypes, "Id", "ArabicName");
            ViewData["CompanyId"] = new SelectList(_context.Companies, "Id", "NameArabic");

            return View();
        }

        // POST: ActiveContracts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ContractNumber,NameArabic,Name,ContractTypeId,CompanyId,StartDate,EndDate,LumpSum,Uitrate,BasicPeriodCost,OptionalPeriodCost,OptionalValue,CotractTotal")] OperationContractsActiveAddViewModel ActiveContracts)
        {
            if (ModelState.IsValid)
            {
                var contracts = new ActiveContract
                {

                    Id = new Guid(),
                    Name = ActiveContracts.Name,
                    ArabicName = ActiveContracts.NameArabic,
                   
                    RegionId = ActiveContracts.RegionId,
                    ContractTypeId = ActiveContracts.ContractTypeId,
                    StartDate = ActiveContracts.StartDate,
                    EndDat = ActiveContracts.EndDate,
                    LumpSum = ActiveContracts.LumpSum,
                    Uitrate = ActiveContracts.Uitrate,
                    BasicPeriodValue = ActiveContracts.BasicPeriodCost,
                    OptionalPeriodValue = ActiveContracts.OptionalPeriodCost,
                    CompanyId = Guid.Parse(ActiveContracts.CompanyId),
                    IsActive = true,
                    IsDeleted = false


                };

                ActiveContracts.Id = Guid.NewGuid();
                _context.Add(ActiveContracts);
                await _context.SaveChangesAsync();

                #region Notification And Log
                var Noti = new Notification
                {
                    Id = Guid.NewGuid(),
                    Date = DateTime.Now,
                    IsDeleted = false,
                    IsRead = false,
                    NotificationTypeId = Guid.Parse("EC8A9A42-6EF6-4BFE-B6F4-0BBF5C0472FF"),
                    Sender = "5d1945a9-1424-47ad-b635-da07de9bd7d9",
                    Receiver = "74b8cd66-0b1c-42ab-bd16-4e3fdb575dad",
                    Title = "تم الاضافة بنجاح",
                    NotificationContent = "تم الاضافة "
                };
                await _context.Notifications.AddAsync(Noti);
                await _context.SaveChangesAsync();

                var lo = new Logs
                {
                    Id = Guid.NewGuid(),
                    Date = DateTime.Now,
                    UserId = "74b8cd66-0b1c-42ab-bd16-4e3fdb575dad",
                    Notes = "تم اضافة العقد",
                    LogTypeId = Guid.Parse("5DA5D96C-604C-4303-AB46-436639E33A8A"),
                    TableName = "ActiveContracts",
                    IsActive = true,
                    NoDelete = false
                };
                await _context.Logs.AddAsync(lo);
                await _context.SaveChangesAsync();
                #endregion



                return RedirectToAction(nameof(Index));
            }
            ViewData["RegionId"] = new SelectList(_context.Regions, "Id", "ArabicName", ActiveContracts.RegionId);
            ViewData["ContractTypeId"] = new SelectList(_context.ContractsTypes, "Id", "ArabicName", ActiveContracts.ContractTypeId);
            ViewData["CompanyId"] = new SelectList(_context.Companies, "Id", "NameArabic", ActiveContracts.CompanyId);

            return View(ActiveContracts);
        }

        // GET: ActiveContracts/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null || _context.OperationContractsActiveAddViewModel == null)
            {
                return NotFound();
            }

            var operationContractsActiveAddViewModel = await _context.OperationContractsActiveAddViewModel.FindAsync(id);
            if (operationContractsActiveAddViewModel == null)
            {
                return NotFound();
            }
            return View(operationContractsActiveAddViewModel);
        }

        // POST: ActiveContracts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,ActiveId,ContractNumber,NameArabic,Name,ContractTypeId,CompanyId,StartDate,EndDate,LumpSum,Uitrate,OptionalValue,CotractTotal")] OperationContractsActiveAddViewModel operationContractsActiveAddViewModel)
        {
            if (id != operationContractsActiveAddViewModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(operationContractsActiveAddViewModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OperationContractsActiveAddViewModelExists(operationContractsActiveAddViewModel.Id))
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
            return View(operationContractsActiveAddViewModel);
        }

        // GET: ActiveContracts/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null || _context.OperationContractsActiveAddViewModel == null)
            {
                return NotFound();
            }

            var operationContractsActiveAddViewModel = await _context.OperationContractsActiveAddViewModel
                .FirstOrDefaultAsync(m => m.Id == id);
            if (operationContractsActiveAddViewModel == null)
            {
                return NotFound();
            }

            return View(operationContractsActiveAddViewModel);
        }

        // POST: ActiveContracts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            if (_context.OperationContractsActiveAddViewModel == null)
            {
                return Problem("Entity set 'FTSDContext.OperationContractsActiveAddViewModel'  is null.");
            }
            var operationContractsActiveAddViewModel = await _context.OperationContractsActiveAddViewModel.FindAsync(id);
            if (operationContractsActiveAddViewModel != null)
            {
                _context.OperationContractsActiveAddViewModel.Remove(operationContractsActiveAddViewModel);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool OperationContractsActiveAddViewModelExists(Guid id)
        {
          return (_context.OperationContractsActiveAddViewModel?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
