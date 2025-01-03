using Exercise3.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3.Model
{
    public class Application
    {
       

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Location { get; set; }
        public string AboutMe { get; set; }
        public string Qualification { get; set; }
        public ExperianceLevel ExperienceLevels { get; set; }
        public Roles Role { get; internal set; }

        public Application(int id,string firstName,string lastName,string email,string phone,string location,string aboutMe, string qualification, string ExperienceLevel)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Phone = phone;
            Location = location;
            AboutMe = aboutMe;
            Qualification = qualification;
            ExperienceLevels = ExperienceLevels;

        }

        
    }
}
