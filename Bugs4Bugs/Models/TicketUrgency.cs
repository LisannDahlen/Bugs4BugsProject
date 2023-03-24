namespace Bugs4Bugs.Models
{
    public class TicketUrgency
    {
        public int Id { get; set; }
        public UrgencyEnum Urgency { get; set; }
    }

   public enum UrgencyEnum
    {
        Critical,
        High, 
        medium,
        Low,
    }
}
