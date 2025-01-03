using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Additional_exercise.Model
{
    public class City:Address
    {
        //public int Id { get; set; }
        public string State { get; set; }

        public City( string name)
        {
            //Id = id;
            State = name;
        }
        public City() { }
    }
}
