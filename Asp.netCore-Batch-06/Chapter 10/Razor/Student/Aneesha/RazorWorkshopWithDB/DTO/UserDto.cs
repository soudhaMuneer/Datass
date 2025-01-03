using System.ComponentModel.DataAnnotations;

namespace RazorWorkshopWithDB.DTO
{
    public class UserDto
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }

        public string? Gender { get; set; }
        public string? Location { get; set; }
        public long? Phone { get; set; }

        public UserDto (Guid id, string firstName, string lastName, string email, string password, string? gender, string? location, long? phone)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Password = password;
            Gender = gender;
            Location = location;
            Phone = phone;
        }

        public UserDto() { }
    }
}
