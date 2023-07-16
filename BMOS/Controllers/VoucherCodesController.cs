using BMOS.Models.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BMOS.Controllers
{
	public class VoucherCodesController : Controller
	{
        // GET: VoucherCodesController
        private readonly BmosContext _context;

        public VoucherCodesController(BmosContext context)
        {
            _context = context;
        }
        public ActionResult VoucherManager()
		{
			return View();
		}

		// GET: VoucherCodesController/Details/5
		public ActionResult Details(int id)
		{
			return View();
		}

		// GET: VoucherCodesController/Create
		public ActionResult Create()
		{
			return View();
		}

		// POST: VoucherCodesController/Create
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Create(TblVoucherCode model)
		{
			try
			{
				var voucher = new TblVoucherCode
				{
					VoucherId = model.VoucherId,
					VoucherCode = model.VoucherCode,
					Value = model.Value,
					Quantity = model.Quantity,
					Used = model.Used,
					Status = model.Status,
				};

				_context.TblVoucherCodes.Add(voucher);	
				_context.SaveChanges();
				return RedirectToAction(nameof(Index));
			}
			catch
			{
				return View();
			}
		}

		// GET: VoucherCodesController/Edit/5
		public ActionResult Edit(int id)
		{
			return View();
		}

		// POST: VoucherCodesController/Edit/5
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Edit(int id, IFormCollection collection)
		{
			try
			{
				return RedirectToAction(nameof(Index));
			}
			catch
			{
				return View();
			}
		}

		// GET: VoucherCodesController/Delete/5
		public ActionResult Delete(int id)
		{
			return View();
		}

		// POST: VoucherCodesController/Delete/5
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Delete(int id, IFormCollection collection)
		{
			try
			{
				return RedirectToAction(nameof(Index));
			}
			catch
			{
				return View();
			}
		}
	}
}
