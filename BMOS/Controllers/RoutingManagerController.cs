﻿using System;
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
using BMOS.Models.Services;
using System.Security.Policy;

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
        public async Task<IActionResult> Create()
        {
            var productData = await _context.TblProducts.ToListAsync();
            var model = new TblRouting();
            model.listProduct = new List<SelectListItem>();
            foreach (var product in productData)
            {
                model.listProduct.Add(new SelectListItem
                {
                    Text = product.Name,
                    Value = product.ProductId
                });
            }
            return View(model);
        }

        // POST: RoutingManager/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(TblRouting model, List<IFormFile> files)
        {
            ModelState.Remove("listProduct");
            ModelState.Remove("RoutingId");
            string url = "";
            double? priceRouting = 0;
            var productList = model.listProductId;
            if (ModelState.IsValid)
            {
				foreach (var _prodId in productList)
				{
					foreach (var _prod in _context.TblProducts)
					{
						if (_prod.ProductId == _prodId)
						{
							priceRouting += _prod.Price;
						}
					}
					_context.Add(new TblProductInRouting
					{
						RoutingId = model.RoutingId,
						ProductId = _prodId,

					});
				}

				url = await FirebaseService.UploadImage(files, "routing");
                _context.Add(new TblImage
                {
                    ImageId = Guid.NewGuid().ToString(),
                    Name = "Routing img",
                    RelationId = model.RoutingId,
                    Type = "Routing",
                    Url = url
                });
                _context.Add(new TblRouting
                {
                    RoutingId = model.RoutingId,
                    Name = model.Name,
                    Description = model.Description,
                    Quantity = model.Quantity,
                    Price = priceRouting,
					Status = model.Status,
                });

                
               
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["Price"] = priceRouting;
            return View(model);
        }

        // GET: RoutingManager/Edit/5
        public async Task<IActionResult> Edit(string id)
        {

            var routing = await _context.TblRoutings.FindAsync(id);


            if (routing == null)
            {
                return NotFound();
            }


            var products = await _context.TblProducts.ToListAsync();


            var availableProducts = new List<TblProduct>();

            foreach (var product in products)
            {

                if (!routing.TblRoutingProducts.Any(rp => rp.ProductId == product.ProductId))
                {
                    availableProducts.Add(product);
                }
            }


            var model = new TblRouting
            {
                RoutingId = routing.RoutingId,
                Name = routing.Name,
                Description = routing.Description,
                Quantity = routing.Quantity,
                Price = routing.Price,
                Status = routing.Status,
                listProduct = new List<SelectListItem>()
            };


            foreach (var product in availableProducts)
            {
                model.listProduct.Add(new SelectListItem
                {
                    Text = product.Name,
                    Value = product.ProductId
                });
            }


            var selectedProductIds = routing.TblRoutingProducts.Select(rp => rp.ProductId).ToList();


            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, TblRouting model, List<IFormFile> files)
        {

            var routing = await _context.TblRoutings.FindAsync(id);


            if (routing == null)
            {
                return NotFound();
            }


            _context.TblRoutingProducts.RemoveRange(_context.TblRoutingProducts.Where(rp => rp.RoutingId == id));


            var productList = model.listProductId;


            foreach (var productId in productList)
            {
                routing.TblRoutingProducts.Add(new TblRoutingProduct
                {
                    RoutingId = id,
                    ProductId = productId
                });
            }


            _context.TblRoutings.Update(routing);
            await _context.SaveChangesAsync();


            return RedirectToAction(nameof(Index));
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
            var tblProductInRouting = _context.TblProductInRoutings.Where(x => x.RoutingId.Equals(id));
            if (tblRouting != null && tblProductInRouting != null)
            {
                _context.TblRoutings.Remove(tblRouting);
                foreach(var tbl in tblProductInRouting) {
                _context.TblProductInRoutings.Remove(tbl);
                }
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
