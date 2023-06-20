using BMOS.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BMOS.Controllers
{
    public class CartController : Controller
    {
        private readonly BmosContext _context;
        public CartController(BmosContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            //var query  = _context.TblProducts.ToList();
            return View();
        }
        public IActionResult AddtoCart(String id) 
        {
            //var query = _context.TblProducts.Where(x => x.ProductId == id).SingleOrDefault();
            return View(); 
        }
    }
}
