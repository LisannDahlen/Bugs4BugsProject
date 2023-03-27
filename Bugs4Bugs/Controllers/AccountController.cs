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
        public async Task<IActionResult> LoginAsync(LoginVM loginVM)
        {
            if (!ModelState.IsValid)
                return View();

            // Check if credentials is valid (and set auth cookie)
            var errorMessage = await dataservice.TryLoginAsync(loginVM);
            if (errorMessage != null)
            {
                // Show error
                ModelState.AddModelError(string.Empty, errorMessage);
                return View();
            }

            // Redirect user
            return RedirectToAction(nameof(TicketController.CreateTicket), "Ticket");
        }

        [HttpGet("/register")]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost("/register")]
        public async Task<IActionResult> RegisterAsync(RegisterVM registerVM)
        {
            if (!ModelState.IsValid)
                return View();

            // Try to register user
            var errorMessage = await dataservice.TryRegisterAsync(registerVM);
            if (errorMessage != null)
            {
                // Show error
                ModelState.AddModelError(string.Empty, errorMessage);
                return View();
            }

            // Redirect user
            return RedirectToAction(nameof(Login));
        }


    }
}
