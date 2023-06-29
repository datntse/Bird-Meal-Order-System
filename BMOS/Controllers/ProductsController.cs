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
    public class ProductsController : Controller
    {
        private static string ApiKey = "AIzaSyAYLSdMSB9rr3mF2WBNrTNVaxTdMPF_cjo";
        private static string Bucket = "bmos-4bc92.appspot.com";
        private static string AuthEmail = "lechiphat1909@gmail.com";
        private static string AuthPassword = "123456";

        private readonly BmosContext _context;

        public ProductsController(BmosContext context)
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

		public async Task<IActionResult> Products(string id)
        {
            if (id == null || _context.TblProducts == null)
            {
                return NotFound();
            }

            var recom = _context.TblProducts.Find(id).Type;
            var product = _context.TblProducts.OrderByDescending(s => s.ProductId).Where(x => x.Type == recom).Take(4).ToList();

            if (product == null)
            {
                return NotFound();
            }
			var result = new relatedProduct
            {
                _id = id,
                listProduct = product
		};
            return View(result);
        }

        
        public async Task<IActionResult> Index()
        {
			var products = _context.TblProducts.Where(p => p.IsLoved == true).ToList();
						   

			return View(products);
        }

		[HttpGet]
		public async Task<IActionResult> ThucAnHat(string sortOrder, string currentFilter, string searchString, int? page)
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

			var products = from s in _context.TblProducts.Where(s => s.Type == "1") select s;
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

        [HttpGet]
        public async Task<IActionResult> ThucAnTuNhien(string sortOrder, string currentFilter, string searchString, int? page)
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

            var products = from s in _context.TblProducts.Where(s => s.Type == "2") select s;
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

        public async Task<IActionResult> ThucAnKho(string sortOrder, string currentFilter, string searchString, int? page)
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

            var products = from s in _context.TblProducts.Where(s => s.Type == "3") select s;
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

        public IActionResult ChangeLove(string id, string type)
        {
            var result = _context.TblProducts.FirstOrDefault(x => x.ProductId.Equals(id));
            result.IsLoved = !result.IsLoved;
            _context.SaveChanges();
            if(type == "ajax")
            {
                return Json(new
                {
                    love = result.IsLoved
                });
            }
            return RedirectToAction("Products", new
            {
                id
            });
        }

        public IActionResult delete(string id, string type)
        {
            var result = _context.TblProducts.FirstOrDefault(x => x.ProductId.Equals(id));
            result.IsLoved = false;
            _context.SaveChanges();
            if (type == "ajax")
            {
                return Json(new
                {
                    love = result.IsLoved
                });
            }
            return RedirectToAction("Products", new
            {
                id
            });
        }


        private bool TblProductExists(string id)
        {
            return (_context.TblProducts?.Any(e => e.ProductId == id)).GetValueOrDefault();
        }
    }
}
