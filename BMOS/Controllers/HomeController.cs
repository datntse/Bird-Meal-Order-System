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
        //[HttpGet]
        //public async Task<IActionResult> Index(string sortOrder, string currentFilter, string searchString, int? page)
        //{
        //    ViewBag.CurrentSort = sortOrder;

        //    if (searchString != null)
        //    {
        //        page = 1;
        //    }
        //    else
        //    {
        //        searchString = currentFilter;
        //    }
        //    int pageSize = 8;
        //    int pageNumber = (page ?? 1);
        //    ViewBag.CurrentFilter = searchString;

        //    var products = from s in _context.TblProducts
        //                   select s;
        //    if (!String.IsNullOrEmpty(searchString))
        //    {
        //        products = products.Where(s => s.Name.Contains(searchString));
        //        int count = products.Count();
        //        if (count == 0)
        //        {
        //            ViewBag.Message = "No matches found";
        //        }
        //        else
        //        {
        //            ViewBag.Message = "Có " + count + " kết quả tìm kiếm với từ khóa: " + searchString;
        //        }
        //        return RedirectToAction("ListProduct", "ProductList", new { searchString });
        //        //return View("~/Views/ProductList/ListProduct.cshtml", students.ToPagedList(pageNumber, pageSize));
        //    }

        //    return _context.TblProducts != null ?
        //   View(await _context.TblProducts.ToListAsync()) :
        //   Problem("Entity set 'BmosContext.TblProducts'  is null.");
        
        //}

		public async Task<IActionResult> Index()
		{
			//from product in _context.TblProducts where product.Status != false select product;
			var listProdct = from product in _context.TblProducts
							 from image in _context.TblImages
							 where product.ProductId == image.RelationId && product.Status != false
							 select new
							 {
								 productId = product.ProductId,
								 productName = product.Name,
								 productPrice = product.Price,
								 productImage = image.Url
							 };
			return listProdct != null ? View(await listProdct.ToListAsync()) : Problem("Entity set 'BmosContext.TblProducts' is null");
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}