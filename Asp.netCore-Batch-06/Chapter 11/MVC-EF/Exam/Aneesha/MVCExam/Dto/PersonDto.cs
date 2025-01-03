namespace MVCExam.Dto
{
    public class PersonDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }
        public string City { get; set; }


        public PersonDto(int id, string name, string email, string password, string description, string address, string city)
        {
            Id = id;
            Name = name;
            Email = email;
            Password = password;
            Description = description;
            Address = address;
            City = city;
        }

        public PersonDto() { }
    }
}
