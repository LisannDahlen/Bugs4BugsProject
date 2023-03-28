namespace Bugs4Bugs.Models
{
    public class Status
    {
        public Status() 
        {
            TicketStatus = "Open";
            Description = "This ticket is open and currently waiting to be assigned to a developer.";
        }
        public int Id { get; set; }
        public string TicketStatus { get; set; }
        public string? Description { get; set; }
    }
}
