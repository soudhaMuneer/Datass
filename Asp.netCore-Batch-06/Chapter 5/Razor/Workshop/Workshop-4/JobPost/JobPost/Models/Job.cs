 using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobPost.Models
{
    public class Job
    {
        public int Id { get; set; }
		[Required]
		public string? Title { get; set; }
		[Required]
		public string? Description { get; set; }
		[Required]
		public string? Location { get; set; }
		[Required]
		public string? Salary { get; set; } = null;
        public string? Type { get; set; } = null;
        public string? Company { get; set; } = null;
        public int? Capacity { get; set; } = null;
        public int? Applied { get; set; }
        public Job()
        {

        }
        
        public Job(int id,string title, string description, string location, string type, string salary, string company)
        {
            Id = id;
            Title = title;
            Description = description;
            Location = location;
            Salary = salary;
            Type = type;
            Company = company;
        }
    }
}
