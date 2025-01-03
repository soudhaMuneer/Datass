using StudentManagemantSystem2.Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagemantSystem2.Model
{
    public class UniversityStudent:StudentManager
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Grade { get; set;}
        public string Major { get; set; }

    }
}
