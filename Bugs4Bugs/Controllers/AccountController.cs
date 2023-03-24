using Bugs4Bugs.Models.Services;
using Bugs4Bugs.Views.Account;
using Microsoft.AspNetCore.Mvc;

namespace Bugs4Bugs.Controllers
{
    public class AccountController : Controller
    {
        AccountDataservice dataservice;
        public AccountController(AccountDataservice dataservice) 
        {
            this.dataservice = dataservice;
        }
        [HttpGet("/login")]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost("/login")]
        public IActionResult Login(LoginVM loginVM)
        {
            return View();
        }

        [HttpGet("/register")]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost("/register")]
        public IActionResult Register(RegisterVM registerVM)
        {
            return View();
        }


    }
}
