using coreFormsAndValidations.Models;
using Microsoft.AspNetCore.Mvc;

namespace coreFormsAndValidations.Controllers
{
    public class AccountController : Controller
    {
        //Weakly Typed forms
        public IActionResult WeeklyTypedLogin()
        {
            return View();
        }
        [HttpPost]
        public IActionResult LoginPost(string Username, string Password)
        {
            ViewBag.Username = Username;
            ViewBag.Password = Password;
            return View();
        }
        //strongly Typed Forms
        public IActionResult StronglyTypedLogin()
        {
            return View();
        }
        [HttpPost]
        public IActionResult LoginSuccess(LoginViewModel login)
        {
            if (login.Username != null && login.Password != null)
            {
                if (login.Username.Equals("admin") && login.Password.Equals("admin"))
                {
                    ViewBag.Message = "You are successfully logged in";
                    return View();
                }
            }
            ViewBag.Messsage = "invalid credentials";
            return View();
        }
        //model binding
        public IActionResult UserDetail()
        {
            var user = new LoginViewModel()
            {
                Username = "berkay",
                Password = "123456"
            };
            return View(user);
        }
        //model binding with list
        public IActionResult UserList()
        {
            var users = new List<LoginViewModel>()
            {
                new LoginViewModel()
            {
                Username = "berkay",
                Password = "1111"
            },new LoginViewModel()
            {
                Username = "halil",
                Password = "22222"
            },new LoginViewModel()
            {
                Username = "izzet",
                Password = "33333"
            }
            };
            return View(users);
        }

        //Form validations
        public IActionResult GetAccount()
        {
            return View();
        }
        [HttpPost]
        public IActionResult PostAccount()
        {
            if (ModelState.IsValid)
            {
                return View("Success");
            }
            return RedirectToAction("GetAccount");
        }
    }
}
