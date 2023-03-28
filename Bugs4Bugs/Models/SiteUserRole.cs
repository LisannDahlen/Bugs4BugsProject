namespace Bugs4Bugs.Models
{
    public class SiteUserRole
    {
        public int Id { get; set; }
        public string SiteUserId { get; set; }
        public SiteUser SiteUser { get; set; }
        public int RoleInProductId { get; set; }
        public Role RoleInProduct { get; set; }
    }
}
