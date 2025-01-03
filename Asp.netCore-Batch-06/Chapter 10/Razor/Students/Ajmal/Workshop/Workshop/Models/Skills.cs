namespace Workshop.Models
{
    public class Skills
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public string Title { get; set; }
        public string Status { get; set; }
        public virtual User? Users { get; set; }
    }
}
