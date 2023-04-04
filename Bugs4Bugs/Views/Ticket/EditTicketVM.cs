using Bugs4Bugs.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace Bugs4Bugs.Views.Ticket
{
    public class EditTicketVM
    {
        public int? Id { get; set; }
        public string? ProductName { get; set; }

        [Required(ErrorMessage = "Ticket topic is required")]

        public string Topic { get; set; }

        //public Product product { get; set; }

        public SelectListItem[]? Technicians { get; set; }
        public string? SelectedTechnician { get; set; }
        //public string? SelectedTechnicianName { get; set; }

        public SelectListItem[]? Statuses { get; set; }
        [Required(ErrorMessage = "Select a status")]
        public string? SelectedStatus { get; set; }
        //public string? SelectedStatusName { get; set; }

        public SelectListItem[]? BugTypes { get; set; }
        [Required(ErrorMessage = "Select a bug type")]
        public string SelectedBugType { get; set; }
        //public string SelectedBugTypeName { get; set; }

        public SelectListItem[]? UrgencyLevels { get; set; }
        [Required(ErrorMessage = "Select urgency level")]
        public string SelectedUrgencyLevel { get; set; }
        //public string SelectedUrgencyLevelName { get; set; }


        [Required(ErrorMessage = "Please write a description")]
        public string Description { get; set; }
    }
}