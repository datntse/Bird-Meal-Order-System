using BMOS.Controllers;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMOSTest
{
	public class LoginNUnitTest
	{
		[Test]
		public void TestLoginWithCorrectUsernameAndPassword()
		{
			var controller = new AccountController();
			var result = (RedirectToActionResult)controller.Login("kenandkq@gmail.com", "12345");
			Assert.AreEqual("Index", result.ActionName);
		}

		[Test]
		public void TestLoginWithCorrectUsernameAndIncorrectPassword()
		{
			var controller = new AccountController();
			var result = controller.Login("kenandkq@gmail.com", "12345") as ViewResult;
			Assert.AreEqual("Login", result.ViewName);

		}

		[Test]
		public void TestLoginWithInvalidUsername()
		{
			var controller = new AccountController();
			var result = controller.Login("12313123213@gmail.com", "123") as ViewResult;
			Assert.AreEqual("Login", result.ViewName);

		}

		[Test]
		public void TestLoginWithEmpty()
		{
			var controller = new AccountController();
			var result = controller.Login("", "") as ViewResult;
			Assert.AreEqual("Login", result.ViewName);
		}
	}
}
