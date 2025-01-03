using System.ComponentModel.DataAnnotations;

namespace Razoractivity3.Model
{
    public class People
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int Age { get; set; }
    }
}
