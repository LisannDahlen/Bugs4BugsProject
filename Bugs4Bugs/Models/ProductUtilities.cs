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

        public static BugType[] GetDefaultBugTypes()
        {

            return new BugType[]
            {
                new BugType{Type = "Program crash"},
                new BugType{Type = "Visual glitch"},
                new BugType{Type = "Performance issue"},
                new BugType{Type = "Unexpected behaviour"},
            };
        }

        public static Status[] GetDefaultStatuses()
        {
            return new Status[] {
                new Status{TicketStatus = "Closed"},
                new Status{TicketStatus = "Resolved"},
                new Status{TicketStatus = "Opened"},
                new Status{TicketStatus = "Pending"},
                new Status{TicketStatus = "Assigned"},

            };
        }
    }
}
