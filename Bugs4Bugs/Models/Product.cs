namespace Bugs4Bugs.Models
{
    public class Product
    {
        public Product(string name)
        {
            Name = name;
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
        public string Description { get; set; }
        public List<SiteUserRole> ProductTeam { get; set; }

        public BugType[] bugTypes;
        public Status[] statuses;
        public Urgency[] urgencies;

        public string[] GetBugtypesArray()
        {
            return bugTypes.Select(b => b.Type).ToArray();
        }

        public string[] GetUrgencyArray()
        {
            return urgencies.Select(u => u.Level).ToArray();
        }

    }
}
