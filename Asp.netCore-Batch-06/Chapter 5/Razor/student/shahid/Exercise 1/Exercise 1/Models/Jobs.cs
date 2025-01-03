namespace Exercise_1.Models
{
    public class Jobs
    {
        public int id { get; set; }
        public string Title { get; set; }
        public string Reqirements { get; set; }
        public string Location { get; set; }
        public string Type { get; set; }
        public int Salary { get; set; }

        public Jobs () { }

        public Jobs(int id, string title, string reqirements, string location, string type, int salary)
        {
            this.id = id;
            Title = title;
            Reqirements = reqirements;
            Location = location;
            Type = type;
            Salary = salary;
        }
    }
}
