namespace RazorExercise.Model
{
    public class Job
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Requirements { get; set; }
        public string Location { get; set; }
        public string Type { get; set; }
        public double Salary { get; set; }

        public Job(int id,string title,string requirements,string location,string type,double salary)
        { 
            Id= id; 
            Title= title;
            Requirements= requirements;
            Location= location;
            Type= type;
            Salary= salary;

        }
        public Job() { }

    }
}
