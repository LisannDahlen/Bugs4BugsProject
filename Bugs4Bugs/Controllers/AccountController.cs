using Bugs4Bugs.Models.Services;
using Bugs4Bugs.Views.Account;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Bugs4Bugs.Models;
using Microsoft.AspNetCore.Identity;

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
        [HttpPost("/login/{prodName}")]
        public async Task<IActionResult> LoginAsync(LoginVM loginVM, string? prodName) //kräver tydligen nullable string här för att inte inkludera prodnName i ModelState validation
        {
            
            if (!ModelState.IsValid)
            {
                var errors = ModelState.Values.SelectMany(v => v.Errors).Select(e => e.ErrorMessage).ToList();
                return Json(new { status = "error", errors });
            }

            // Check if credentials are valid (and set auth cookie)
            var errorMessage = await dataservice.TryLoginAsync(loginVM);
            if (errorMessage != null)
            {
                // Show error
                return Json(new { status = "error", errors = new List<string> { errorMessage } });
            }

            // Redirect user
            
            if (prodName != null)
            {
                return Json(new { status = "success", redirectUrl = Url.Action("CreateTicket", "Ticket", new { prodName = prodName }) });
                //return Json(new { status = "success", redirectUrl = "/CreateTicket/" + prodName});
            }

            return Json(new { status = "success", redirectUrl = Url.Action(nameof(TicketController.MyProfile), "Ticket") });
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
            {
                var errors = ModelState.Values.SelectMany(v => v.Errors).Select(e => e.ErrorMessage).ToList();
                return Json(new { status = "error", errors = errors });
            }

            // Try to register user
            var errorMessage = await dataservice.TryRegisterAsync(registerVM);
            if (errorMessage != null)
            {
                // Show error
                return Json(new { status = "error", errors = new List<string> { errorMessage } });
            }

            // Redirect user
            return Json(new { status = "success" });
        }

        [HttpGet("/logout")]
        public async Task<IActionResult> LogOutAsync()
        {
            TempData[AppConstants.CURRENT_PRODUCT_KEY] = null;
            await dataservice.LogOut();
            return RedirectToAction("Index","Home");
        }


        
        [HttpGet("/Secret")]
        [HttpGet("/Secret/{role}")]
        public async Task<IActionResult> SecretAsync(string role)
        {
            if (role != null)
            {
                await dataservice.SetRole(role);
                return RedirectToAction("SecretAsync");
            }
            else return View();
        }

    }
}
