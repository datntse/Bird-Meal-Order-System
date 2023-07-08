using BMOS.Helpers;
using BMOS.Models;
using BMOS.Models.Entities;
using BMOS.Services;
using Firebase.Auth;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;
using System.Text;
using static Org.BouncyCastle.Crypto.Engines.SM2Engine;


namespace BMOS.Controllers
{
	public class ShoppingCartController : Controller
	{

		private readonly BmosContext _context;
		public ShoppingCartController(BmosContext context)
		{
			_context = context;

		}

		public double? getTotalCartPrice()
		{
			double? result = 0;
			var myCart = Cart;
			foreach (var item in myCart.ToList())
			{
				result += item._getTotalPrice();
			}
			return result;
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
			set
			{

			}
		}

		public IActionResult AddProductInRoutingToCart()
		{
			var myCart = Cart;
			var routingList = HttpContext?.Session.Get<List<RoutingDetailModel>>("Routing");

			// modifier cart empty
			foreach (var _rprod in routingList)
			{
				if (myCart.Count == 0)
				{
					var _product = _context.TblProducts.SingleOrDefault(p => p.ProductId.Equals(_rprod.productId));
					var _productImge = _context.TblImages.FirstOrDefault(x => x.RelationId.Equals(_rprod.productId))?.Url;

					if (_productImge != null)
					{
						string[] delemeter = new string[] { "datnt" };
						string[] image = _productImge.Split(delemeter, StringSplitOptions.None);
						myCart.Add(new CartModel
						{
							_productId = _rprod.productId,
							_productName = _rprod.productName,
							_quantity = _rprod.productQuantity,
							_price = _rprod.productPrice,
							_weight = _product.Weight,
							_productImage = image[0]
						});
					}
					// cart not empty
				} else
				{
					var item = myCart.SingleOrDefault(p => p._productId.Equals(_rprod.productId));
					if (item != null)
					{
						item._quantity += _rprod.productQuantity;
					}
					else
					{
						var _product = _context.TblProducts.SingleOrDefault(p => p.ProductId.Equals(_rprod.productId));
						var _productImge = _context.TblImages.FirstOrDefault(x => x.RelationId.Equals(_rprod.productId))?.Url;

						if (_productImge != null)
						{
							string[] delemeter = new string[] { "datnt" };
							string[] image = _productImge.Split(delemeter, StringSplitOptions.None);
							myCart.Add(new CartModel
							{
								_productId = _rprod.productId,
								_productName = _rprod.productName,
								_quantity = _rprod.productQuantity,
								_price = _rprod.productPrice,
								_weight = _product.Weight,
								_productImage = image[0]
							});
						}
					}
				}
			} 
		
			HttpContext?.Session.Set("Cart", myCart);
			return RedirectToAction("Index");
		}

		public IActionResult Checkout()
		{
			var _priceProduct = getTotalCartPrice();
			decimal? bonusPoint = 0;
			if (_priceProduct >= 100)
			{
				bonusPoint = Math.Round((decimal)_priceProduct, MidpointRounding.AwayFromZero);
			}
			ViewData["bonusPoint"] = bonusPoint;
			// update user point.
			// use point feature
			return View(Cart);
		}


		public async Task<IActionResult> ConfirmOrder(string userId, string orderId, double point = 0)
		{
			var myCart = Cart;
			userId = Encoding.UTF8.GetString(WebEncoders.Base64UrlDecode(userId));
			var order = await _context.TblOrders.Where(o => o.OrderId == orderId).FirstOrDefaultAsync();
			order.IsConfirm = true;
			_context.Update(order);

			var user = await _context.TblUsers.Where(u => u.Username.Equals(userId)).FirstOrDefaultAsync();
			double? currentPoint = user.Point;
			currentPoint += point;
			user.Point = currentPoint;
			_context.Update(user);
			var orderDetailNum = _context.TblOrderDetails.Count(x => x.OrderDetailId != null);
			foreach (var item in myCart.ToList())
			{
				var orderDetail = new TblOrderDetail
				{
					OrderDetailId = "orderdetail" + orderDetailNum,
					OrderId = order.OrderId,
					ProductId = item._productId,
					Quantity = item._quantity,
					Price = item._price,
					Date = DateTime.Now,
				};
				orderDetailNum++;

				_context.Add(orderDetail);
			}
			
			_context.SaveChanges();
			ViewData["confirm"] = "Cảm ơn bạn đã ...";

			myCart.Clear();
			HttpContext?.Session.Set("Cart", myCart);
			return RedirectToAction("Index", "Home");
		}
		[HttpPost]
		public async Task<IActionResult> Payment(string pType= "cod", double point = 0)
		{
			var user = HttpContext.Session.Get<TblUser>("user");
			
			if (user == null) { return RedirectToAction("Login", "Account"); }
			var myCart = Cart;
			var orderNum = _context.TblOrders.Count(x => x.OrderId != null);
			var orderDetailNum = _context.TblOrderDetails.Count(x => x.OrderDetailId != null);
			var orderId = "order" + orderNum;
			var order = new TblOrder
			{
				OrderId = orderId,
				UserId = "" + user.UserId,
				TotalPrice = getTotalCartPrice(),
				Date = DateTime.Now,
				IsConfirm = false,
			};
			_context.Add(order);
			_context.SaveChanges();
			var userId = user.Username;
			userId = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(userId));

			var content = Url.Action("ConfirmOrder", "ShoppingCart", new { userId = userId, orderId = orderId, point = point }, protocol: Request.Scheme);
			await EmailSender.SendEmailAsync(user.Username, "Xác thực tài khoản", "<a href=\"" + content + "\" class=\"linkdetail\" style=\"text-decoration: none; margin: 0 auto; color: black;\">Xác nhận đơn hàng</a>");

			return View();
		}

		public IActionResult RemoveItem(string id)
		{
			var myCart = Cart;
			foreach (var item in myCart.ToList())
			{
				if (item._productId.Equals(id))
				{
					myCart.Remove(item);
				}
			}
			HttpContext?.Session.Set("Cart", myCart);
			return RedirectToAction("UpdateCart");

		}

		public IActionResult UpdateCart(string id, string status, int productQuantity = 1)
		{

			var myCart = Cart;
			foreach (var item in myCart.ToList())
			{
				if (item._productId.Equals(id))
				{
					if (status.Equals("increase"))
					{
						item._quantity += productQuantity;
					}
					else if (status.Equals("decrease"))
					{
						item._quantity -= productQuantity;
						if (item._quantity == 0)
						{
							myCart.Remove(item);
						}
					}
				}
			}
			var user = HttpContext.Session.Get<TblUser>("user");
			double? userPoint = user.Point;
			var _priceProduct = getTotalCartPrice();
			decimal? bonusPoint = 0;
			if (_priceProduct >= 100)
			{
				bonusPoint = Math.Round((decimal)_priceProduct, MidpointRounding.AwayFromZero);
			}
			ViewData["userPoint"] = userPoint;
			ViewData["total"] = _priceProduct;
			ViewData["bonusPoint"] = bonusPoint;

			HttpContext?.Session.Set("Cart", myCart);
			return PartialView(myCart);

		}

		public IActionResult AddToCart(string id, int productQuantity = 1, string type = "Normal")
		{
			var myCart = Cart;
			var item = myCart.SingleOrDefault(p => p._productId.Equals(id));
			var _loginStatus = HttpContext.Session.Get<TblUser>("user") != null ? true : false;
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
						_weight = _product.Weight,
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
			if (_loginStatus) HttpContext?.Session.Set("Cart", myCart);
			if (type == "ajax")
			{
				return Json(new
				{
					productId = id,
					productQuantity = myCart.Count(),
					loginStatus = _loginStatus,
				});
			}
			return RedirectToAction("Index");
		}
		// GET: ShoppingCartController
		public IActionResult Index()
		{
			var user = HttpContext.Session.Get<TblUser>("user");
			if(user == null) { return RedirectToAction("Login", "Account"); }
			double? userPoint = user.Point;
			var _priceProduct = getTotalCartPrice();
			decimal? bonusPoint = 0;
			if (_priceProduct >= 100)
			{
				bonusPoint = Math.Round((decimal)_priceProduct, MidpointRounding.AwayFromZero);
			}
			ViewData["userPoint"] = userPoint;
			ViewData["total"] = _priceProduct;
			ViewData["bonusPoint"] = bonusPoint;
			return View(Cart);



		}

	}
}
