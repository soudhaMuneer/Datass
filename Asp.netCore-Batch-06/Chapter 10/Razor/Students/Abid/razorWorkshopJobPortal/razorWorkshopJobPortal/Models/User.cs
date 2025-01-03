using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace razorWorkshopJobPortal.Models
{
	
	[Index(nameof(Email), IsUnique = true)]
	public class User
	{

		public Guid Id { get; set; }

		public string? FirstName { get; set; }

		public string? LastName { get; set; }
		[Required]
		[EmailAddress]
		public string Email { get; set; } = null!;

		public string? Gender { get; set; }

		public string? Location { get; set; }

		public string? Phone { get; set; }

		public string? Password { get; set; }

		public string? Role { get; set; }

		public string? About { get; set; }

		public string? Designation { get; set; }

		public Guid? CompanyId { get; set; }

		public string? Status { get; set; }

		public string? Image { get; set; }
	}
}
