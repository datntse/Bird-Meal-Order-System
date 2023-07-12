using BMOS.Controllers;
using BMOS.Models;
using BMOS.Models.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis;
using NUnit.Framework;

namespace BMOSTest
{
	[TestFixture]
	public class CartTest
	{

		private List<CartModel> cart;
		private BmosContext _context;
		private class CartModel
		{
			public string _productId { get; set; }
			public string _productName { get; set; }
			public int _quantity { get; set; }

			public double? _price { get; set; } = 0;
			public double? _getTotalPrice()
			{
				return this._price * this._quantity;
			}
		}

		[SetUp]
		public void Setup()
		{
			cart = new List<CartModel>();
			_context = new BmosContext();
		}

		private List<CartModel> cartData
		{
			get
			{
				if (cart.Count() == 0)
				{
					cart.Add(new CartModel
					{
						_productId = "product01",
						_productName = "thuc an cho chim",
						_quantity = 3,
						_price = 2
					});
					cart.Add(new CartModel
					{
						_productId = "product02",
						_productName = "thuc an cho cho",
						_quantity = 5,
						_price = 2
					});
				}
				return cart;
			}
		}

		[Test]
		public void UserCheckOut_ProductDataIncart_StoreIntoOrderDetailTable()
		{
			var tblOrderDetail = _context.TblOrderDetails.ToList();
			// data in cart
			var cart = cartData;
			var orderIdTetst = 333;
			foreach (var item in cart)
			{
				orderIdTetst++;
				_context.Add(new TblOrderDetail
				{
					OrderDetailId = "" + orderIdTetst,
					OrderId = new Guid().ToString(),
					Price = item._price,
					ProductId = item._productId,
					Quantity = item._quantity,
					Date = DateTime.Now
				});
			}
			_context.SaveChangesAsync();

			foreach (var orderDetail in tblOrderDetail)
			{
				foreach (var item in cart)
				{
					if(item._productId.Equals(orderDetail))
					{
						Assert.Pass("Product data is add to order detail");
					}	
				}
			}
		}

	}
}
