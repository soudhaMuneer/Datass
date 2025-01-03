namespace EmployeeCrud.Data
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }

        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string FullName => $"{FirstName} {MiddleName} {LastName}";
        public string PostalCode { get; set; }
        public string Address { get; set; }
        public string EmailAddress { get; set; }

        public Employee(int id,string firstname, string Middlename,string Lastname, string postalCode, string address, string emailAddress)
        {
            Id=id;
            FirstName = firstname;
            MiddleName = Middlename;
            LastName = Lastname;
            PostalCode = postalCode;
            Address = address;
            EmailAddress = emailAddress;


        }
        public Employee()
        {
            
        }
    }
}
