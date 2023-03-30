using Microsoft.AspNetCore.Identity;

namespace Bugs4Bugs.Models
{
	public class SiteUser : IdentityUser
	{
		public string? FirstName { get; set; }
        public string? LastName { get; set; }

        //List<Ticket> DevelopedTickets { get; set; }
        List<Ticket> SubmittedTickets { get; set; }

        //public List<ProductRole>? ProductRoles { get; set; } = new List<ProductRole>();


    }


}