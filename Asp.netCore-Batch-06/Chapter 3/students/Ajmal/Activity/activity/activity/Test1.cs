using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace activity
{
    public class Test1:Sample
    {
        public string? email {  get; set; }
        public int phone { get; set; }
        public string? name { get; set; }

        public void Home()
        {
            Console.WriteLine(" JOBIE \nHome\nJobs\nMessage\nSettings");
        }
        public override void Welcome()
        {
            Console.WriteLine("Welcome To JoPortal");
        }

    }
   
}
