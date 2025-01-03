namespace Workshop.Models
{
    public class Application
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int JobId { get; set; }
        public int CompanyId { get; set; }
        public string AppliedDate { get; set;}
        public string Status { get; set;}
    }
}
