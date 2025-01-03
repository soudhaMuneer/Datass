using System.ComponentModel.DataAnnotations;

namespace Exercise2.DTOs
{
    public class LoginDtos
    {
       
        [Required]
        [EmailAddress]
        public string? Email { get; set; }
        [Required]
        public string? Password { get; set; }
    }
}
