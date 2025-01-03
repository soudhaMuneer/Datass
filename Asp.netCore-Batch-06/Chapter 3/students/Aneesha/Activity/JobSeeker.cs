using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity
{
    public class JobSeeker:User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Location { get; set; }
        public string Phone { get; set; }

        public void ApplyJob(int jobId)
        {
            Console.WriteLine("Apply job start");
        }
        public override void Welcome()
        {
            Console.WriteLine("Welcome to hire me now");
        }
    }
}
