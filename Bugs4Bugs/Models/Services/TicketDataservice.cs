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
                    ProductPhotoURL = p.PhotoURL,
                    ProductName = p.Name,
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

        internal void SaveTicket(EditTicketVM editTicketVM)
        {
            Ticket newTicket = applicationContext.Tickets.First(t => t.Id == editTicketVM.Id);
            newTicket.LastUpdated = DateTime.Now;
            newTicket.TechnicianId = editTicketVM.SelectedTechnician;
            newTicket.TicketStatusId = Convert.ToInt32(editTicketVM.SelectedStatus);
            newTicket.TicketBugTypeId = Convert.ToInt32(editTicketVM.SelectedBugType);
            newTicket.TicketUrgencyId = Convert.ToInt32(editTicketVM.SelectedUrgencyLevel);

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

        internal EditTicketVM? GetEditTicketVM(int id)
        {
            //Product p = applicationContext.Products.FirstOrDefault(applicationContext.Tickets.Id ==)
            return applicationContext.Tickets.Where(t => t.Id == id)
                .Select(t => new EditTicketVM
                {
                    Id = t.Id,
                    ProductName = t.TicketProduct.Name,
                    ProductPhotoURL = t.TicketProduct.PhotoURL,
                    Topic = t.Title,
                    SelectedTechnician = t.Technician.Id,
                    SelectedStatus = t.TicketStatus.Id.ToString(),
                    SelectedBugType = t.TicketBugType.Id.ToString(),
                    SelectedUrgencyLevel = t.TicketUrgency.Id.ToString(),
                    Description = t.Description,
                    Technicians = t.TicketProduct.GetTechniciansArray(),
                    Statuses = t.TicketProduct.GetStatusesArray(),
                    BugTypes = t.TicketProduct.GetBugtypesArray(),
                    UrgencyLevels = t.TicketProduct.GetUrgencyArray()
                    //.Select(s => new SelectListItem { Text = s.Text, Value = s.Value, Selected = (s.Text == t.TicketStatus.TicketStatus) }).ToArray()

                })
                .FirstOrDefault();
        }
    }
}
