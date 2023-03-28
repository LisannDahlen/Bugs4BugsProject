namespace Bugs4Bugs.Models
{
    public class Urgency
    {
        public Urgency()
        {
            
        }
        public Urgency(string selectedUrgencyLevel)
        {
            Level = selectedUrgencyLevel;
        }

        public int Id { get; set; }
        public string Level { get; set; }
        public string? Description { get; set; }

    }
}
