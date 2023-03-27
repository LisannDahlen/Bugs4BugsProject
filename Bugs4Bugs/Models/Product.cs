namespace Bugs4Bugs.Models
{
    public class Product
    {
        public Product(string name)
        {
            Name = name;
            urgencies = ProductUtilities.GetDefaultUrgencyLevels();
            ticketstatuses =  ProductUtilities.GetDefaultStatuses();
            bugtypes =  ProductUtilities.GetDefaultBugTypes();
        }

        public Product()
        {
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<SiteUserRole> ProductTeam { get; set; }

        BugType[] bugtypes;
        TicketStatus[] ticketstatuses;
        Urgency[] urgencies;

        public string[] GetBugtypesArray()
        {
            return bugtypes.Select(b => b.Type).ToArray();
        }

        public string[] GetUrgencyArray()
        {
            return urgencies.Select(u => u.Level).ToArray();
        }

    }
}
