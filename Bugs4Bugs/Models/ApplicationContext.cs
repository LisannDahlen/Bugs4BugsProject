using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Bugs4Bugs.Models.Services;
using System.Reflection.Emit;

namespace Bugs4Bugs.Models
{
	public class ApplicationContext : IdentityDbContext<SiteUser, IdentityRole, string>
	{
        // Denna konstruktor krävs för att konfigurationen ska fungera
        private readonly IHttpContextAccessor httpContextAccessor;

        public ApplicationContext(DbContextOptions<ApplicationContext> options, IHttpContextAccessor httpContextAccessor) :
            base(options)
        {
            this.httpContextAccessor = httpContextAccessor;
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<BugType>().HasData(ProductUtilities.GetDefaultBugTypes());
            builder.Entity<Status>().HasData(ProductUtilities.GetDefaultStatuses());
            builder.Entity<Urgency>().HasData(ProductUtilities.GetDefaultUrgencyLevels());
            builder.Entity<Product>().HasData(ProductUtilities.GetDefaultProducts());
            builder.Entity<Ticket>().HasData(ProductUtilities.GetDefaultTickets());
            builder.Entity<IdentityRole>().HasData(ProductUtilities.GetRoles());
            builder.Entity<IdentityUserRole<string>>().HasData(ProductUtilities.GetIdentityUserRoles());

            var users = ProductUtilities.GetDefaultSiteUsers();
            builder.Entity<SiteUser>().HasData(users);
            
        }
        // Exponerar våra databas-modeller via properties av typen DbSet<T> 
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<Urgency> Urgencies { get; set; }
        public DbSet<Status> Statuses { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<BugType> BuggTypes { get; set; }

    }


}