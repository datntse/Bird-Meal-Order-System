using BMOS.Models;
using BMOS.Models.Entities;
using Microsoft.AspNetCore.Http;

namespace CartTest
{
	public class Tests
	{
		private List<CartModel> cart;
		private BmosContext _context;
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
		public void AddSingleItemToCart_IsEmptyCart(string productId, string productName, double price, int quantity = 1)
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

	}
}