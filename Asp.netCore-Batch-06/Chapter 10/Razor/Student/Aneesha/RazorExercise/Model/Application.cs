namespace RazorExercise.Model
{
    public class Application
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Resume { get; set; }

        public Application(int id,string name,string email,string phone,string resume) 
        {
            Id = id;
            Name = name;
            Email = email;
            Phone = phone;
            Resume = resume;
        }
        public Application() { }
    }
}
