using Admin_Portal.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Admin_Portal.Model
{
    public class Job
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public ExperienceLevel ExperienceLevel { get; set; }
        public string Company { get; set; }
        public string Location { get; set; }
        public string SalaryRange { get; set; }
    }
}
