using Bugs4Bugs.Views.Ticket;
using Microsoft.AspNetCore.Identity;

namespace Bugs4Bugs.Models
{
    public static class ProductUtilities
    {
        public static Product[] GetDefaultProducts()
        {
            return new Product[]
            {
                new Product()
                {Id = 1,
                    Name = "Visual Studio",
                    PhotoURL = "Images/VisualStudio.jpg"
                },
                 new Product()
                {
                  Id = 2,
                  Name = "Visual Studio Code",
                  PhotoURL = "Images/VSCode.jpg"
                },
                 new Product()
                {
                   Id = 3,
                   Name = "Firefox",
                   PhotoURL = "Images/Firefox.jpg"
                },
                 new Product()
                {
                   Id = 4,
                   Name = "Chrome",
                   PhotoURL = "Images/chrome.jpg"
                },
                 new Product()
                {
                   Id = 5,
                   Name = "Skynet",
                   PhotoURL = "Images/Skynet.png"
                },
                 new Product()
                {
                   Id = 6,
                   Name = "Spotify",
                   PhotoURL = "Images/Spotify.png"
                }, 
                new Product()
                {
                   Id = 7,
                   Name = "Netflix",
                   PhotoURL = "Images/Netflix.png"
                },
                new Product()
                {
                   Id = 8,
                   Name = "BookBeat",
                   PhotoURL = "Images/BookBeat.png"
                },
                new Product()
                {
                   Id = 9,
                   Name = "Blocket",
                   PhotoURL = "Images/Blocket.png"
                },
                new Product()
                {
                   Id = 10,
                   Name = "Ebay",
                   PhotoURL = "Images/Ebay.png"
                },  
                new Product()
                {
                   Id = 11,
                   Name = "Microsoft Teams",
                   PhotoURL = "Images/Teams.jpg"
                },  
                new Product()
                {
                   Id = 12,
                   Name = "Youtube",
                   PhotoURL = "Images/Youtube.png"
                },
            };

        }
        public static Urgency[] GetDefaultUrgencyLevels()
        {
            return new Urgency[] {

                new Urgency{Id = 1,Level = "Low"},
                new Urgency{Id = 2,Level = "Medium"},
                new Urgency{Id = 3,Level = "High"},
                new Urgency{Id = 4,Level = "Critical"},
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
                new Status{Id = 1,TicketStatus = "Closed"},
                new Status{Id = 2,TicketStatus = "Resolved"},
                new Status{Id = 3, TicketStatus = "Opened"},
                new Status{Id = 4, TicketStatus = "Pending"},
                new Status{Id = 5, TicketStatus = "Assigned"},

            };
        }

        public static Ticket[] GetDefaultTickets()
        {

            return new Ticket[]
            {
                new Ticket
                {
                    Id = 1,
                    Description = "En smältande polis jagar mig och en Österrikisk bodybuilder säger att jag ska rädda framtiden",
                    SubmittedDate = DateTime.Now.AddDays(3),
                    LastUpdated = DateTime.Now.AddDays(7),
                    Title = "Mördarrobotar",
                    TicketProductId = 5,
                    TicketStatusId = 1, // 1 = "Closed"
                    TicketBugTypeId = 1,
                    TicketUrgencyId = 1,
                    SubmitterId = "DefaultId",
                },
                new Ticket
                {
                    Id = 2,
                    Description = "Jag gjorde min matteläxa när programmet plötsligt",
                    SubmittedDate = DateTime.Now,
                    LastUpdated = DateTime.Now,
                    Title = "Programmet åt min läxa",
                    TicketProductId = 1,
                    TicketStatusId = 3, // 3 = "open,
                    TicketBugTypeId = 3,
                    TicketUrgencyId = 2,
                    SubmitterId = "DefaultId",
                },
            };
        }
    }
}
