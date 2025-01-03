using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3.Model
{
    public class Interview
    {
        public int Id { get; set; }
        public string Company { get; set; }
        public string Job { get; set; }
        public string Date { get; set; }
        public string Location { get; set; }
        public string Time { get; set; }

        public Interview(int id, string company, string job, string date, string location, string time)
        {
            Id = id;
            Company = company;
            Job = job;
            Date = date;
            Location = location;
            Time = time;
        }

        public Interview()
        {
        }
    }
}
