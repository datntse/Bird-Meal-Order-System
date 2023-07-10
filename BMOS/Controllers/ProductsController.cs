using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BMOS.Models.Entities;
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

		public async Task<IActionResult> Product(String id)
		{
			var recom = _context.TblProducts.Where(x => x.ProductId.Equals(id)).FirstOrDefault();
			var _relatedProduct = _context.TblProducts.OrderByDescending(s => s.ProductId).Where(x => x.Type == recom.Type && x.ProductId != id).Take(3);
			var result = from img in _context.TblImages
						 from prod in _relatedProduct
						 where prod.ProductId == img.RelationId
						 select (new RelatedProductModel
						 {
							 _id = prod.ProductId,
							 _prodName = prod.Name,
							 _prodPrice = prod.Price,
							 _image = img.Url
						 });
			var _listProductRelated = result.ToList();
			//from product in _context.TblProducts where product.Status != false select product;
			var productItem = from product in _context.TblProducts
							  from image in _context.TblImages
							  where product.ProductId == image.RelationId
							  select new ProductInfoModel()
							  {
								  ProductId = product.ProductId,
								  Name = product.Name,
								  Price = product.Price,
								  Description = product.Description,
								  IsAvailable = product.IsAvailable,
								  Weight = product.Weight,
								  IsLoved = product.IsLoved,
								  UrlImage = image.Url,
								  relatedProductModels = _listProductRelated
							  };

			var productDetail = await productItem.FirstOrDefaultAsync(item => item.ProductId.Equals(id));
			if (productDetail == null)
			{
				return NotFound();
			}
			return View(productDetail);
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

			var products = from product in _context.TblProducts 
						   from image in _context.TblImages where product.ProductId.Equals(image.RelationId)
						  select new ProductInfoModel()
						  {
							  ProductId = product.ProductId,
							  Name = product.Name,
							  Price = product.Price,
							  Description = product.Description,
							  IsAvailable = product.IsAvailable,
							  Weight = product.Weight,
							  IsLoved = product.IsLoved,
							  UrlImage = image.Url,
							  relatedProductModels = null
						  };
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

            var products = from product in _context.TblProducts
                           from image in _context.TblImages
                           where product.ProductId.Equals(image.RelationId)
                           select new ProductInfoModel()
                           {
                               ProductId = product.ProductId,
                               Name = product.Name,
                               Price = product.Price,
							   type = product.Type,
                               Description = product.Description,
                               IsAvailable = product.IsAvailable,
                               Weight = product.Weight,
                               IsLoved = product.IsLoved,
                               UrlImage = image.Url,
                               relatedProductModels = null
                           };

			var result = products.Where(x => x.type == "1").ToList();
            if (!String.IsNullOrEmpty(searchString))
            {
                result = result.Where(s => s.Name.Contains(searchString)).ToList();
                int count = result.Count();
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
            return View(result.ToPagedList(pageNumber, pageSize));
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

            var products = from product in _context.TblProducts
                           from image in _context.TblImages
                           where product.ProductId.Equals(image.RelationId)
                           select new ProductInfoModel()
                           {
                               ProductId = product.ProductId,
                               Name = product.Name,
                               Price = product.Price,
                               type = product.Type,
                               Description = product.Description,
                               IsAvailable = product.IsAvailable,
                               Weight = product.Weight,
                               IsLoved = product.IsLoved,
                               UrlImage = image.Url,
                               relatedProductModels = null
                           };

            var result = products.Where(x => x.type == "2").ToList();
            if (!String.IsNullOrEmpty(searchString))
            {
                result = result.Where(s => s.Name.Contains(searchString)).ToList();
                int count = result.Count();
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
            return View(result.ToPagedList(pageNumber, pageSize));
        }
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

            var products = from product in _context.TblProducts
                           from image in _context.TblImages
                           where product.ProductId.Equals(image.RelationId)
                           select new ProductInfoModel()
                           {
                               ProductId = product.ProductId,
                               Name = product.Name,
                               Price = product.Price,
                               type = product.Type,
                               Description = product.Description,
                               IsAvailable = product.IsAvailable,
                               Weight = product.Weight,
                               IsLoved = product.IsLoved,
                               UrlImage = image.Url,
                               relatedProductModels = null
                           };

            var result = products.Where(x => x.type == "3").ToList();
            if (!String.IsNullOrEmpty(searchString))
            {
                result = result.Where(s => s.Name.Contains(searchString)).ToList();
                int count = result.Count();
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
            return View(result.ToPagedList(pageNumber, pageSize));
        }

        public IActionResult ChangeLove(string id, string type)
        {
            var result = _context.TblProducts.FirstOrDefault(x => x.ProductId.Equals(id));
            result.IsLoved = !result.IsLoved;
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

		public async Task<IActionResult> Index()
		{
			var products = _context.TblProducts.Where(p => p.IsLoved == true).ToList();


			return View(products);
		}

	}
}
