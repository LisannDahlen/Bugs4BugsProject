using Microsoft.EntityFrameworkCore;

namespace Bugs4Bugs.Models
{
    public class ApplicationContext : DbContext
    {
        // Denna konstruktor krävs för att konfigurationen ska fungera
        public ApplicationContext(DbContextOptions<ApplicationContext> options) :
            base(options)
        {
        }

        // Exponerar våra databas-modeller via properties av typen DbSet<T> 
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<TicketUrgency> TicketUrgency { get; set; }
    }

}