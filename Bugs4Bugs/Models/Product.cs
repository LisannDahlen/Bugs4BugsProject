using Microsoft.AspNetCore.Mvc.Rendering;

namespace Bugs4Bugs.Models
{
    public class Product
    {
        public Product(string name, string photoURL)
        {
            Name = name;
            PhotoURL = photoURL;
            ProductTeam = new List<SiteUserRole>();
            urgencies = ProductUtilities.GetDefaultUrgencyLevels();
            statuses =  ProductUtilities.GetDefaultStatuses();
            bugTypes =  ProductUtilities.GetDefaultBugTypes();
        }

        public Product()
        {
            ProductTeam = new List<SiteUserRole>();
            urgencies = ProductUtilities.GetDefaultUrgencyLevels();
            statuses = ProductUtilities.GetDefaultStatuses();
            bugTypes = ProductUtilities.GetDefaultBugTypes();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }

        public string PhotoURL { get; set; }

        public string? OwnerId { get; set; }
        public SiteUser? Owner { get; set; }

        public List<SiteUserRole> ProductTeam { get; set; }

        public BugType[] bugTypes;
        public Status[] statuses;
        public Urgency[] urgencies;

        public SelectListItem[] GetTechniciansArray()
        {
            return ProductTeam.Select(t => new SelectListItem { Value = t.Id.ToString(), Text = t.SiteUser.UserName }).ToArray();
        }
        public SelectListItem[] GetStatusesArray()
        {
            return statuses.Select(s => new SelectListItem { Value = s.Id.ToString(), Text = s.TicketStatus}).ToArray();
        }
        public SelectListItem[] GetBugtypesArray()
        {
            return bugTypes.Select(b => new SelectListItem {Value = b.Id.ToString(),Text = b.Type}).ToArray();
        }

        public SelectListItem[] GetUrgencyArray()
        {
            return urgencies.Select(u => new SelectListItem { Value = u.Id.ToString(), Text = u.Level }).ToArray();
        }

    }
}
