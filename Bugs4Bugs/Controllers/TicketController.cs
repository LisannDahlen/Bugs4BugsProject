using Bugs4Bugs.Models;
using Bugs4Bugs.Models.Services;
using Bugs4Bugs.Views.Ticket;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Bugs4Bugs.Controllers
{
    public class TicketController : Controller
    {
        const string CURRENT_PRODUCT_NAME = "currentProduct";
        TicketDataservice ticketDataservice;
        public TicketController(TicketDataservice ticketDataservice)
        {
            this.ticketDataservice = ticketDataservice;
        }

        [HttpGet("/CreateTicket/{prodName}")]
        public IActionResult CreateTicket(string prodName)
        {
            
            CreateTicketVM createTicketVM = ticketDataservice.GetCreateTicketVM(prodName);
            TempData[CURRENT_PRODUCT_NAME] = prodName;
            return View(createTicketVM);
        }

        [HttpPost("/SaveTicket")]
        public IActionResult SaveTicket(CreateTicketVM createTicketVM)
        {
            createTicketVM.ProductName = (string)TempData[CURRENT_PRODUCT_NAME];
            ticketDataservice.SaveTicket(createTicketVM);
            //dataservice.saveTicket()
            return RedirectToAction(nameof(TicketOverview));
        }


        [HttpGet("/TicketOverview")]
        public IActionResult TicketOverview()
        {
            return View(ticketDataservice.GetAllTIckets());
        }

        [HttpGet("/EditTicket")]
        public IActionResult EditTicket()
        {
            return View();
        }

        [HttpPost("/EditTicket")]
        public IActionResult EditTicket(EditTicketVM editTicketVM)
        {
            return View();
        }

        [HttpGet("/ChooseProduct")]
        public IActionResult ChooseProduct()
        {
            ChooseProductVM[] model = ticketDataservice.GetAllProducts();
            return View(model);
        }


    }
}
