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
    }
}
