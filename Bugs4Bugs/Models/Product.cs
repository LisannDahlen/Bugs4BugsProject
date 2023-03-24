namespace Bugs4Bugs.Models
{
    public class Product
    {
        public Product(string name)
        {
            Name = name;
            urgencies = ProductUtilities.GetDefaultUrgencyLevels();
            ticketstatuses =  ProductUtilities.GetDefaultStatuses();
            bugtypes =  ProductUtilities.GetDefaultBuggTypes();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<SiteUserRole> ProductTeam { get; set; }

        BuggType[] bugtypes;
        TicketStatus[] ticketstatuses;
        Urgency[] urgencies;

    }
}
