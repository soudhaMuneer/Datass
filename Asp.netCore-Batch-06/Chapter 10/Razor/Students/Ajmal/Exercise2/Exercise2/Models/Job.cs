namespace Exercise2.Models
{
    public class Job
    {
        public Guid Id { get; set; }
        public string JobTitle { get; set; }
        public string JobDescription { get; set; }
        public string Company {  get; set; }
        public string Place {  get; set; }
        public DateTime Date { get; set; }
        public Job(Guid id, string jobTitle, string jobDescription, string company, string place, DateTime date)
        {
            Id = id;
            JobTitle = jobTitle;
            JobDescription = jobDescription;
            Company = company;
            Place = place;
            Date = date;
        }
        public Job() { }
    }
}
