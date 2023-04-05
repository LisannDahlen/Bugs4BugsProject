using Bugs4Bugs.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace Bugs4Bugs.Views.Ticket
{
    public class CreateTicketVM
    {
        public string? ProductName { get; set; }
        public string? ProductPhotoURL { get; set; }

        [Required (ErrorMessage ="Ticket topic is required")]
        
        public string Topic { get; set; }

        //public Product product { get; set; }
        
        public SelectListItem[]? BugTypes { get; set; }


        [Required(ErrorMessage = "Select a bug type")]
        public string SelectedBugType { get; set; }
        public SelectListItem[]? UrgencyLevels { get; set; }


        [Required(ErrorMessage = "Select urgency level")]
        public string SelectedUrgencyLevel { get; set; }


        [Required(ErrorMessage = "Please write a description")]
        public string Description { get; set; }
    }
}
