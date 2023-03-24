using Bugs4Bugs.Views.Ticket;
using Microsoft.AspNetCore.Mvc;

namespace Bugs4Bugs.Controllers
{
    public class TicketController : Controller
    {
        [HttpGet("/createTicket")]
        public IActionResult CreateTicket()
        {
            return View();
        }

        [HttpPost("/createTicket")]
        public IActionResult CreateTicket(CreateTicketVM createTicketVM)
        {
            return View();
        }


        [HttpGet("/TicketOverView")]
        public IActionResult TicketOverView()
        {
            return View(new TicketOverviewVM());
        }

        [HttpGet("/EditTicket")]
        public IActionResult EditTicket()
        {
            return View();
        }

        [HttpPost("/createTicket")]
        public IActionResult EditTicket(EditTicketVM createTicketVM)
        {
            return View();
        }

    }
}
