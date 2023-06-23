using BMOS.Models.Entities;
using BMOS.Models;
using BMOS.Models;
using BMOS.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace BMOS.Controllers
{
    public class HomeController : Controller
    {
        private readonly BmosContext _context;

        public HomeController(BmosContext context)
        {
            _context = context;
        }

        // GET: TblProducts
        [HttpGet]
        public async Task<IActionResult> Index(string searchString)
        {
            
            if (!String.IsNullOrEmpty(searchString))
            {     
                return RedirectToAction("ListProduct", "ProductList", new { searchString });
            }

            return _context.TblProducts != null ?
           View(await _context.TblProducts.ToListAsync()) :
           Problem("Entity set 'BmosContext.TblProducts'  is null.");
        }

		public async Task<IActionResult> ChiTiet(string id)
		{
			if (id == null || _context.TblProducts == null)
			{
				return NotFound();
			}

			var recom = _context.TblProducts.Find(id).Type;
			var product = _context.TblProducts.OrderByDescending(s => s.ProductId).Where(x => x.Type == recom).Take(4).ToList();

			if (product == null)
			{
				return NotFound();
			}
			var result = new relatedProduct
			{
				_id = id,
				listProduct = product
			};
			return View(result);

		}


		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}