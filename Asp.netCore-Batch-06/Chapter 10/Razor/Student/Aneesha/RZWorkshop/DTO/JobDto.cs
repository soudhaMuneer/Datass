namespace RZWorkshop.DTO
{
    public class JobDto
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public string Salary { get; set; }
        public Guid CompanyId { get; set; }


        public JobDto(string title,string description,string location,string salary,Guid companyId )
        {
            Id = Guid.NewGuid();
            Title = title;
            Description = description;
            Location = location;
            Salary = salary;
            CompanyId = companyId;
        }
        public JobDto() { } 

    }
    
}
