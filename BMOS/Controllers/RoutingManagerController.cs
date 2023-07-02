using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BMOS.Models.Entities;
using BMOS.Models;
using System.Diagnostics.Metrics;
using System.Collections;

namespace BMOS.Controllers
{
   
    public class RoutingManagerController : Controller
    {
        private readonly BmosContext _context;

        public RoutingManagerController(BmosContext context)
        {
            _context = context;
        }

        // GET: RoutingManager
        public async Task<IActionResult> Index()
        {
            return _context.TblRoutings != null ?
                        View(await _context.TblRoutings.ToListAsync()) :
                        Problem("Entity set 'BmosContext.TblRoutings'  is null.");
        }

        // GET: RoutingManager/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null || _context.TblRoutings == null)
            {
                return NotFound();
            }
            var tblRouting = await _context.TblRoutings
                .FirstOrDefaultAsync(m => m.RoutingId == id);
            if (tblRouting == null)
            {
                return NotFound();
            }
            return View(tblRouting);
        }

        // GET: RoutingManager/Create
        public IActionResult Create()
        {
            var productData = _context.TblProducts.ToList();
            var model = new CreateRoutingByProductIdModel();
            model.selectProductList = new List<SelectListItem>();

            foreach (var product in productData)
            {
                model.selectProductList.Add(new SelectListItem
                {
                    Text = product.Name,
                    Value = product.ProductId
                });
            }
            ViewData["productList"] = model;
            return View();
        }

        // POST: RoutingManager/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("RoutingId,ProductId,Name,Description,Quantity,Price,Status")] TblRouting tblRouting)
        {

            if (ModelState.IsValid)
            {
                _context.Add(tblRouting);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tblRouting);
        }

        // GET: RoutingManager/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null || _context.TblRoutings == null)
            {
                return NotFound();
            }

            var tblRouting = await _context.TblRoutings.FindAsync(id);
            if (tblRouting == null)
            {
                return NotFound();
            }
            return View(tblRouting);
        }

        // POST: RoutingManager/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("RoutingId,ProductId,Name,Description,Quantity,Price,Status")] TblRouting tblRouting)
        {
            if (id != tblRouting.RoutingId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tblRouting);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TblRoutingExists(tblRouting.RoutingId))
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
            return View(tblRouting);
        }

        // GET: RoutingManager/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null || _context.TblRoutings == null)
            {
                return NotFound();
            }

            var tblRouting = await _context.TblRoutings
                .FirstOrDefaultAsync(m => m.RoutingId == id);
            if (tblRouting == null)
            {
                return NotFound();
            }

            return View(tblRouting);
        }

        // POST: RoutingManager/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (_context.TblRoutings == null)
            {
                return Problem("Entity set 'BmosContext.TblRoutings'  is null.");
            }
            var tblRouting = await _context.TblRoutings.FindAsync(id);
            if (tblRouting != null)
            {
                _context.TblRoutings.Remove(tblRouting);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TblRoutingExists(string id)
        {
            return (_context.TblRoutings?.Any(e => e.RoutingId == id)).GetValueOrDefault();
        }
    }
}
