using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work4.Model
{
    public class Job
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Salary { get; set; }
        
        public string Location { get; set; }

        public Job(int id,string title,string description, string salary,string location)
        {
            this.Id = id;
            this.Title = title;
            this.Description = description;
            this.Salary = salary;
            this.Location = location;
        }

        public Job()
        {
        }
    }
}
