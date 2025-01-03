using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workshop3.Models
{
    public class Jobs
    {
        private int id;
        private string title;
        private string salary;
        private string location;
        private string description;
        string requiredSkills;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        // Define getters and setters for the job properties
        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        public string Salary
        {
            get { return salary; }
            set { salary = value; }
        }
        public string Location
        {
            get { return location; }
            set { location = value; }
        }
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        public string RequiredSkills
        {
            get { return requiredSkills; }
            set { requiredSkills = value; }
        }
        public bool IsAvailable { get; set; }
        // Define a constructor for the job
    }
}
