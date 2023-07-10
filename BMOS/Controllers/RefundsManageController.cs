using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BMOS.Models.Entities;
using X.PagedList;
using BMOS.Models;
using Org.BouncyCastle.Asn1.X9;

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
        public async Task<IActionResult> Index(string sortOrder, string currentFilter, string searchString, int? page)
        {
            ViewData["SearchParameter"] = searchString;
            ViewBag.CurrentSort = sortOrder;
            ViewData["IdSortParm"] = String.IsNullOrEmpty(sortOrder) ? "Id" : "";
            ViewData["IdDescSortParm"] = String.IsNullOrEmpty(sortOrder) ? "Id_desc" : "";
            ViewData["DateSortParm"] = String.IsNullOrEmpty(sortOrder) ? "date" : "";
            ViewData["DateDescSortParm"] = String.IsNullOrEmpty(sortOrder) ? "date_desc" : "";

            if (searchString != null)
            {
                page = 1;
            }
            else
            {
                searchString = currentFilter;
            }
            ViewBag.CurrentFilter = searchString;

            var refunds = from f in _context.TblRefunds
                          from o in _context.TblOrders
                          where f.UserId.Equals(o.UserId) && f.OrderId.Equals(o.OrderId)
                          select new RefundsInfoModel()
                          {
                              RefundId = f.RefundId,
                              UserId = o.UserId,
                              OrderId = o.OrderId,
                              Description = f.Description,
                              Date = f.Date,
                              IsConfirm = f.IsConfirm,  
                          };
            if (!String.IsNullOrEmpty(searchString))
            {
                refunds = refunds.Where(s => s.RefundId.Contains(searchString));
                int count = refunds.Count();
                if (count == 0)
                {
                    ViewBag.Message = "No matches found";
                }
                else
                {
                    ViewBag.Message = "Có " + count + " kết quả tìm kiếm với từ khóa: " + searchString;
                }
            }


            switch (sortOrder)
            {
                case "Id":
                    refunds = refunds.OrderBy(s => s.RefundId);
                    break;
                case "Id_desc":
                    refunds = refunds.OrderByDescending(s => s.RefundId);
                    break;
                case "date":
                    refunds = refunds.OrderBy(s => s.Date);
                    break;
                case "date_desc":
                    refunds = refunds.OrderByDescending(s => s.Date);
                    break;
                default:
                    refunds = refunds.OrderBy(s => s.RefundId);
                    break;
            }
            int pageSize = 8;
            int pageNumber = (page ?? 1);
            return View(refunds.ToPagedList(pageNumber, pageSize));
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
					if (tblRefund.IsConfirm == true)
					{
						TblNotify notify = new TblNotify();
						{
							notify.NotifyId = Guid.NewGuid().ToString();
							notify.UserId = tblRefund.UserId;
							notify.Date = tblRefund.Date;
							notify.Type = "refund";
							notify.Message = "Đơn hàng " + tblRefund.OrderId + " đã được xác nhận!";
							_context.Add(notify);
							_context.SaveChanges();
						}
					}
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
