using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Additional_exercise.Model
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string lastname { get; set; }
        public string Dateofbirth { get; set; }
        public string HomeAddress { get; set; }
        public string WorkAddress { get; set; }

        public Person(int id, string name, string lastname, string dateofbirth, string homeAddress, string workAddress)
        {
            Id = id;
            Name = name;
            this.lastname = lastname;
            Dateofbirth = dateofbirth;
            HomeAddress = homeAddress;
            WorkAddress = workAddress;
        }
        public Person() { }
    }
}
