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



        
    }
}
