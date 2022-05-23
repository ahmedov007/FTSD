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
    public class AmendmentContractsController : Controller
    {
        private readonly FTSDContext _context;

        public AmendmentContractsController(FTSDContext context)
        {
            _context = context;
        }

        // GET: AmendmentContracts
        public async Task<IActionResult> Index()
        {
              return _context.AmendmentContracts != null ? 
                          View(await _context.AmendmentContracts.ToListAsync()) :
                          Problem("Entity set 'FTSDContext.AmendmentContracts'  is null.");
        }

        // GET: AmendmentContracts/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null || _context.AmendmentContracts == null)
            {
                return NotFound();
            }

            var amendmentContracts = await _context.AmendmentContracts
                .FirstOrDefaultAsync(m => m.Id == id);
            if (amendmentContracts == null)
            {
                return NotFound();
            }

            return View(amendmentContracts);
        }

        // GET: AmendmentContracts/Create
        public IActionResult Create()
        {
            ViewData["AthorityApproval"] = new SelectList(_context.AthorityMatrices, "Id", "ArabicName");
            ViewData["RegionId"] = new SelectList(_context.Regions, "Id", "ArabicName");
            ViewData["ContractTypeId"] = new SelectList(_context.ContractsTypes, "Id", "ArabicName");
            ViewData["CompanyId"] = new SelectList(_context.Companies, "Id", "NameArabic");

            return View();
        }

        // POST: AmendmentContracts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ContractNo,ContractName,ArabicContractName,RegionId,CompanyId,ContractTypeId,AthorityApproval,NewContractActionId,AmendmentRequestDate,AmendmentLetterApprovalDate,SigntureDate,ContractorSignutreDate,AmendmentCost,OptionalPeriodValue,AmendmentPercentage,ModificationDuration,IsDeleted,IsActive")] AmendmentContracts amendmentContracts)
        {
            if (ModelState.IsValid)
            {
                var contracts = new AmendmentContracts
                {

                    Id = new Guid(),
                    ContractNo = amendmentContracts.ContractNo,
                    ContractName = amendmentContracts.ContractName,
                    ArabicContractName = amendmentContracts.ArabicContractName,
                    CompanyId = amendmentContracts.CompanyId,
                    RegionId = amendmentContracts.RegionId,
                    ContractTypeId = amendmentContracts.ContractTypeId,
                    AthorityApproval = amendmentContracts.AthorityApproval,

                    AmendmentLetterApprovalDate = amendmentContracts.AmendmentLetterApprovalDate,
                    AmendmentRequestDate = amendmentContracts.AmendmentRequestDate,
                    ContractorSignutreDate = amendmentContracts.ContractorSignutreDate,
                    SigntureDate = amendmentContracts.SigntureDate,
                    AmendmentCost = amendmentContracts.AmendmentCost,
                    OptionalPeriodValue = amendmentContracts.OptionalPeriodValue,
                   AmendmentPercentage = amendmentContracts.AmendmentPercentage,
                   
                    IsActive = true,
                    IsDeleted = false


                };

                _context.Add(amendmentContracts);
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
                    TableName = "amendmentContracts",
                    IsActive = true,
                    NoDelete = false
                };
                await _context.Logs.AddAsync(lo);
                await _context.SaveChangesAsync();
                #endregion

               
                return RedirectToAction(nameof(Index));
            }
            ViewData["AthorityApproval"] = new SelectList(_context.AthorityMatrices, "Id", "ArabicName", amendmentContracts.AthorityApproval);
            ViewData["RegionId"] = new SelectList(_context.Regions, "Id", "ArabicName", amendmentContracts.RegionId);
            ViewData["ContractTypeId"] = new SelectList(_context.ContractsTypes, "Id", "ArabicName", amendmentContracts.ContractTypeId);
            ViewData["CompanyId"] = new SelectList(_context.Companies, "Id", "NameArabic", amendmentContracts.CompanyId);

            return View(amendmentContracts);
        }

        // GET: AmendmentContracts/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null || _context.AmendmentContracts == null)
            {
                return NotFound();
            }

            var amendmentContracts = await _context.AmendmentContracts.FindAsync(id);
            if (amendmentContracts == null)
            {
                return NotFound();
            }
            return View(amendmentContracts);
        }

        // POST: AmendmentContracts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,ContractNo,ContractName,ArabicContractName,RegionId,CompanyId,ContractTypeId,AthorityApproval,NewContractActionId,AmendmentRequestDate,AmendmentLetterApprovalDate,SigntureDate,ContractorSignutreDate,AmendmentCost,OptionalPeriodValue,AmendmentPercentage,ModificationDuration,IsDeleted,IsActive")] AmendmentContracts amendmentContracts)
        {
            if (id != amendmentContracts.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(amendmentContracts);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AmendmentContractsExists(amendmentContracts.Id))
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
            return View(amendmentContracts);
        }

        // GET: AmendmentContracts/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null || _context.AmendmentContracts == null)
            {
                return NotFound();
            }

            var amendmentContracts = await _context.AmendmentContracts
                .FirstOrDefaultAsync(m => m.Id == id);
            if (amendmentContracts == null)
            {
                return NotFound();
            }

            return View(amendmentContracts);
        }

        // POST: AmendmentContracts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            if (_context.AmendmentContracts == null)
            {
                return Problem("Entity set 'FTSDContext.AmendmentContracts'  is null.");
            }
            var amendmentContracts = await _context.AmendmentContracts.FindAsync(id);
            if (amendmentContracts != null)
            {
                _context.AmendmentContracts.Remove(amendmentContracts);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AmendmentContractsExists(Guid id)
        {
          return (_context.AmendmentContracts?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
