namespace Bugs4Bugs.Models
{
    public class Ticket
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime SubmittedDate { get; set; }
        public DateTime LastUpdated { get; set; }
        public string SubmitterId { get; set; }
        public SiteUser Submitter { get; set; }
        //public string? DeveloperId { get; set; }
        //public SiteUser? Developer { get; set; }
        public int TicketProductId { get; set; }
        public Product TicketProduct { get; set; }
        public int TicketBugTypeId { get; set; }
        public BugType TicketBugType { get; set; }
        public int TicketUrgencyId { get; set; }
        public Urgency TicketUrgency { get; set; }
        public int TicketStatusId { get; set; }
        public Status TicketStatus { get; set; }
    }
}
