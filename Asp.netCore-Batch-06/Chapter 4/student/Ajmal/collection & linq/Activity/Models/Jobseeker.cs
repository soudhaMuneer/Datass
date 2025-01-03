using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity.Models
{
    public class Jobseeker
    {
        public int id
        { get; set; }
        public string name { get; set; }
        public string Email { get; set; }
        public string Mobile {  get; set; }
        public string City { get; set; }

        public void Addjobseeker(int id, string name,string email,string mobile,string city)
        {
            this.id = id;
            this.name = name;
            this.Email = email;
            this.Mobile = mobile;
            this.City = city;
        }
        public void Register()
        {
           
        }
        public Jobseeker() { }
    }
   
}
