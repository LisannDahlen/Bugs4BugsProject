using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Bugs4Bugs.Models
{
	public class ApplicationContext : IdentityDbContext<SiteUser, IdentityRole, string>
	{
        // Denna konstruktor krävs för att konfigurationen ska fungera
        public ApplicationContext(DbContextOptions<ApplicationContext> options) :
            base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<BugType>().HasData(ProductUtilities.GetDefaultBugTypes());
            builder.Entity<Status>().HasData(ProductUtilities.GetDefaultStatuses());
            builder.Entity<Urgency>().HasData(ProductUtilities.GetDefaultUrgencyLevels());
            builder.Entity<Product>().HasData(ProductUtilities.GetDefaultProducts());
        }
        // Exponerar våra databas-modeller via properties av typen DbSet<T> 
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<Urgency> Urgencies { get; set; }
        public DbSet<Status> Statuses { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<BugType> BuggTypes { get; set; }

    }


}