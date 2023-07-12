using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Interactions;

namespace BMOS
{
	class SeleniumDemo
	{
		IWebDriver driver;

		[SetUp]
		public void SetupTest()
		{
			//driver = new ChromeDriver("D:\\TESTER\\SeleniumC#");
			driver = new EdgeDriver("D:\\TESTER\\SeleniumC#");
			driver.Manage().Window.Maximize();
		}

		[Test]
		public void AddSingleProductToCart()
		{
			driver.Navigate().GoToUrl("https://localhost:44388/Account/Login");

			Thread.Sleep(1000);
		
			Thread.Sleep(2000);
			IWebElement userName = driver.FindElement(By.Name("username"));
			userName.Clear();
			userName.SendKeys("kenandkq@gmail.com");
			Thread.Sleep(1000);
			IWebElement password = driver.FindElement(By.Name("password"));
			password.Clear();
			password.SendKeys("123");

			driver.FindElement(By.Id("submit")).Click();

			Thread.Sleep(1000);

			driver.Navigate().GoToUrl("https://localhost:44388/products/product/0a17408e-477f-4331-9e85-e4b6e610a6c9");

			IWebElement item = driver.FindElement(By.ClassName("button-action--add-cart"));
			item.Click();

			Thread.Sleep(2000);
			driver.Navigate().GoToUrl("https://localhost:44388/ShoppingCart");
			IWebElement itemQuantity = driver.FindElement(By.XPath("//h6[normalize-space()='1 items']"));

			string productInCart = itemQuantity.Text;
			Assert.AreEqual(productInCart, "1 items");
			Thread.Sleep(1000);
		}

		[TearDown]
		public void CloseTest()
		{
			driver.Close();
		}
	}
}