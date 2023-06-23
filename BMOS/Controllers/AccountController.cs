using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.WebUtilities;
using System.Text;
using System.Text.Encodings.Web;
using BMOS.Models.Entities;
using BMOS.Services;
using Microsoft.AspNetCore.Http;
using Firebase.Auth;

namespace BMOS.Controllers
{
    public class AccountController : Controller
    {
        private BmosContext _db = new BmosContext();
        public IActionResult Login()
        {
            var user = HttpContext.Session.GetString("username");
            if (user != null)
            {
                return RedirectToAction("UserProfile");
            }
            return View();
        }

        [HttpPost]
        public IActionResult Login(TblUser model)
        {
            //if (ModelState.IsValid){
            string username = model.Username;
            string password = model.Password;

            if (username != null || password != null)
            {
                var check = _db.TblUsers.Where(p => p.Username.Equals(username) && p.Password.Equals(password)).Select(p => p.UserRoleId);
                if (check.Count() > 0)
                {
                    var checkStatus = _db.TblUsers.Where(p => p.Status == true);
                    var id = check.First();                   
                    string sid = Convert.ToString(id);
                    HttpContext.Session.SetString("id", sid);                   
                    if (id == 1)
                    {
                        HttpContext.Session.SetString("username", username);
                        return RedirectToAction("Index", "ProductManager");
                    }
                    if (id == 2 && checkStatus.Count() > 0)
                    {
                        HttpContext.Session.SetString("username", username);
                        return RedirectToAction("Index", "ProductManager");
                    }
                    if (id == 3 && checkStatus.Count() > 0)
                    {
                        var checkConfirm = _db.TblUsers.Where(p => p.Username.Equals(username) && p.IsConfirm == true).ToList();
                        //string fullname = _db.TblUsers.Where(p => p.Username.Equals(username)).Select(p => p.Firstname).First() + " " + _db.TblUsers.Where(p => p.Username.Equals(username)).Select(p => p.Lastname).First();
                        var user = _db.TblUsers.Where(p => p.Username.Equals(username)).First();
                        string fullname = user.Firstname + " " + user.Lastname;

                        if (checkConfirm.Count() > 0)
                        {
                            HttpContext.Session.SetString("username", username);
                            HttpContext.Session.SetString("fullname", fullname);
                            return RedirectToAction("Index", "Home");
                        }
                        ViewBag.EmailConfirm = "*Tài khoản của bạn chưa được kích hoạt, vui lòng kiểm tra Email để xác nhận tài khoản.";
                        return View();
                    }                                                            
                    ViewBag.Block = "*Tài khoản của bạn đã bị khóa. Nếu có vấn đề cần giải đáp xin vui lòng liên hệ với chúng tôi.";
                    return View();
                }
                else
                {
                    ViewBag.Notice = "*Tên đăng nhập hoặc mật khẩu không chính xác.";
                    return View();
                }
            }
            //}
            return View();
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Remove("username");
            HttpContext.Session.Remove("fullname");
            return RedirectToAction("Index", "Home");
        }
        public IActionResult Register()
        {
            var user = HttpContext.Session.GetString("username");
            if (user != null)
            {
                return RedirectToAction("UserProfile");
            }
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> RegisterAsync(TblUser model)
        {

            var userId = model.Username;
            var code = "qwert";
            code = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(code));
            userId = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(userId));
            var content = Url.Action("ConfirmEmail", "Account", new { userId = userId, code = code }, protocol: Request.Scheme);
            var check = _db.TblUsers.FirstOrDefault(p => p.Username == model.Username);

            if (check == null)
            {
                _db.TblUsers.Add(model);
                await EmailSender.SendEmailAsync(model.Username, "Xác thực tài khoản", "<a href=\"" + content + "\" class=\"linkdetail\" style=\"text-decoration: none; margin: 0 auto; color: black;\">Kích hoạt tài khoản</a>");
                _db.SaveChanges();

                ViewBag.RegisterSuccess = "*Đăng ký tài khoản thành công, vui lòng kiểm tra ";
                return View();
            }
            else
            {
                ViewBag.Error = "*Email đã được đăng ký.";
                return View();
            }
        }

        public IActionResult ConfirmEmail(string userId, string code)
        {
            var user = HttpContext.Session.GetString("username");
            if (user != null)
            {
                return RedirectToAction("UserProfile");
            }
            if (userId == null || code == null)
            {
                return RedirectToAction("Index", "Home");
            }
            userId = Encoding.UTF8.GetString(WebEncoders.Base64UrlDecode(userId));
            var check = _db.TblUsers.FirstOrDefault(p => p.Username == userId);
            if (check != null)
            {
                check.IsConfirm = true;
                _db.SaveChanges();
                ViewBag.Confirmed = "*Cảm ơn bạn đã đăng ký tài khoản.";
            }
            return View();
        }

        public IActionResult ForgotPassword()
        {
            //var user = HttpContext.Session.GetString("username");
            //if (user != null)
            //{
            //return RedirectToAction("UserProfile");
            //}
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> ForgotPasswordAsync(string username)
        {
            var userId = username;
            var code = "qwert";
            code = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(code));
            userId = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(userId));
            var content = Url.Action("ChangePassword", "Account", new { userId = userId, code = code }, protocol: Request.Scheme);
            var check = _db.TblUsers.FirstOrDefault(p => p.Username == username);

            if (check != null)
            {
                await EmailSender.SendEmailAsync(username, "Quên mật khẩu", "<a href=\"" + content + "\" class=\"linkdetail\" style=\"text-decoration: none; margin: 0 auto; color: black;\">Thay đổi mật khẩu</a>");
                ViewBag.ConfirmForgotSuccess = "*Vui lòng kiểm tra ";
                return View();
            }
            else
            {
                ViewBag.ErrorConfirmForogot = "*Email chưa được đăng ký.";
                return View();
            }
        }



        public IActionResult ChangePassword(string userId, string code)
        {
            //var user = HttpContext.Session.GetString("username");
            //if (user != null)
            //{
            //return RedirectToAction("UserProfile");
            //}
            if (userId == null || code == null)
            {
                return RedirectToAction("Index", "Home");
            }
            userId = Encoding.UTF8.GetString(WebEncoders.Base64UrlDecode(userId));
            var check = _db.TblUsers.FirstOrDefault(p => p.Username == userId);
            if (check != null)
            {
                ViewBag.User = userId;
                return View();
            }
            return View();
        }

        [HttpPost]
        public IActionResult ChangePassword(TblUser user)
        {
            string username = user.Username;
            string newPassword = user.Password;

            var check = _db.TblUsers.FirstOrDefault(p => p.Username == username);
            if (check != null)
            {
                check.Password = newPassword;
                _db.SaveChanges();
                string changeSucces = "Thay đổi mật khẩu thành công";
            }
            return RedirectToAction("Login");
        }

        public IActionResult UserProfile()
        {
            var user = HttpContext.Session.GetString("username");
            ViewBag.ID = HttpContext.Session.GetString("id");
            var profile = _db.TblUsers.FirstOrDefault(p => p.Username.Equals(user));
            ViewBag.Fullname = HttpContext.Session.GetString("fullname");
            if (user == null)
            {
                return RedirectToAction("Login");
            }
            return View(profile);
        }


        public IActionResult UserLocation()
        {
            var user = HttpContext.Session.GetString("username");
            ViewBag.ID = HttpContext.Session.GetString("id");
            ViewBag.User = user;
            ViewBag.Fullname = HttpContext.Session.GetString("fullname");
            if (user == null)
            {
                return RedirectToAction("Login");
            }
            return View();
        }

        public IActionResult UserChangePassword()
        {
            var user = HttpContext.Session.GetString("username");
            ViewBag.ID = HttpContext.Session.GetString("id");
            ViewBag.Fullname = HttpContext.Session.GetString("fullname");
            ViewBag.User = user;
            if (user == null)
            {
                return RedirectToAction("Login");
            }
            return View();
        }

        [HttpPost]
        public IActionResult UserChangePassword(string username, string oldPassword, string password)
        {
            ViewBag.ID = HttpContext.Session.GetString("id");
            ViewBag.Fullname = HttpContext.Session.GetString("fullname");
            var check = _db.TblUsers.FirstOrDefault(p => p.Username == username && p.Password == oldPassword);
            if (check != null)
            {
                check.Password = password;
                _db.SaveChanges();
                ViewBag.ChangeSuccess = "*Thay đổi mật khẩu thành công.";
                return View();
            }
            ViewBag.ChangeFail = "*Mật khẩu hiện tại không chính xác, vui lòng thử lại.";
            return View();
        }

        public IActionResult UserHistoryOrder()
        {
            ViewBag.ID = HttpContext.Session.GetString("id");
            ViewBag.Fullname = HttpContext.Session.GetString("fullname");
            var user = HttpContext.Session.GetString("username");
            ViewBag.User = user;
            if (user == null)
            {
                return RedirectToAction("Login");
            }
            return View();
        }

    }
}
