using BMOS.Models;
using BMOS.Models.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis;

namespace BMOS.Controllers
{
    public class RoutingController : Controller
    {
        private BmosContext _context;
        public RoutingController(BmosContext context) {
            _context = context;
        }
        // GET: RoutingController
        public ActionResult Index()
        {
            return View();
        }

        // GET: RoutingController/Details/5
        public IActionResult RoutingDetail(string id)
        {
            var routingList = from routing in _context.TblRoutings
                              from image in _context.TblImages
                              where image.RelationId == id && routing.Status != false
                              select new RoutingHomePageModel
                              {
                                  routingId = routing.RoutingId,
                                  routingName = routing.Name,
                                  routingPrice = routing.Price,
                                  routingImage = image.Url,
                              };
            ViewData["Routing"] = routingList.FirstOrDefault(x => x.routingId == id);
            var productList = from prod in _context.TblProductInRoutings
                              from _prod in _context.TblProducts
                              from _img in _context.TblImages
                              where prod.RoutingId == id && _prod.ProductId == prod.ProductId && _prod.ProductId == _img.RelationId
                              select new RoutingDetailModel()
                              {
                                  productId = _prod.ProductId,
                                  productName = _prod.Name,
                                  productPrice = _prod.Price,
                                  productQuantity = 1,
                                  description = _prod.Description,
                                  image = _img.Url
                              };
            return View(productList.ToList());
        }
     
    }
}
