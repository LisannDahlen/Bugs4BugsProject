using Bugs4Bugs.Views.Ticket;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;

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

        static Product[] products = ProductUtilities.GetDefaultProducts(); //Flyttade products listan till ProductUtilities-klassen
        public ChooseProductVM[] GetAllProducts()
        {
            return products
                .OrderBy(p => p.Name)
                .Select(p => new ChooseProductVM { ProductName = p.Name,
                PhotoURL = p.PhotoURL
            }).ToArray();
        }

        internal CreateTicketVM? GetCreateTicketVM(string prodName)
        {
            return products.Where(p => p.Name == prodName)
                .Select(p => new CreateTicketVM
                {
                    ProductName = prodName,
                    BugTypes = p.GetBugtypesArray(),
                    UrgencyLevels = p.GetUrgencyArray(),
                })
                .FirstOrDefault();
        }
        public static List<Ticket> tickets = new List<Ticket> {
            new Ticket
            {
                Id = 1,
                Title = "Mördarrobotar",
                Description = "En smältande polis jagar mig och en Österrikisk bodybuilder säger att jag ska rädda framtiden",
                SubmittedDate = DateTime.Now,
                LastUpdated = DateTime.Now,
                Submitter = new SiteUser{ FirstName = "John", LastName = "Connor", UserName = "JohnConnor" },
                TicketProduct = products.FirstOrDefault(o => o.Name == "Skynet"),
                TicketBugType = products.FirstOrDefault(o => o.Name == "Skynet").bugTypes[0],
                TicketUrgency = products.FirstOrDefault(o => o.Name == "Skynet").urgencies[0],
                TicketStatus = products.FirstOrDefault(o => o.Name == "Skynet").statuses[0]
            },
            new Ticket
            {
                Id = 2,
                Title = "Programmet åt min läxa",
                Description = "Jag gjorde min matteläxa när programmet plötsligt ",
                SubmittedDate = DateTime.Now,
                LastUpdated = DateTime.Now,
                Submitter = new SiteUser{ FirstName = "Tommy", LastName = "Boy", UserName = "TommyBoy97" },
                TicketProduct = products.FirstOrDefault(o => o.Name == "Firefox"),
                TicketBugType = products.FirstOrDefault(o => o.Name == "Firefox").bugTypes[0],
                TicketUrgency = products.FirstOrDefault(o => o.Name == "Firefox").urgencies[0],
                TicketStatus = products.FirstOrDefault(o => o.Name == "Firefox").statuses[0]
            },
        };

        public TicketVM[] GetAllTickets()
        {
            TicketVM[] ticketVMs = tickets
                .Select(t =>
                new TicketVM
                {
                    Title = t.Title,
                    Description = t.Description,
                    Submiter = t.Submitter.UserName,
                    Status = t.TicketStatus.TicketStatus,
                    BugType = t.TicketBugType.Type,
                    Urgency = t.TicketUrgency.Level,
                    Submitted = t.SubmittedDate.ToString("dd/MM/yyyy"),
                    LastUpdated = t.LastUpdated.ToString("dd/MM/yyyy"),
                    //Developer = t.Developer == null ? "Unassigned" : t.Developer.FirstName + t.Developer.LastName,
                    Product = t.TicketProduct.Name,
                    ProductPhotoURL = t.TicketProduct.PhotoURL
                })
                .ToArray();
            return ticketVMs;
        }

        public TicketVM[] GetAllTickets(string prodName)
        {
            var ticketVMs = tickets
                .Where(t => t.TicketProduct.Name == prodName)
                .Select(t =>
                new TicketVM
                {
                    Title = t.Title,
                    Description = t.Description,
                    Submiter = t.Submitter.UserName,
                    Status = t.TicketStatus.TicketStatus,
                    BugType = t.TicketBugType.Type,
                    Urgency = t.TicketUrgency.Level,
                    Submitted = t.SubmittedDate.ToString("dd/MM/yyyy"),
                    LastUpdated = t.LastUpdated.ToString("dd/MM/yyyy"),
                    //Developer = t.Developer == null ? "Unassigned" : t.Developer.FirstName + t.Developer.LastName,
                    Product = t.TicketProduct.Name,
                    ProductPhotoURL = t.TicketProduct.PhotoURL
                })
                 .ToArray();
            return ticketVMs;
        }


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
            newTicket.Title = createTicketVM.Title;
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
    }
}
