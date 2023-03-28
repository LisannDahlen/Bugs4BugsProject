using Bugs4Bugs.Models;

namespace Bugs4Bugs.Views.Ticket
{
    public class CreateTicketVM
    {
        public string ProductName { get; set; }
        //public Product product { get; set; }
        public string[]? BugTypes { get; set; }
        public string SelectedBugType { get; set; }
        public string[]? UrgencyLevels { get; set; }
        public string SelectedUrgencyLevel { get; set; }

        public string Description { get; set; }
    }
}
