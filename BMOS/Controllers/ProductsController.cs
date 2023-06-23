using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BMOS.Models.Entities;
using BMOS.Models;
using System.Runtime.CompilerServices;

namespace BMOS.Controllers
{
	public class ProductsController : Controller
	{
		private readonly BmosContext _context;

		public ProductsController(BmosContext context)
		{
			_context = context;
		}

		// GET: Products
		public async Task<IActionResult> Product(String id)
		{
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
								  IsLoved = product.IsLoved,
								  UrlImage = image.Url
							  };
			var productDetail = await productItem.FirstOrDefaultAsync(item => item.ProductId.Equals(id));
			if (productDetail == null)
			{
				return NotFound();
			}
			return View(productDetail);
		}

		public IActionResult RelatedProduct(String id)
		{
			if (id == null || _context.TblProducts == null)
			{
				return NotFound();
			}

			var recom = _context.TblProducts.Find(id).Type;
			var product = _context.TblProducts.OrderByDescending(s => s.ProductId).Where(x => x.Type == recom).Take(3).ToList();

			if (product == null)
			{
				return NotFound();
			}
			var result = new RelatedProductModel
			{
				_id = id,
				listProduct = product
			};
			return View(result);
		}
	}
}
