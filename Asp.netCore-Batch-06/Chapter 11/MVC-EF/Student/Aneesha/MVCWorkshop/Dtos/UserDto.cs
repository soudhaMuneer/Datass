using MVCWorkshop.Enums;

namespace MVCWorkshop.Dtos
{
    public class UserDto
    {
        public Guid Id { get; set; }

        public string? FirstName { get; set; }

        public string? LastName { get; set; }

        public string Email { get; set; } = null!;

        public string? Gender { get; set; }

        public string? Location { get; set; }

        public string? Phone { get; set; }

        public string? Password { get; set; }

        public Roles? Role { get; set; }

        public string? About { get; set; }

        public UserDto() { }    

        public UserDto(Guid id, string? firstName, string? lastName, string email, string? gender, string? location, string? phone, string? password, Roles? role, string? about)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Gender = gender;
            Location = location;
            Phone = phone;
            Password = password;
            Role = role;
            About = about;
        }
    }
}
