namespace Bugs4Bugs.Models
{
    public class BugType
    {
        public BugType()
        {
            
        }
        public BugType(string type)
        {
            Type = type;
        }
        public int Id { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
    }
}
