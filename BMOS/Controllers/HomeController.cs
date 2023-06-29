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
                                 productImage = image.Url,
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