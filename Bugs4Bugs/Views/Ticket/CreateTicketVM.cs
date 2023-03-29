using Bugs4Bugs.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Bugs4Bugs.Views.Ticket
{
    public class CreateTicketVM
    {
        public string ProductName { get; set; }
        public string Title { get; set; }

        //public Product product { get; set; }
        public SelectListItem[]? BugTypes { get; set; }
        public string SelectedBugType { get; set; }
        public SelectListItem[]? UrgencyLevels { get; set; }
        public string SelectedUrgencyLevel { get; set; }

        public string Description { get; set; }
    }
}
