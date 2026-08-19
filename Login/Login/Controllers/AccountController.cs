using Login.Models;
using Microsoft.AspNetCore.Mvc;

namespace Login.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(LoginModel model)
        {
            if (ModelState.IsValid) {
                if (model.UserName == "Admin" & model.Password == "1234")
                {
                    return RedirectToAction("Dashboard");
                }
                else
                {
                    ViewBag.Error = "Invalid USerName and Passwords";
                }

                 }
            return View(model);
        }
        public IActionResult Dashboard()
        {
            return View();
        }
    }
}
