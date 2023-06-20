using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BMOS.Models.Entities;
using System.Net.Sockets;
using Firebase.Auth;
using Firebase.Storage;
using BMOS.Models;
using BMOS.Models.Services;
namespace BMOS.Controllers
{
    public class TblProductsController : Controller
    {
        private static string ApiKey = "AIzaSyAYLSdMSB9rr3mF2WBNrTNVaxTdMPF_cjo";
        private static string Bucket = "bmos-4bc92.appspot.com";
        private static string AuthEmail = "lechiphat1909@gmail.com";
        private static string AuthPassword = "123456";

        private readonly BmosContext _context;

        public TblProductsController(BmosContext context)
        {
            _context = context;
        }

        // GET: TblProducts
        public async Task<IActionResult> Index()
        {
            return _context.TblProducts != null ?
                        View(await _context.TblProducts.ToListAsync()) :
                        Problem("Entity set 'BmosContext.TblProducts'  is null.");
        }
        public async Task<IActionResult> ProductList()
        {
            return _context.TblProducts != null ?
                        View(await _context.TblProducts.ToListAsync()) :
                        Problem("Entity set 'BmosContext.TblProducts'  is null.");
        }

        // GET: TblProducts/Details/5
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

        // GET: TblProducts/Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ProductId,Name, Quantity, Price, Description,Weight,IsAvailable,IsLoved,Status")] TblProduct tblProduct, List<IFormFile> files)
        {

            string url = "";
            if (ModelState.IsValid)
            {
                url = await FirebaseService.UploadImage(files);
                _context.Add(tblProduct);
                TblImage tblImage = new TblImage
                {
                    ImageId = Guid.NewGuid().ToString(),
                    Name = "Product img",
                    RelationId = tblProduct.ProductId,
                    Type = "Product",
                    Url = url
                };
                _context.TblImages.Add(tblImage);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));

            }

            return View(tblProduct);
        }


        // GET: TblProducts/Edit/5
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

        // POST: TblProducts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("ProductId,Name,Quantity,Description,Weight,IsAvailable,IsLoved,Status")] TblProduct tblProduct)
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

        // GET: TblProducts/Delete/5
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

        // POST: TblProducts/Delete/5
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
