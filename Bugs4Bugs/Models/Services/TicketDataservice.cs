using Bugs4Bugs.Views.Ticket;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Bugs4Bugs.Models.Services
{
    public class TicketDataservice
    {
        ApplicationContext? applicationContext;
        IHttpContextAccessor accessor;
        UserManager<SiteUser> userManager;

        public TicketDataservice(ApplicationContext applicationContext, IHttpContextAccessor accessor, UserManager<SiteUser> userManager)
        {
            this.applicationContext = applicationContext ?? throw new ArgumentNullException(nameof(applicationContext));
            this.accessor = accessor;
            this.userManager = userManager;
        }

        public string GetCurrentUserId()
        {
            return userManager.GetUserId(accessor.HttpContext.User);
        }

        static Product[] products = ProductUtilities.GetDefaultProducts(); //Flyttade products listan till ProductUtilities-klassen
        public ChooseProductVM[] GetAllProducts(bool filterByLogedInUser = false)
        {
            var UserId = GetCurrentUserId();
            return applicationContext.Products
                .Where(t => (!filterByLogedInUser || t.OwnerId == UserId))
                .OrderBy(p => p.Name)
                .Select(p => new ChooseProductVM
                {
                    ProductName = p.Name,
                    PhotoURL = p.PhotoURL
                }).ToArray();
        }

        internal CreateTicketVM? GetCreateTicketVM(string prodName)
        {
            return applicationContext.Products.Where(p => p.Name == prodName)
                .Select(p => new CreateTicketVM
                {
                    ProductName = prodName,
                    BugTypes = p.GetBugtypesArray(),
                    UrgencyLevels = p.GetUrgencyArray(),
                })
                .FirstOrDefault();
        }


        //public TicketVM[] GetAllTickets()
        //{
        //    return applicationContext.Tickets
        //        .Select(t => TicketToticketVMConvert(t))
        //        .ToArray();
        //}

        //public TicketVM[] GetAllTickets(string prodName)
        //{
        //    return GetAllTickets(t => t.TicketProduct.Name == prodName);
        //}

        internal TicketVM[] GetYourTickets()
        {
            return GetAllTickets();
        }
        //t => t.SubmitterId == GetCurrentUserId()
        //internal TicketVM[] GetTicketsByUser(string submitterID)
        //{
        //    return GetAllTickets();
        //}
        //t => t.SubmitterId == submitterID

        public TicketVM[] GetAllTickets(string prodName = null, bool filterByLogedInUser = false)
        {
            var UserId = GetCurrentUserId();
            return applicationContext.Tickets
                .Where(t => (prodName == null || t.TicketProduct.Name == prodName) && (!filterByLogedInUser || t.SubmitterId == UserId))
                .Select(t =>
                           new TicketVM
                           {
                               Id = t.Id,
                               Title = t.Title,
                               Description = t.Description,
                               Submitter = t.Submitter.UserName,
                               Status = t.TicketStatus.TicketStatus,
                               BugType = t.TicketBugType.Type,
                               Urgency = t.TicketUrgency.Level,
                               UrgencyColor = t.TicketUrgency.ColorHexString,
                               StatusColor = t.TicketStatus.ColorHexString,
                               Submitted = t.SubmittedDate.ToString("dd/MM/yyyy"),
                               LastUpdated = t.LastUpdated.ToString("dd/MM/yyyy"),
                               //Developer = t.Developer == null ? "Unassigned" : t.Developer.FirstName + t.Developer.LastName,
                               Product = t.TicketProduct.Name,
                               ProductPhotoURL = t.TicketProduct.PhotoURL
                           })
                //.AsEnumerable()
                //.Where(t => filter(t))
                .ToArray();
        }


        //static private TicketVM TicketToticketVMConvert(Ticket t)
        //{

        //    return new TicketVM
        //    {
        //        Title = t.Title,
        //        Description = t.Description,
        //        Submitter = t.Submitter.UserName,
        //        Status = t.TicketStatus.TicketStatus,
        //        BugType = t.TicketBugType.Type,
        //        Urgency = t.TicketUrgency.Level,
        //        Submitted = t.SubmittedDate.ToString("dd/MM/yyyy"),
        //        LastUpdated = t.LastUpdated.ToString("dd/MM/yyyy"),
        //        //Developer = t.Developer == null ? "Unassigned" : t.Developer.FirstName + t.Developer.LastName,
        //        Product = t.TicketProduct.Name,
        //        ProductPhotoURL = t.TicketProduct.PhotoURL
        //    };

        //}

        public Product? GetProductByName(string prodName)
        {
            return products.SingleOrDefault(p => p.Name == prodName);
        }
        internal void SaveTicket(CreateTicketVM createTicketVM)
        {
            Ticket newTicket = new Ticket();
            newTicket.Description = createTicketVM.Description;
            newTicket.SubmittedDate = DateTime.Now;
            newTicket.LastUpdated = DateTime.Now;
            newTicket.Title = createTicketVM.Topic;
            newTicket.TicketProductId = GetProductIDByName(createTicketVM.ProductName);
            newTicket.TicketStatusId = 3; // 3 = "open"
            newTicket.TicketBugTypeId = Convert.ToInt32(createTicketVM.SelectedBugType);
            newTicket.TicketUrgencyId = Convert.ToInt32(createTicketVM.SelectedUrgencyLevel);
            newTicket.SubmitterId = userManager.GetUserId(accessor.HttpContext.User);

            applicationContext.Tickets.Add(newTicket);
            applicationContext.SaveChanges();
        }

        private int GetProductIDByName(string productName)
        {
            return applicationContext.Products.Where(p => p.Name == productName).Select(p => p.Id).SingleOrDefault();
        }

        public SelectListItem[] GetBugTypes(string prodName)
        {
            return applicationContext.Products.Where(p => p.Name == prodName)
               .Select(p => p.GetBugtypesArray())
               .FirstOrDefault();
        }

        public SelectListItem[] GetUrgencyLevels(string prodName)
        {
            return applicationContext.Products.Where(p => p.Name == prodName)
               .Select(p => p.GetUrgencyArray())
               .FirstOrDefault();
        }

        internal EditTicketVM GetEditTicketVM(int id)
        {
            return null;
            //            return applicationContext.Tickets.Where(p => p.Id == id)
            //                .Select(p => new EditTicketVM
            //                {
            //                    public string? ProductName { get; set; }

            //        [Required(ErrorMessage = "Ticket topic is required")]

            //        public string Topic { get; set; }

            //        //public Product product { get; set; }

            //        public SelectListItem[]? Technicians { get; set; }
            //        public string SelectedTechnician { get; set; }

            //        public SelectListItem[]? Statuses { get; set; }
            //        [Required(ErrorMessage = "Select a status")]
            //        public string SelectedStatus { get; set; }
            //        public SelectListItem[]? BugTypes { get; set; }
            //        [Required(ErrorMessage = "Select a bug type")]
            //        public string SelectedBugType { get; set; }

            //        public SelectListItem[]? UrgencyLevels { get; set; }
            //        [Required(ErrorMessage = "Select urgency level")]
            //        public string SelectedUrgencyLevel { get; set; }


            //        [Required(ErrorMessage = "Please write a description")]
            //        public string Description { get; set; }
            //    })
            //                .FirstOrDefault();
        }
    }
}
