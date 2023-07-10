using BMOS.Controllers;
using BMOS.Models;
using BMOS.Models.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis;
using NUnit.Framework;

namespace BMOSTest
{
	public class Tests
	{
		private List<CartModel> cart;
		[TestFixture]
		public class CartModel
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
			_context = new BmosContext();
			cart = new List<CartModel>();
		}

		[TestCase("product01", "Thuc an cho chim", 1, 300)]
		[TestCase("product123", "Thuc an cho cho", 1, 420)]
		[TestCase("product450", "Thuc an cho bo", 1, 350)]
		public void AddSingleItemToCart_InEmptyCart(string productId, string productName, double price, int quantity = 1)
		{
			// clear cart
			cart.Clear();
			//create a cart item
			CartModel item = new CartModel
			{
				_productId = productId,
				_productName = productName,
				_quantity = quantity,
				_price = price
			};
			cart.Add(item);

			// loop into list cart and find product is add.
			foreach (var iteminCart in cart)
			{
				var productIdWasAdd = item._productId;
				var productIdInCart = iteminCart._productId;
				Assert.AreEqual(productIdWasAdd, productIdInCart);
			}
		}
		[Test]
		public void AddEmptyItemToCart_InEmptyCart()
		{
			// clear cart
			cart.Clear();
			CartModel item = new CartModel();
			//create a cart item
			cart.Add(item);

			// loop into list cart and find product is add.
			foreach(var iteminCart in cart)
			{
				Assert.IsNull(iteminCart._productId);
			}
		}

		[TestCase("product01", "Thuc an cho chim", 300, 1)]
		[TestCase("product02", "Thuc an cho chim", 300, 1)]
		public void AddSingleItemToCart_NotEmptyCart_IfItemExsit_ItemQuantityIncreaseOne(string productId, string productName, double price, int quantity = 1)
		{
			cart.Clear();
			//create a cart item
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

			// new item to art
			CartModel item = new CartModel
			{
				_productId = productId,
				_productName = productName,
				_quantity = quantity,
				_price = price
			};
			cart.Add(item);

			// loop into list cart and find product is add.
			foreach (var iteminCart in cart)
			{
				var currentProductQuantity = iteminCart._quantity;
				if(iteminCart._productId.Equals(productId)) {
					iteminCart._quantity += quantity;
					Assert.AreEqual(currentProductQuantity + 1, iteminCart._quantity);
				}
			}


		}
		[Test]
		public void RemoveItemFromCart_ItemExist_InCart()
		{
			// create a cart item
			CartModel item1 = new CartModel
			{
				_productId = "product01",
				_productName = "Thuc an cho chim",
				_quantity = 1,
				_price = 300
			};

			CartModel item2 = new CartModel
			{
				_productId = "product02",
				_productName = "Thuc an cho cun",
				_quantity = 1,
				_price = 420
			};

			// add items to cart
			cart.Add(item1);
			cart.Add(item2);

			// remove an item from cart
			var itemToRemove = item1;
			cart.Remove(itemToRemove);

			// assert that the item is removed from cart
			CollectionAssert.DoesNotContain(cart, itemToRemove);
		}
		[Test]
		public void GetTotalPrice_CartNotEmpty()
		{
			// create cart items
			CartModel item1 = new CartModel
			{
				_productId = "product01",
				_productName = "Thuc an cho chim",
				_quantity = 2,
				_price = 300
			};

			CartModel item2 = new CartModel
			{
				_productId = "product02",
				_productName = "Thuc an cho cun",
				_quantity = 1,
				_price = 420
			};

			// add items to cart
			cart.Add(item1);
			cart.Add(item2);

			double expectedTotalPrice = item1._getTotalPrice().Value + item2._getTotalPrice().Value;

			double actualTotalPrice = 0;
			// calculate total price of cart
			foreach (var item in cart)
			{
				actualTotalPrice += item._getTotalPrice().Value;
			}

			// assert that the calculated total price is correct
			Assert.AreEqual(expectedTotalPrice, actualTotalPrice);
		}
		

    }
}