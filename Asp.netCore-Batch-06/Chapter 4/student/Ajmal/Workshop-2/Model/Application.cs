﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyMember.Model
{
    public class Application
    {
        public int Id { get; set; }
        public string Experience { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public string Qualification { get; set; }
        public string Jobtitle { get; set; }

        public Application(int jobId, string applicantName, string location, string qualification, string experience, string jobtitle)
        {
            Id = jobId;
            Name = applicantName;
            Location = location;
            Qualification = qualification;
            Experience = experience;
            Jobtitle = jobtitle;
        }
        public Application() { }
    }
}
