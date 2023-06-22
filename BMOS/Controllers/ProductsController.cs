using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BMOS.Models.Entities;
using BMOS.Models;
using System.Runtime.CompilerServices;

namespace BMOS.Controllers
{
	public class ProductsController : Controller
	{
		private readonly BmosContext _context;

		public ProductsController(BmosContext context)
		{
			_context = context;
		}

		// GET: Products
		public async Task<IActionResult> Product(String id)
		{
			//from product in _context.TblProducts where product.Status != false select product;
			var productItem = from product in _context.TblProducts
							  from image in _context.TblImages
							  where product.ProductId == image.RelationId
							  select new ProductInfoModel()
							  {
								  ProductId = product.ProductId,
								  Name = product.Name,
								  Price = product.Price,
								  Description = product.Description,
								  IsAvailable = product.IsAvailable,
								  IsLoved = product.IsLoved,
								  UrlImage = image.Url
							  };
			var productDetail = await productItem.FirstOrDefaultAsync(item => item.ProductId.Equals(id));
			if (productDetail == null)
			{
				return NotFound();
			}
			return View(productDetail);
		}

		// GET: Products/Details/5
		public async Task<IActionResult> Details(string id)
		{
			if (id == null || _context.TblProducts == null)
			{
				return NotFound();
			}

			var tblProduct = await _context.TblProducts
				.FirstOrDefaultAsync(m => m.ProductId == id);
			if (tblProduct == null)
			{
				return NotFound();
			}

			return View(tblProduct);
		}

		// GET: Products/Create
		public IActionResult Create()
		{
			return View();
		}

		// POST: Products/Create
		// To protect from overposting attacks, enable the specific properties you want to bind to.
		// For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Create([Bind("ProductId,Name,Quantity,Price,Description,Weight,IsAvailable,IsLoved,Status")] TblProduct tblProduct)
		{
			if (ModelState.IsValid)
			{
				_context.Add(tblProduct);
				await _context.SaveChangesAsync();
				return RedirectToAction(nameof(Index));
			}
			return View(tblProduct);
		}

		// GET: Products/Edit/5
		public async Task<IActionResult> Edit(string id)
		{
			if (id == null || _context.TblProducts == null)
			{
				return NotFound();
			}

			var tblProduct = await _context.TblProducts.FindAsync(id);
			if (tblProduct == null)
			{
				return NotFound();
			}
			return View(tblProduct);
		}

		// POST: Products/Edit/5
		// To protect from overposting attacks, enable the specific properties you want to bind to.
		// For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Edit(string id, [Bind("ProductId,Name,Quantity,Price,Description,Weight,IsAvailable,IsLoved,Status")] TblProduct tblProduct)
		{
			if (id != tblProduct.ProductId)
			{
				return NotFound();
			}

			if (ModelState.IsValid)
			{
				try
				{
					_context.Update(tblProduct);
					await _context.SaveChangesAsync();
				}
				catch (DbUpdateConcurrencyException)
				{
					if (!TblProductExists(tblProduct.ProductId))
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
			return View(tblProduct);
		}

		// GET: Products/Delete/5
		public async Task<IActionResult> Delete(string id)
		{
			if (id == null || _context.TblProducts == null)
			{
				return NotFound();
			}

			var tblProduct = await _context.TblProducts
				.FirstOrDefaultAsync(m => m.ProductId == id);
			if (tblProduct == null)
			{
				return NotFound();
			}

			return View(tblProduct);
		}

		// POST: Products/Delete/5
		[HttpPost, ActionName("Delete")]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> DeleteConfirmed(string id)
		{
			if (_context.TblProducts == null)
			{
				return Problem("Entity set 'BmosContext.TblProducts'  is null.");
			}
			var tblProduct = await _context.TblProducts.FindAsync(id);
			if (tblProduct != null)
			{
				_context.TblProducts.Remove(tblProduct);
			}

			await _context.SaveChangesAsync();
			return RedirectToAction(nameof(Index));
		}

		private bool TblProductExists(string id)
		{
			return (_context.TblProducts?.Any(e => e.ProductId == id)).GetValueOrDefault();
		}
	}
}
