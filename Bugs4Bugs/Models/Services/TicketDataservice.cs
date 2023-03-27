using Bugs4Bugs.Views.Ticket;

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
                     Name = "Skynet"
                 }
            };
        public AddTicket1VM[] GetAllProducts()
        {
            return products.Select(p => new AddTicket1VM {productName = p.Name} )
                            .ToArray();
        }

        List<Ticket> tickets = new List<Ticket>()
        {
            new Ticket()
            {
                Id = 1,
                Title = "Mördarrobotar",
                Description = "En smältande polis jagar mig och en Österrikisk bodybuilder säger att jag ska rädda framtiden",
                SubmittedDate = DateTime.Now,
                LastUpdated = DateTime.Now,
                Submitter = new SiteUser() {FirstName="John", LastName="Connor", UserName = "JohnConnor" },
                TicketProduct = products.FirstOrDefault(o => o.Name=="Skynet"),
                TicketBugType = TicketProduct.TicketBugType
                //TicketUrgency = 
                //TicketStatus =
    }
        };
    }
}
