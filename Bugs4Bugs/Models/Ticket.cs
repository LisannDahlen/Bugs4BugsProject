namespace Bugs4Bugs.Models
{
    public class Ticket
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ProductName { get; set; }
        public int TcketUrgencyId { get; set; }
        public TicketUrgency Urgency { get; set; }

    }
}
