namespace Bugs4Bugs.Models
{
    public class Ticket
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime SubmittedDate { get; set; }
        public DateTime LastUpdated { get; set; }
        public int SubmitterId { get; set; }
        public SiteUser Submitter { get; set; }
        public int DeveloperId { get; set; }
        public SiteUser Developer { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int BuggTypeId { get; set; }
        public BuggType BuggType { get; set; }
        public int UrgencyId { get; set; }
        public Urgency Urgency { get; set; }
        public int StatusId { get; set; }
        public TicketStatus Status { get; set; }
    }
}
