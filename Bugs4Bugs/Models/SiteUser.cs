using Microsoft.AspNetCore.Identity;

namespace Bugs4Bugs.Models
{
	public class SiteUser : IdentityUser
	{
		public string? FirstName { get; set; }
        public string? LastName { get; set; }

        //List<Ticket> DeveloperTickets { get; set; }
        List<Ticket> SubmitterTickets { get; set; }

        //public List<ProductRole>? ProductRoles { get; set; } = new List<ProductRole>();


    }


}