using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Numerics;
using System.Reflection;

namespace razorWorkshopJobPortal.DTO
{
	public class userDTO
	{


		public string? FirstName { get; set; }

		public string? LastName { get; set; }
		[Required]
		[EmailAddress]
		public string Email { get; set; } = null!;

		public string? Gender { get; set; }


		public long? Phone { get; set; }
		public string? Password { get; set; }


		public userDTO() { }

		public userDTO(string firstName, string lastName, string email, string gender, long phone, string password)
		{
			FirstName = firstName;
			LastName = lastName;
			Email = email;
			Gender = gender;
			Phone = phone;
			Password = password;

		}
	}

	
}
