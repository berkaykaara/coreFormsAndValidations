using coreFormsAndValidations.Models;
using Microsoft.AspNetCore.Mvc;

namespace coreFormsAndValidations.Controllers
{
    public class AccountController : Controller
    {
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
        public IActionResult StronglyTypedLogin()
        {
            return View();
        }
        [HttpPost]
        public IActionResult LoginSuccess(LoginViewModel login)
        {
            ViewBag.Username = login.Username;
            ViewBag.Password = login.Password;
            return View();
        }
    }
}
