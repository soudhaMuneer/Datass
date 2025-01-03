using System;
using static System.Net.Mime.MediaTypeNames;
using System.Net;
using System.Numerics;
using System.Reflection;

namespace BlazorworkShop.Dtos
{
	public class CompanyDto
	{
		public CompanyDto(string? name, string? email, string? website, string? phone, string? image, string? about, string? vision, string? mission, string? location, string? address, Guid? id = null)
		{
            Id = id ?? new Guid();
            Name = name;
            Email = email;
            Website = website;
            Phone = phone;
            Base64Image = image;
            About = about;
            Vision = vision;
            Mission = mission;
            Location = location;
            Address = address;
        }
        public Guid? Id { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Website { get; set; }
        public string? Phone { get; set; }
        public string? Image { get; set; }
        public IFormFile? ImageFile { get; set; }
        public string? About { get; set; }
        public string? Vision { get; set; }
        public string? Mission { get; set; }
        public string? Location { get; set; }
        public string? Address { get; set; }
        public string? Base64Image { get; set; }
    }
}

