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
                                where order.UserId.Equals(u.UserId) && order.Status != 0
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
