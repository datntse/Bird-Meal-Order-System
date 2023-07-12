using BMOS.Controllers;
using BMOS.Models;
using BMOS.Models.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;
using System.Threading.Tasks;
using System.Linq;


namespace BMOSTest
{
    public class Tests
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

        [TestCase("product01", 1)]
        [TestCase("product02", 1)]
        [TestCase("product03", 1)]
        public void AddSingleItemToCart_NotEmptyCart_IfItemExsit_ItemQuantityIncreaseOne(string productId, int quantity = 1)
        {
            cart = cartData;
            //create a cart item

            // new item to art

            var QuantityBeforeAdd = 0;
            var QuantityAfterAdd = 0;
            // loop into list cart and find product is add.
            foreach (var iteminCart in cart)
            {
                if (iteminCart._productId.Equals(productId))
                {
                    QuantityBeforeAdd = iteminCart._quantity;
                    iteminCart._quantity += quantity;
                    QuantityAfterAdd = iteminCart._quantity;

                }
            }
            Assert.AreEqual(QuantityBeforeAdd + 1, QuantityAfterAdd);
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

        //[Test]
        //public void UserCheckOut_ProductDataIncart_StoreIntoOrderDetailTable()
        //{
        //    var tblOrderDetail = _context.TblOrderDetails.ToList();
        //    // data in cart
        //    var cart = cartData;
        //    var orderIdTetst = 333;
        //    foreach (var item in cart)
        //    {
        //        orderIdTetst++;
        //        _context.Add(new TblOrderDetail
        //        {
        //            OrderDetailId = "" + orderIdTetst,
        //            OrderId = new Guid().ToString(),
        //            Price = item._price,
        //            ProductId = item._productId,
        //            Quantity = item._quantity,
        //            Date = DateTime.Now
        //        });
        //    }
        //    _context.SaveChangesAsync();

        //    foreach (var orderDetail in tblOrderDetail)
        //    {
        //        foreach (var item in cart)
        //        {
        //            if (item._productId.Equals(orderDetail))
        //            {
        //                Assert.Pass("Product data is add to order detail");
        //            }
        //        }
        //    }

        //}


            public class ProductInfo
            {
                public string ProductId { get; set; }
                public string Name { get; set; }
                public double Price { get; set; }
                public string Description { get; set; }
            }
        [TestFixture]
        public class ProductInfoTests
        {
            private List<ProductInfo> productt;

            [SetUp]
            public void Setup()
            {
                productt = new List<ProductInfo>
        {
            new ProductInfo { ProductId = "01", Name = "Thuc an cho chim1", Price = 100.000, Description = "Thuc an tot cho chim" },
            new ProductInfo { ProductId = "02", Name = "Thuc an cho chim2", Price = 200.000, Description = "Thuc an pho bien cho chim" },
            new ProductInfo { ProductId = "03", Name = "Thuc an cho chim3", Price = 300.000, Description = "Thuc an hat cho chim" }
        };
            }

            //        private static readonly TestCaseData[] ProductDetailTestCases =
            //        {
            //    new TestCaseData("01", "Thuc an cho chim", 100.000, "Thuc an tot cho chim"),
            //    new TestCaseData("02", "Thuc an cho chim", 200.000, "Thuc an pho bien cho chim"),
            //    new TestCaseData("03", "Sản phẩm không tồn tại", 0, "").SetName("Test case sai")
            //};

            //        [TestCaseSource(nameof(ProductDetailTestCases))]
            [TestCase("01", "Thuc an cho chim1", 100.000, "Thuc an tot cho chim")]
            [TestCase("02", "Thuc an cho chim2", 200.000, "Thuc an pho bien cho chim")]
            [TestCase("03", "Thuc an cho chim3", 300.000, "Thuc an hat cho chim")]
            //[TestCase("04", "Sản phẩm không tồn tại", 0, "")]
            public void Product_ValidId_ReturnsProductDetail(string productId, string expectedName, double expectedPrice, string expectedDescription)
            {
                var productDetail = productt.FirstOrDefault(p => p.ProductId == productId);

                Assert.IsNotNull(productDetail);
                Assert.AreEqual(expectedName, productDetail.Name);
                Assert.AreEqual(expectedPrice, productDetail.Price);
                Assert.AreEqual(expectedDescription, productDetail.Description);
            }
        }



    }
}