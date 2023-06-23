using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BMOS.Models.Entities;
using System.Net.Sockets;
using Firebase.Auth;
using Firebase.Storage;
using BMOS.Models;
using BMOS.Models.Services;
using X.PagedList;

namespace BMOS.Controllers
{
    public class TblProductsController : Controller
    {
        private static string ApiKey = "AIzaSyAYLSdMSB9rr3mF2WBNrTNVaxTdMPF_cjo";
        private static string Bucket = "bmos-4bc92.appspot.com";
        private static string AuthEmail = "lechiphat1909@gmail.com";
        private static string AuthPassword = "123456";

        private readonly BmosContext _context;

        public TblProductsController(BmosContext context)
        {
            _context = context;
        }

		public async Task<IActionResult> ListProduct(string sortOrder, string currentFilter, string searchString, int? page)
		{
			ViewData["SearchParameter"] = searchString;
			ViewBag.CurrentSort = sortOrder;
			ViewData["NameSortParm"] = String.IsNullOrEmpty(sortOrder) ? "name" : "";
			ViewData["NameDescSortParm"] = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
			ViewData["PriceSortParm"] = String.IsNullOrEmpty(sortOrder) ? "price" : "";
			ViewData["PriceDescSortParm"] = String.IsNullOrEmpty(sortOrder) ? "price_desc" : "";

			if (searchString != null)
			{
				page = 1;
			}
			else
			{
				searchString = currentFilter;
			}

			ViewBag.CurrentFilter = searchString;

			var products = from s in _context.TblProducts
						   select s;
			if (!String.IsNullOrEmpty(searchString))
			{
				products = products.Where(s => s.Name.Contains(searchString));
				int count = products.Count();
				if (count == 0)
				{
					ViewBag.Message = "No matches found";
				}
				else
				{
					ViewBag.Message = "Có " + count + " kết quả tìm kiếm với từ khóa: " + searchString;
				}
			}

			switch (sortOrder)
			{
				case "name":
					products = products.OrderBy(s => s.Name);
					break;
				case "name_desc":
					products = products.OrderByDescending(s => s.Name);
					break;
				case "price":
					products = products.OrderBy(s => s.Price);
					break;
				case "price_desc":
					products = products.OrderByDescending(s => s.Price);
					break;
				default:
					products = products.OrderBy(s => s.ProductId);
					break;
			}
			int pageSize = 8;
			int pageNumber = (page ?? 1);
			return View(products.ToPagedList(pageNumber, pageSize));
		}

		public async Task<IActionResult> Details(string id)
        {
            if (id == null || _context.TblProducts == null)
            {
                return NotFound();
            }

            var tblProduct = await _context.TblProducts
                .FirstOrDefaultAsync(m => m.ProductId == id);
            if (tblProduct == null)
            {
                return NotFound();
            }

            return View(tblProduct);
        }

       

        private bool TblProductExists(string id)
        {
            return (_context.TblProducts?.Any(e => e.ProductId == id)).GetValueOrDefault();
        }
    }
}
