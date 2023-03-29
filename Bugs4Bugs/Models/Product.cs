using Microsoft.AspNetCore.Mvc.Rendering;

namespace Bugs4Bugs.Models
{
    public class Product
    {
        public Product(string name, string photoURL)
        {
            Name = name;
            PhotoURL = photoURL;
            urgencies = ProductUtilities.GetDefaultUrgencyLevels();
            statuses =  ProductUtilities.GetDefaultStatuses();
            bugTypes =  ProductUtilities.GetDefaultBugTypes();
        }

        public Product()
        {
            urgencies = ProductUtilities.GetDefaultUrgencyLevels();
            statuses = ProductUtilities.GetDefaultStatuses();
            bugTypes = ProductUtilities.GetDefaultBugTypes();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }

        public string PhotoURL { get; set; }    
        public List<SiteUserRole> ProductTeam { get; set; }

        public BugType[] bugTypes;
        public Status[] statuses;
        public Urgency[] urgencies;

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
