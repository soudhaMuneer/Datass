using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Additional_exercise.Model
{
    public class Country:City
    {
        //public int Id { get; set; }
        public string countryy { get; set; }

        public Country(int id, string name)
        {
            //Id = id;
            countryy = name;
        }

        public Country() { }
    }
}
