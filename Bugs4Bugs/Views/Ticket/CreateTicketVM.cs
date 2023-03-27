using Bugs4Bugs.Models;

namespace Bugs4Bugs.Views.Ticket
{
    public class CreateTicketVM
    {
        public Product product { get; set; }
        public BugType bugType { get; set; }
        public Urgency urgency { get; set; }
    }
}
