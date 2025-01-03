using System.ComponentModel.DataAnnotations;

namespace Chapter10Exercise1.Models
{
    public class Users
    {
        public int Id { get; set; }

        [Required]
        public string? Username { get; set; }
        [Required]
        [EmailAddress]
        public string? Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string? Password { get; set; }
    }
}
