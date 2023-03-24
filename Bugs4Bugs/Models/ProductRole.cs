namespace Bugs4Bugs.Models
{
    public class ProductRole
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int RoleId { get; set; }
        public Role Role { get; set; }

    }
}
