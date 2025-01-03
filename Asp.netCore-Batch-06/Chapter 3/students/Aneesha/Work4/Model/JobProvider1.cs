namespace Work4.Model
{
    public class JobProvider
    {
        private int id;
        private string? firstname;
        private string? lastname;
        private string? designation;
        private string? password;

        public JobProvider(int id, string? firstname, string? lastname, string? email, string? designation, string? password)
        {
            this.id = id;
            this.firstname = firstname;
            this.lastname = lastname;
            Email = email;
            this.designation = designation;
            this.password = password;
        }

        public string? Email { get; internal set; }
        public string? Password { get; internal set; }
    }
}