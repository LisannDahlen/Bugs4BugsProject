namespace Bugs4Bugs.Models
{
    public static class ProductUtilities
    {
        public static Urgency[] GetDefaultUrgencyLevels()
        {
            return new Urgency[] {
            
                new Urgency{Level = "Low"},
                new Urgency{Level = "Medium"},
                new Urgency{Level = "High"},
                new Urgency{Level = "Critical"},
            };
        }

        public static BugType[] GetDefaultBuggTypes()
        {

            return new BugType[]
            {
                new BugType{Type = "Program crash"},
                new BugType{Type = "Visual glitch"},
                new BugType{Type = "Performance issue"},
                new BugType{Type = "Unexpected behaviour"},
            };
        }

        public static TicketStatus[] GetDefaultStatuses()
        {
            return new TicketStatus[] {
                new TicketStatus{Status = "Closed"},
                new TicketStatus{Status = "Resolved"},
                new TicketStatus{Status = "Opened"},
                new TicketStatus{Status = "Pending"},
                new TicketStatus{Status = "Assigned"},

            };
        }
    }
}
