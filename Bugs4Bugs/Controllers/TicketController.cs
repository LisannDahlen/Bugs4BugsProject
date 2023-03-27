using Bugs4Bugs.Models;
using Bugs4Bugs.Models.Services;
using Bugs4Bugs.Views.Ticket;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Bugs4Bugs.Controllers
{
    public class TicketController : Controller
    {

        TicketDataservice ticketDataservice;
        public TicketController(TicketDataservice ticketDataservice)
        {
            this.ticketDataservice = ticketDataservice;
        }

        [HttpGet("/CreateTicket")]
        public IActionResult CreateTicket()
        {
            ViewBag.UrgencyLevels = Models.ProductUtilities.GetDefaultUrgencyLevels()
                .Select(x => new SelectListItem { Value = x.Level, Text = x.Level })
                .ToList();
            ViewBag.BuggTypes = Models.ProductUtilities.GetDefaultBugTypes()
                .Select(x => new SelectListItem { Value = x.Type, Text = x.Type })
                .ToList();

            return View();
        }

        [HttpPost("/CreateTicket")]
        public IActionResult CreateTicket(CreateTicketVM createTicketVM)
        {
            return View();
        }


        [HttpGet("/TicketOverview")]
        public IActionResult TicketOverview()
        {
            return View(new TicketOverviewVM());
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

        [HttpGet("/AddTicket1")]
        public IActionResult AddTicket1()
        {
            AddTicket1VM[] model = ticketDataservice.GetAllProducts();
            return View(model);
        }


    }
}
