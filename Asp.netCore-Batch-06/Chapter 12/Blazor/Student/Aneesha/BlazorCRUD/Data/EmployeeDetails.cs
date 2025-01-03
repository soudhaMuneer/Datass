namespace BlazorCRUD.Data
{
    public class EmployeeDetails
    {
        public int Id {  get; set; }    
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        public EmployeeDetails() { }

        public EmployeeDetails(int id, string firstName, string lastName, string email, string phone)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Phone = phone;
        }
    }
}
