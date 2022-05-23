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
    public class UnderPreparationContractsController : Controller
    {
        private readonly FTSDContext _context;

        public UnderPreparationContractsController(FTSDContext context)
        {
            _context = context;
        }

        // GET: UnderPreparationContracts
        public async Task<IActionResult> Index()
        {
              return _context.OperationContractsPreparationAddViewModel != null ? 
                          View(await _context.OperationContractsPreparationAddViewModel.ToListAsync()) :
                          Problem("Entity set 'FTSDContext.OperationContractsPreparationAddViewModel'  is null.");
        }

        // GET: UnderPreparationContracts/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null || _context.OperationContractsPreparationAddViewModel == null)
            {
                return NotFound();
            }

            var operationContractsPreparationAddViewModel = await _context.OperationContractsPreparationAddViewModel
                .FirstOrDefaultAsync(m => m.Id == id);
            if (operationContractsPreparationAddViewModel == null)
            {
                return NotFound();
            }

            return View(operationContractsPreparationAddViewModel);
        }

        // GET: UnderPreparationContracts/Create
        public IActionResult Create()
        {
            ViewData["AthorityApproval"] = new SelectList(_context.AthorityMatrices, "Id", "ArabicName");
            ViewData["RegionId"] = new SelectList(_context.Regions, "Id", "ArabicName");
            ViewData["ContractTypeId"] = new SelectList(_context.ContractsTypes, "Id", "ArabicName");
            ViewData["CompanyId"] = new SelectList(_context.Companies, "Id", "NameArabic");

            return View();
        }

        // POST: UnderPreparationContracts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,NameArabic,Name,AthorityApproval,RegionId,ContractTypeId,RequestDate,CompanyId,ContractRequestDate,WavierDate,AwardingApprovalDate,SigningDate,ContractorDate,OpenBidDate,BidEvaluationDate,JobexDate")] OperationContractsPreparationAddViewModel OperationContractsPreparation)
        {
            if (ModelState.IsValid)
            {
                var contracts = new NewContract
                { 

                    Id = new Guid(),
                    ContractName = OperationContractsPreparation.Name,
                    ArabicContractName = OperationContractsPreparation.NameArabic,
                    AthorityApproval = OperationContractsPreparation.AthorityApproval,
                    AwardingApprovalDate = OperationContractsPreparation.AwardingApprovalDate,
                    RegionId = OperationContractsPreparation.RegionId,
                    ContractTypeId = OperationContractsPreparation.ContractTypeId,
                    RequestDate = (DateTime)OperationContractsPreparation.RequestDate,
                    WavierDate = OperationContractsPreparation.WavierDate,
                    ContractRequestDate = OperationContractsPreparation.ContractRequestDate,
                    JobexDate = OperationContractsPreparation.JobexDate,
                    SigningDate = OperationContractsPreparation.SigningDate,
                    ContractorDate = OperationContractsPreparation.ContractorDate,
                    OpenBidDate = OperationContractsPreparation.OpenBidDate,
                    BidEvaluationDate = OperationContractsPreparation.BidEvaluationDate,
                    CompanyId = OperationContractsPreparation.CompanyId,
                    IsActive = true,
                    IsDeleted = false


                };
                OperationContractsPreparation.Id = Guid.NewGuid();
                _context.Add(OperationContractsPreparation);

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
                    TableName = "NewContract",
                    IsActive = true,
                    NoDelete = false
                };
                await _context.Logs.AddAsync(lo);
                await _context.SaveChangesAsync();
                #endregion


                return RedirectToAction(nameof(Index));

            }
            ViewData["AthorityApproval"] = new SelectList(_context.AthorityMatrices, "Id", "ArabicName", OperationContractsPreparation.AthorityApproval);
            ViewData["RegionId"] = new SelectList(_context.Regions, "Id", "ArabicName", OperationContractsPreparation.RegionId);
            ViewData["ContractTypeId"] = new SelectList(_context.ContractsTypes, "Id", "ArabicName", OperationContractsPreparation.ContractTypeId);
            ViewData["CompanyId"] = new SelectList(_context.Companies, "Id", "NameArabic", OperationContractsPreparation.CompanyId);

            return View(OperationContractsPreparation);
        }

        // GET: UnderPreparationContracts/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null || _context.OperationContractsPreparationAddViewModel == null)
            {
                return NotFound();
            }

            var operationContractsPreparationAddViewModel = await _context.OperationContractsPreparationAddViewModel.FindAsync(id);
            if (operationContractsPreparationAddViewModel == null)
            {
                return NotFound();
            }
            return View(operationContractsPreparationAddViewModel);
        }

        // POST: UnderPreparationContracts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,NameArabic,Name,AthorityApproval,RegionId,ContractTypeId,RequestDate,CompanyId,ContractRequestDate,WavierDate,AwardingApprovalDate,SigningDate,ContractorDate,OpenBidDate,BidEvaluationDate,JobexDate")] OperationContractsPreparationAddViewModel operationContractsPreparationAddViewModel)
        {
            if (id != operationContractsPreparationAddViewModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(operationContractsPreparationAddViewModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OperationContractsPreparationAddViewModelExists(operationContractsPreparationAddViewModel.Id))
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
            return View(operationContractsPreparationAddViewModel);
        }

        // GET: UnderPreparationContracts/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null || _context.OperationContractsPreparationAddViewModel == null)
            {
                return NotFound();
            }

            var operationContractsPreparationAddViewModel = await _context.OperationContractsPreparationAddViewModel
                .FirstOrDefaultAsync(m => m.Id == id);
            if (operationContractsPreparationAddViewModel == null)
            {
                return NotFound();
            }

            return View(operationContractsPreparationAddViewModel);
        }

        // POST: UnderPreparationContracts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            if (_context.OperationContractsPreparationAddViewModel == null)
            {
                return Problem("Entity set 'FTSDContext.OperationContractsPreparationAddViewModel'  is null.");
            }
            var operationContractsPreparationAddViewModel = await _context.OperationContractsPreparationAddViewModel.FindAsync(id);
            if (operationContractsPreparationAddViewModel != null)
            {
                _context.OperationContractsPreparationAddViewModel.Remove(operationContractsPreparationAddViewModel);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool OperationContractsPreparationAddViewModelExists(Guid id)
        {
          return (_context.OperationContractsPreparationAddViewModel?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
