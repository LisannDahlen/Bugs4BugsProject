using Bugs4Bugs.Models;

namespace Bugs4Bugs.Views.Ticket
{
    public class CreateTicketVM
    {
        public string ProductName { get; set; }
        //public Product product { get; set; }
        public string[] BugTypes { get; set; }
        public string[] UrgencyLevels { get; set; }
    }
}
