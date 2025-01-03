namespace Workshop.Models
{
    public class Qualifications
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Title { get; set; }
        public string Mark { get; set; }
        public string YearOfPassOut { get; set; }
        public string University { get; set; }
        public string Status { get; set; }

        public virtual User? Users { get; set; }
    }
}
