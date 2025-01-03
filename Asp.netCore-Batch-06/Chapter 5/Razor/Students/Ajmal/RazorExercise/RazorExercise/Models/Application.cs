namespace RazorExercise.Models
{
    public class Application
    {
        public Guid Id { get; set; }
        public string Jobtitle { get; set; }
        public string Company { get; set; }
        //public string jobtype { get; set; }

        public string Description { get; set; }
        public string Date { get; set; }
        public string Location { get; set; }
        public string image { get; set; }
        public Application(Guid id, string jobtitle, string company, string description, string date, string location, string image)
        {
            Id = id;
            Jobtitle = jobtitle;
            Company = company;
            Description = description;
            Date = date;
            Location = location;
            this.image = image;
        }
        public Application() { }
    }
}
