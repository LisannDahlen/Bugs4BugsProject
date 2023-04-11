using Bugs4Bugs.Models.Services;
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
                new Product()
                {
                   Id = 13,
                   Name = "Bugs4Bugs",
                   PhotoURL = "Images/bee.png"
                },
            };

        }
        static readonly string defaultUserId = Guid.NewGuid().ToString();
        static readonly string defaultTechnicianId = Guid.NewGuid().ToString();
        static readonly string defaultOwnerId = Guid.NewGuid().ToString();
        static readonly string defaultUserRoleId = Guid.NewGuid().ToString();
        static readonly string defaultTechnicianRoleId = Guid.NewGuid().ToString();
        static readonly string defaultOwnerRoleId = Guid.NewGuid().ToString();
        public static IdentityRole[] GetRoles()
        {
            return new IdentityRole[]
            {
                new IdentityRole { Id = defaultUserRoleId, Name = "User", NormalizedName = "USER".ToUpper() },
                new IdentityRole { Id = defaultTechnicianRoleId, Name = "Technician", NormalizedName = "Technician".ToUpper() },
                new IdentityRole { Id = defaultOwnerRoleId, Name = "Owner", NormalizedName = "Owner".ToUpper() },
            };
        }
        public static IdentityUserRole<string>[] GetIdentityUserRoles()
        {
            return new IdentityUserRole<string>[]
            {
                new IdentityUserRole<string>{RoleId = defaultUserRoleId, UserId = defaultUserId},
                new IdentityUserRole<string>{RoleId = defaultTechnicianRoleId, UserId = defaultTechnicianId},
                new IdentityUserRole<string>{RoleId = defaultOwnerRoleId, UserId = defaultOwnerId},
            };
        }
        public static SiteUser[] GetDefaultSiteUsers(IPasswordHasher<SiteUser> passwordHasher)
        {
            
            SiteUser defaultUser = new SiteUser { Id = defaultUserId, FirstName = "John", LastName = "Connor", UserName = "JohnConnor", PasswordHash = passwordHasher.HashPassword(null, "Default123#"), NormalizedEmail = "USER@MAIL.COM", NormalizedUserName = "JOHNCONNOR" };
            SiteUser defaultDeveloper = new SiteUser { Id = defaultTechnicianId, FirstName = "Dev", LastName = "Code", UserName = "DevCode", PasswordHash = passwordHasher.HashPassword(null, "Default123#"), NormalizedEmail = "TECHNICHIAN@MAIL.COM", NormalizedUserName = "DEVCODE" };
            SiteUser defaultProductManager = new SiteUser { Id = defaultOwnerId, FirstName = "Owen", LastName = "Er", UserName = "OwenEr", PasswordHash = passwordHasher.HashPassword(null, "Default123#"), NormalizedEmail = "OWENER@MAIL.COM", NormalizedUserName = "OWENER" };

            return new SiteUser[] { defaultUser, defaultDeveloper, defaultProductManager };
        }

        public static Urgency[] GetDefaultUrgencyLevels()
        {
            return new Urgency[] {

                new Urgency{Id = 1,Level = "Low", ColorHexString = "#0D6EFD"},
                new Urgency{Id = 2,Level = "Medium", ColorHexString = "#FFCD29"},
                new Urgency{Id = 3,Level = "High", ColorHexString = "#FD7E14"},
                new Urgency{Id = 4,Level = "Critical", ColorHexString = "#DC3545"},
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
                new BugType{Id = 5,Type = "Broken feature"},
            };
        }

        public static Status[] GetDefaultStatuses()
        {
            return new Status[] {
                new Status{Id = 1,TicketStatus = "Closed", ColorHexString = "#adb5bd"},
                new Status{Id = 2,TicketStatus = "Resolved", ColorHexString = "#198754"},
                new Status{Id = 3, TicketStatus = "Opened", ColorHexString = "#0d6efd"},
                new Status{Id = 4, TicketStatus = "Pending", ColorHexString = "#FFCD29"},
                new Status{Id = 5, TicketStatus = "Assigned", ColorHexString = "#0d6efd"},

            };
        }

        //public static Ticket[] GetDefaultTickets()
        //{

        //    return new Ticket[]
        //    {
        //        new Ticket
        //        {
        //            Id = 1,
        //            Description = "En smältande polis jagar mig och en Österrikisk bodybuilder säger att jag ska rädda framtiden",
        //            SubmittedDate = DateTime.Now.AddDays(3),
        //            LastUpdated = DateTime.Now.AddDays(7),
        //            Title = "Mördarrobotar",
        //            TicketProductId = 5,
        //            TicketStatusId = 1, // 1 = "Closed"
        //            TicketBugTypeId = 1,
        //            TicketUrgencyId = 1,
        //            SubmitterId = "defaultUser",
        //        },
        //        new Ticket
        //        {
        //            Id = 2,
        //            Description = "Jag gjorde min matteläxa när programmet plötsligt",
        //            SubmittedDate = DateTime.Now,
        //            LastUpdated = DateTime.Now,
        //            Title = "Programmet åt min läxa",
        //            TicketProductId = 1,
        //            TicketStatusId = 3, // 3 = "open,
        //            TicketBugTypeId = 3,
        //            TicketUrgencyId = 2,
        //            SubmitterId = "defaultUser",
        //        },
        //    };
        //}
    }
}
