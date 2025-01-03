using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Additional_exercise.Model
{
    public class Address:Person
    {
        //public int Id { get; set; }
        public int Roomnumber { get; set; }
        public string building { get; set; }
        public string street {  get; set; }
        public string city { get; set; }
        public string phone {  get; set; }
        public string email { get; set; }

        public Address(int room,string building,string street,string city,string phone,string email) 
        {
            this.Roomnumber = room;
            this.building = building;
            this.street = street;
            this.city = city;
            this.phone = phone;
            this.email = email;
        }
        public Address() { }
    }
}
