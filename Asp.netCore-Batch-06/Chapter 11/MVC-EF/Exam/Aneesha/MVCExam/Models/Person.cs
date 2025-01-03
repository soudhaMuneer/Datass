using MVCExam.Enums;

namespace MVCExam.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public Roles Roles { get; internal set; }
    }
}
