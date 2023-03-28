using Bugs4Bugs.Views.Ticket;
using Microsoft.AspNetCore.Authentication;

namespace Bugs4Bugs.Models.Services
{
    public class TicketDataservice
    {
        static List<Product> products = new List<Product>
            {
                new Product()
                {
                   Name = "Visual Studio"
                },
                 new Product()
                {
                   Name = "Visual Studio Code"
                },
                 new Product()
                {
                   Name = "Firefox"
                },
                 new Product()
                {
                   Name = "Chrome"
                },
                 new Product()
                {
                   Name = "Skynet"
                }
            };
        public AddTicket1VM[] GetAllProducts()
        {
            return products.Select(p => new AddTicket1VM { productName = p.Name })
                            .ToArray();
        }

        internal CreateTicketVM? GetProductByName(string prodName)
        {
            return products.Where(p => p.Name == prodName)
                .Select(p => new CreateTicketVM
                {
                    ProductName = prodName,
                    BugTypes = p.GetBugtypesArray(),
                    UrgencyLevels = p.GetUrgencyArray()
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
                Id = 1,
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

        public TicketVM[] GetAllTIckets()
        {
            TicketVM[] ticketVMs = tickets
                .Select(t =>
                new TicketVM {
                    Title = t.Title,
                    Description = t.Description,
                    Submiter = t.Submitter.UserName,
                    Status = t.TicketStatus.TicketStatus,
                    BugType = t.TicketBugType.Type,
                    Urgency = t.TicketUrgency.Level,
                    Submitted = t.SubmittedDate.ToString(),
                    LastUpdated = t.LastUpdated.ToString(),
                    Developer = t.Developer == null ? "" : t.Developer.FirstName + t.Developer.LastName,
                    Product = t.TicketProduct.Name
                })
                .ToArray(); 
            return ticketVMs;
        }

    }
}
