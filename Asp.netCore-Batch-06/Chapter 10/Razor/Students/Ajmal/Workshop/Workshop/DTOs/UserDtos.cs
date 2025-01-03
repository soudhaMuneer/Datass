using System.ComponentModel.DataAnnotations;
using Workshop.Enums;

namespace Workshop.DTOs
{
    public class UserDtos
    {
        public Guid? Id { get; set; }
        [Required]
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        [Required]
        [EmailAddress]
        public string? Email { get; set; }
        public string? Gender { get; set; }
        public string? Location { get; set; }
        [Required]
        [Phone]
        public string? Phone { get; set; }
        [Required]
        public string? Password { get; set; }
        public Roles? Role { get; set; }
        public string? About { get; set; }
        public string? Designation { get; set; }
        public int? CompanyId { get; set; }
        public string? Status { get; set; }
        public string? Image { get; set; }
        public string? CreateDate { get; set; }
    }
}
