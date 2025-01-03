using System.ComponentModel.DataAnnotations;

namespace RazorWorkshop4.Models
{
    public class Job
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string Location { get; set; }
        [Required]

        public string Salary { get; set; }
        public string Type { get; set; }
        public string Company {  get; set; }
        public int Capacity { get; set; }
        public int Applied { get; set; }
        public Job(int id,string title,string description,string location,string salary,string type,string company,int capacity,int applied)
        {
          
            Id = id;
            Title = title;
            Description = description;
            Location = location;
            Salary = salary;
            Type = type;
            Company = company;
            Capacity = capacity;
            Applied = applied;

        }

        public Job() { }
    }
}
