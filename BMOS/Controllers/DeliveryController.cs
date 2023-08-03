using BMOS.Models.Entities;
using BMOS.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BMOS.Helpers;
using Microsoft.AspNetCore.Http;
using Google.Apis.PeopleService.v1.Data;

namespace BMOS.Controllers
{
    public class DeliveryController : Controller
    {

        private readonly BmosContext _context;

        public DeliveryController(BmosContext context)
        {
            _context = context;
        }

        // staff role 2 handle with order
        // confirm delivery
        public async Task<IActionResult> ConfirmDeliveryStatus(string orderId, string status, string note = "")
        {
            var order = await _context.TblOrders.Where(o => o.OrderId.Equals(orderId)).FirstOrDefaultAsync();
            if (order != null)
            {
                if (status.Equals("success"))
                {
                    order.Status = 2;
                }
                else if (status.Equals("failed"))
				{
					order.Status = 3;
                    order.Note = note;
                } else if (status.Equals("refund"))
                {
					order.Status = 7;
					order.Note = "Đơn hoàn trả";
				}
					_context.Update(order);
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
        }


        public IActionResult Index()
        {
            var user = HttpContext.Session.Get<TblUser>("userManager");
            if (user != null)
            {
                if (user.UserRoleId == 1)
                {
                    return View("ErrorPage");
                }
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
            var orderDelivery = from order in _context.TblOrders
                                from u in _context.TblUsers
                                where order.UserId.Equals(u.UserId) && (order.Status != 0 && order.Status != 4)
								select new OrderInfo
                                {
                                    orderID = order.OrderId,
                                    UserName = u.Firstname + u.Lastname,
                                    date = order.Date,
                                    total = order.TotalPrice,
                                    Status = order.Status,
                                    Note = order.Note,
                                };

            var orderSucess = _context.TblOrders.Where(x => x.Status == 8 || x.Status == 5).Count();
            var orderDelivered = _context.TblOrders.Where(x => x.Status == 2).Count();
            var orderDelivering = _context.TblOrders.Where(x => x.Status == 1).Count();
			var orderFailed = _context.TblOrders.Where(x => x.Status == 3).Count();
            var orderRefund = _context.TblOrders.Where(x => x.Status == 6).Count();
            var orderRefunded = _context.TblOrders.Where(x => x.Status == 7).Count();

			ViewData["orderSuccess"] = orderSucess;
			ViewData["orderDelivery"] = orderDelivering;
			ViewData["orderDelivered"] = orderDelivered;
            ViewData["orderRefund"] = orderRefund;
            ViewData["orderRefunded"] = orderRefunded;
            ViewData["orderFailed"] = orderFailed;

			var orderSort = orderDelivery.OrderByDescending(x => x.date).ToList();
			return View(orderSort.ToList());
        }

		// Đơn hàng cần được đi giao
		public IActionResult OrderDelivery()
		{
			var user = HttpContext.Session.Get<TblUser>("userManager");
			if (user != null)
			{
				if (user.UserRoleId == 1)
				{
					return View("ErrorPage");
				}
			}
			else
			{
				return RedirectToAction("Index", "Home");
			}
			var orderDelivery = from order in _context.TblOrders
								from u in _context.TblUsers
								where order.UserId.Equals(u.UserId) &&  order.Status == 1
								select new OrderInfo
								{
									orderID = order.OrderId,
									UserName = u.Firstname + u.Lastname,
									date = order.Date,
									total = order.TotalPrice,
									Status = order.Status,
									Note = order.Note,
								};

			var orderSort = orderDelivery.OrderByDescending(x => x.date).ToList();
			return View(orderSort.ToList());
		}

		// đơn hàng đã giao
		public IActionResult OrderDelivered()
		{
			var user = HttpContext.Session.Get<TblUser>("userManager");
			if (user != null)
			{
				if (user.UserRoleId == 1)
				{
					return View("ErrorPage");
				}
			}
			else
			{
				return RedirectToAction("Index", "Home");
			}
			var orderDelivery = from order in _context.TblOrders
								from u in _context.TblUsers
								where order.UserId.Equals(u.UserId) && order.Status == 2
								select new OrderInfo
								{
									orderID = order.OrderId,
									UserName = u.Firstname + u.Lastname,
									date = order.Date,
									total = order.TotalPrice,
									Status = order.Status,
									Note = order.Note,
								};

			var orderSort = orderDelivery.OrderByDescending(x => x.date).ToList();
			return View(orderSort.ToList());
		}
		// Tạo view đơn hàng thành công
		public IActionResult OrderSuccuess()
		{
			var user = HttpContext.Session.Get<TblUser>("userManager");
			if (user != null)
			{
				if (user.UserRoleId == 1)
				{
					return View("ErrorPage");
				}
			}
			else
			{
				return RedirectToAction("Index", "Home");
			}
			var orderDelivery = from order in _context.TblOrders
								from u in _context.TblUsers
								where order.UserId.Equals(u.UserId) && order.Status == 5 || order.Status == 8
								select new OrderInfo
								{
									orderID = order.OrderId,
									UserName = u.Firstname + u.Lastname,
									date = order.Date,
									total = order.TotalPrice,
									Status = order.Status,
									Note = order.Note,
								};

			var orderSort = orderDelivery.OrderByDescending(x => x.date).ToList();
			return View(orderSort.ToList());
		}

        // Đơn hàng thất bại
		public IActionResult OrderFailed()
		{
			var user = HttpContext.Session.Get<TblUser>("userManager");
			if (user != null)
			{
				if (user.UserRoleId == 1)
				{
					return View("ErrorPage");
				}
			}
			else
			{
				return RedirectToAction("Index", "Home");
			}
			var orderDelivery = from order in _context.TblOrders
								from u in _context.TblUsers
								where order.UserId.Equals(u.UserId) && order.Status == 3
								select new OrderInfo
								{
									orderID = order.OrderId,
									UserName = u.Firstname + u.Lastname,
									date = order.Date,
									total = order.TotalPrice,
									Status = order.Status,
									Note = order.Note,
								};

			var orderSort = orderDelivery.OrderByDescending(x => x.date).ToList();
			return View(orderSort.ToList());
		}
        // Đơn hàng đợi xác nhận , nhận hàng refund
		public IActionResult OrderRefunding()
		{
			var user = HttpContext.Session.Get<TblUser>("userManager");
			if (user != null)
			{
				if (user.UserRoleId == 1)
				{
					return View("ErrorPage");
				}
			}
			else
			{
				return RedirectToAction("Index", "Home");
			}
			var orderDelivery = from order in _context.TblOrders
								from u in _context.TblUsers
								where order.UserId.Equals(u.UserId) && order.Status == 6
								select new OrderInfo
								{
									orderID = order.OrderId,
									UserName = u.Firstname + u.Lastname,
									date = order.Date,
									total = order.TotalPrice,
									Status = order.Status,
									Note = order.Note,
								};

			var orderSort = orderDelivery.OrderByDescending(x => x.date).ToList();
			return View(orderSort.ToList());
		}
		// Đơn hàng nhận hàng refund rồi
		public IActionResult OrderRefunded()
		{
			var user = HttpContext.Session.Get<TblUser>("userManager");
			if (user != null)
			{
				if (user.UserRoleId == 1)
				{
					return View("ErrorPage");
				}
			}
			else
			{
				return RedirectToAction("Index", "Home");
			}
			var orderDelivery = from order in _context.TblOrders
								from u in _context.TblUsers
								where order.UserId.Equals(u.UserId) && order.Status == 7
								select new OrderInfo
								{
									orderID = order.OrderId,
									UserName = u.Firstname + u.Lastname,
									date = order.Date,
									total = order.TotalPrice,
									Status = order.Status,
									Note = order.Note,
								};

			var orderSort = orderDelivery.OrderByDescending(x => x.date).ToList();
			return View(orderSort.ToList());
		}

		public async Task<IActionResult> Details(string id)
        {
            var user = HttpContext.Session.Get<TblUser>("userManager");
            if (user != null)
            {
                if (user.UserRoleId == 1)
                {
                    return View("ErrorPage");
                }
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
            if (id == null || _context.TblFeedbacks == null)
            {
                return NotFound();
            }
            var order = from f in _context.TblOrders
                        join u in _context.TblUsers on f.UserId equals u.UserId
                        select new OrderInfo()
                        {
                            orderID = f.OrderId,
                            UserName = u.Firstname + u.Lastname,
                            Quantity = (int)_context.TblOrderDetails.Where(x => x.OrderId == f.OrderId).Sum(x => x.Quantity),
                            date = f.Date,
                            total = f.TotalPrice,
                            IsConfirm = f.IsConfirm
                        };
            var orderdetails = from d in _context.TblOrderDetails
                               from p in _context.TblProducts
                               from image in _context.TblImages
                               where (d.OrderId == id && p.ProductId.Equals(d.ProductId)) && (d.ProductId.Equals(image.RelationId))
                               select new OrderdetailsInfo()
                               {
                                   orderId = d.OrderId,
                                   namepro = p.Name,
                                   quantity = (int)d.Quantity,
                                   price = (double)(d.Price * d.Quantity),
                                   urlImage = image.Url,
                               };
            var orderdetail = orderdetails.Where(p => p.orderId == id).ToList();
            ViewData["OrderDetails"] = orderdetail.ToList();

            var tblFeedback = await order
                .FirstOrDefaultAsync(m => m.orderID == id);
            if (tblFeedback == null)
            {
                return NotFound();
            }

            return View(tblFeedback);
        }

    }
}
