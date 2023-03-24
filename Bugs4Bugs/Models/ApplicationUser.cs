using Microsoft.AspNetCore.Identity;

namespace Bugs4Bugs.Models
{
	public class ApplicationUser : IdentityUser
	{
		public string? FirstName { get; set; }
        public string? LastName { get; set; }
        

    }


}