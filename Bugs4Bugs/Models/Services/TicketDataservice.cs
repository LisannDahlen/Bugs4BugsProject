using Bugs4Bugs.Views.Ticket;

namespace Bugs4Bugs.Models.Services
{
    public class TicketDataservice
    {
        List<Product> products = new List<Product>()
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
                }
            };
        public AddTicket1VM[] GetAllProducts()
        {
            return products.Select(p => new AddTicket1VM {productName = p.Name} )
                            .ToArray();
        }

        internal CreateTicketVM GetProductByName(string prodName)
        {
            return products.Where(p => p.Name == prodName)
                .Select(p => new CreateTicketVM { ProductName = prodName})
                .FirstOrDefault();
        }
    }
}
