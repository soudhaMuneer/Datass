using System;
using BlazorworkShop.Enums;
using BlazorworkShop.Models;

namespace BlazorworkShop.Dtos
{
    public class UserProfileDto : UserDto
	{
        public UserProfileDto(string firstName, string lastName, string email, string gender, string? location, string designation, long phone, string password, Roles role) : base(firstName, lastName, email, gender, location, designation, phone, password, role)
        {
        }

        public string? About { get; set; }
        public virtual ICollection<Skill> Skills { get; set; } = new List<Skill>();
        public virtual ICollection<Qualification> Qualifications { get; set; } = new List<Qualification>();
        public virtual ICollection<Experience> Experiences { get; set; } = new List<Experience>();
        public string? Designation { get; set; }
        public Guid? companyId { get; set; }
        public string? Image { get; set; }
        public Skill skill { get; set; }
        public Experience experience { get; set; }
        public Qualification qualification { get; set; }
    }
}

