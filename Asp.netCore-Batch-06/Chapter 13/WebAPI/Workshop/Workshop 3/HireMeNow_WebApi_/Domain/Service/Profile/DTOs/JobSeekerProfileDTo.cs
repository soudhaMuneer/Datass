﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Domain.Models;

namespace Domain.Service.Profile.DTOs
{
    public class JobSeekerProfileDTo
    {
        public string? UserName { get; set; }

        public string FirstName { get; set; } = null!;

        public string? LastName { get; set; }

        public string Phone { get; set; } = null!;

        public byte[] image { get; set; } = null!;
        public string Email { get; set; } = null!;

        [JsonIgnore]
        public List<Qualification> Qualification {  get; set; } = null!;
        //public string? ImageUrl { get; set; }
       
        [JsonIgnore]
        public List<Skill> JobSeekerProfileSkills { get; set; }

        public int Role { get; set; }

    }
}
