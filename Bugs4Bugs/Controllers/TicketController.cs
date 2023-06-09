﻿using Bugs4Bugs.Models;
using Bugs4Bugs.Models.Services;
using Bugs4Bugs.Views.Ticket;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Bugs4Bugs.Controllers
{
    [Authorize]
    public class TicketController : Controller
    {
        const string CURRENT_PRODUCT_KEY = AppConstants.CURRENT_PRODUCT_KEY;
        TicketDataservice ticketDataservice;
        public TicketController(TicketDataservice ticketDataservice)
        {
            this.ticketDataservice = ticketDataservice;
          

        }

        [HttpGet("/CreateTicket")]
        [HttpGet("/CreateTicket/{prodName}")]
        public IActionResult CreateTicket(string prodName)
        {
           
            if (prodName == null)
            {
                return RedirectToAction(nameof(ChooseProduct));
            }
            CreateTicketVM createTicketVM = ticketDataservice.GetCreateTicketVM(prodName);
            //TempData[CURRENT_PRODUCT_KEY] = prodName;
            return View(createTicketVM);
        }

        [HttpPost("/CreateTicket/{prodName}")]
        public IActionResult CreateTicket(CreateTicketVM createTicketVM,string prodName)
        {


            //createTicketVM.ProductName = (string)TempData[CURRENT_PRODUCT_NAME];
            createTicketVM.ProductName = prodName;
           
            if (!ModelState.IsValid)
            {
                createTicketVM.ProductPhotoURL = ticketDataservice.GetPhotoUrlByProduct(prodName);
                createTicketVM.BugTypes = ticketDataservice.GetBugTypes(prodName);
                createTicketVM.UrgencyLevels = ticketDataservice.GetUrgencyLevels(prodName);
                
                return View(createTicketVM);
            }
            ticketDataservice.SaveTicket(createTicketVM);
            
            return RedirectToAction("TicketOverview", new {prodName = prodName});
        }

        [HttpGet("/EditTicket/")]
        [HttpGet("/EditTicket/{Id}")]
        public IActionResult EditTicket(int Id)
        {
            if (Id == null)
            {
                return RedirectToAction(nameof(MyProfile));
            }
            EditTicketVM editTicketVM = ticketDataservice.GetEditTicketVM(Id);
            TempData["Ticket"] = Id;
            return View(editTicketVM);
        }

        [HttpPost("/EditTicket")]
        [HttpPost("/EditTicket/{Id}")]
        public IActionResult EditTicket(EditTicketVM editTicketVM, int Id)
        {
            //createTicketVM.ProductName = (string)TempData[CURRENT_PRODUCT_NAME];
            editTicketVM.Id = Id;
            
            //if (!ModelState.IsValid)
            //{
            //    editTicketVM.BugTypes = ticketDataservice.GetBugTypes(editTicketVM.ProductName);
            //    editTicketVM.UrgencyLevels = ticketDataservice.GetUrgencyLevels(editTicketVM.ProductName);
            //    editTicketVM.Statuses = ticketDataservice.GetStatuses (editTicketVM.ProductName);

            //    return View(createTicketVM);
            //}
            ticketDataservice.SaveTicket(editTicketVM);

            return RedirectToAction("MyProfile");
        }

        [AllowAnonymous]
        [HttpGet("/TicketOverview")]
        public IActionResult TicketOverview()
        {
            return View(ticketDataservice.GetAllTickets());
        }
        [AllowAnonymous]
        [HttpGet("/TicketOverview/{prodName}")]
        public IActionResult TicketOverview(string prodName)
        {
            TempData["productView"] = prodName;
            return View(ticketDataservice.GetAllTickets(prodName));
        }
        //p => p.TicketProduct.Name == prodName
        //Func<Ticket, bool> filter

        [HttpGet("/YourTickets")]
        public IActionResult YourTickets()
        {
            return View(ticketDataservice.GetAllTickets(null, true));
        }

        

        //[HttpGet("/CreateTicket")]
        //[HttpGet("/CreateTicket/{prodName}")]
        //public IActionResult CreateTicket(string prodName)
        //{

        //    if (prodName == null)
        //    {
        //        return RedirectToAction(nameof(ChooseProduct));
        //    }
        //    CreateTicketVM createTicketVM = ticketDataservice.GetCreateTicketVM(prodName);
        //    TempData[CURRENT_PRODUCT_KEY] = prodName;
        //    return View(createTicketVM);
        //}

        //[HttpPost("/CreateTicket/{prodName}")]
        //public IActionResult CreateTicket(CreateTicketVM createTicketVM, string prodName)
        //{


        //    //createTicketVM.ProductName = (string)TempData[CURRENT_PRODUCT_NAME];
        //    createTicketVM.ProductName = prodName;

        //    if (!ModelState.IsValid)
        //    {
        //        createTicketVM.BugTypes = ticketDataservice.GetBugTypes(prodName);
        //        createTicketVM.UrgencyLevels = ticketDataservice.GetUrgencyLevels(prodName);

        //        return View(createTicketVM);
        //    }
        //    ticketDataservice.SaveTicket(createTicketVM);

        //    return RedirectToAction("TicketOverview", new { prodName = prodName });

            [AllowAnonymous]
        [HttpGet("/ChooseProduct")]
        public IActionResult ChooseProduct()
        {
            ChooseProductVM[] model = ticketDataservice.GetAllProducts();
            return View(model);
        }

        [HttpGet ("/MyProfile")]
        public IActionResult MyProfile()
        {
            TicketVM[] ticketModel = ticketDataservice.GetAllTickets(null, true);
            ChooseProductVM[] productModel = ticketDataservice.GetAllProducts(true);

            MyProfileVM myProfileVM = new MyProfileVM()
            {
                ProductVMs = productModel,
                TicketVMs = ticketModel
            };
            return View(myProfileVM);
        }

    }
}
