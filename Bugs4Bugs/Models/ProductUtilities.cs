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
                new BugType{Id = 1, Type = "Program crash"},
                new BugType{Id = 2,Type = "Visual glitch"},
                new BugType{Id = 3,Type = "Performance issue"},
                new BugType{Id = 4,Type = "Unexpected behaviour"},
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
