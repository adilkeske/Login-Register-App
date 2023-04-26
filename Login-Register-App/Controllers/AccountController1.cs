using Microsoft.AspNetCore.Mvc;
using Login_Register_App.Controllers;
using Login_Register_App.Models;

namespace Login_Register_App.Controllers
{
    public class AccountController1 : Controller
    {
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        public IActionResult Verify(Account acc)
        {
            return View();
        }
    }
}
