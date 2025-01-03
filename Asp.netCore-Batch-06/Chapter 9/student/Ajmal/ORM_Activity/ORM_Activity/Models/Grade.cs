using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM_Activity.Models
{
    public class Grade
    {
        public Grade()
        {
            List<Student> Students = new List<Student>();
        }
        public int GradeId { get; set; }
        public string GradeName { get; set; }

        public IList<Student> Students { get; set; }


    }
}
