using BMOS.Helpers;
using BMOS.Models;
using BMOS.Models.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis;
using Microsoft.EntityFrameworkCore;


namespace BMOS.Controllers
{
    public class ShoppingCartController : Controller
    {

        private readonly BmosContext _context;
        public ShoppingCartController(BmosContext context)
        {
            _context = context;
        }

        public List<CartModel> Cart
        {
            get
            {
                var data = HttpContext.Session.Get<List<CartModel>>("Cart");
                if (data == null)
                {
                    data = new List<CartModel>();
                }
                return data;
            }
        }

        public IActionResult AddToCart(string id, int productQuantity = 1, string type = "Normal")
        {
            var myCart = Cart;
            var item = myCart.SingleOrDefault(p => p._productId.Equals(id));

            if (item == null)
            {
                var _product = _context.TblProducts.SingleOrDefault(p => p.ProductId.Equals(id));
                var _productImge = _context.TblImages.FirstOrDefault(x => x.RelationId.Equals(id))?.Url;

                if (_productImge != null)
                {
                    string[] delemeter = new string[] { "datnt" };
                    string[] image = _productImge.Split(delemeter, StringSplitOptions.None);
                    item = new CartModel()
                    {
                        _productId = id,
                        _productName = _product.Name,
                        _quantity = productQuantity,
                        _price = _product.Price,
                        _productImage = image[0],
                    };
                }
                myCart.Add(item);
            }
            else
            {
                item._quantity += productQuantity;
            }

			HttpContext?.Session.Set("Cart", myCart);
			if (type == "ajax")
            {
                return Json(new
                {
                    productId = id,
                    productQuantity = myCart.Count(),
                }) ;
            }
            return RedirectToAction("Index");
        }
        // GET: ShoppingCartController
        public IActionResult Index()
        {
            return View(Cart);
        }

    }
}
