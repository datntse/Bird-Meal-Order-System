using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BMOS.Models.Entities;

namespace BMOS.Controllers
{
    public class RefundsManageController : Controller
    {
        private readonly BmosContext _context;

        public RefundsManageController(BmosContext context)
        {
            _context = context;
        }

        // GET: RefundsManage
        public async Task<IActionResult> Index()
        {
              return _context.TblRefunds != null ? 
                          View(await _context.TblRefunds.ToListAsync()) :
                          Problem("Entity set 'BmosContext.TblRefunds'  is null.");
        }

        // GET: RefundsManage/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null || _context.TblRefunds == null)
            {
                return NotFound();
            }

            var tblRefund = await _context.TblRefunds
                .FirstOrDefaultAsync(m => m.RefundId == id);
            if (tblRefund == null)
            {
                return NotFound();
            }

            return View(tblRefund);
        }

        // GET: RefundsManage/Create
        
        // GET: RefundsManage/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null || _context.TblRefunds == null)
            {
                return NotFound();
            }

            var tblRefund = await _context.TblRefunds.FindAsync(id);
            if (tblRefund == null)
            {
                return NotFound();
            }
            return View(tblRefund);
        }

        // POST: RefundsManage/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("RefundId,UserId,OrderId,Description,Date,IsConfirm")] TblRefund tblRefund)
        {
            if (id != tblRefund.RefundId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tblRefund);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TblRefundExists(tblRefund.RefundId))
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
            return View(tblRefund);
        }

        
        private bool TblRefundExists(string id)
        {
          return (_context.TblRefunds?.Any(e => e.RefundId == id)).GetValueOrDefault();
        }
    }
}
