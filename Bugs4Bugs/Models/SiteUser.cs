using Microsoft.AspNetCore.Identity;

namespace Bugs4Bugs.Models
{
	public class SiteUser : IdentityUser
	{
		public string? FirstName { get; set; }
        public string? LastName { get; set; }

        public List<ProductRole> ProductRoles { get; set; } = new List<ProductRole>();


    }


}