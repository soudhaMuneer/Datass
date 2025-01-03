using MVCWorkshop.Models;

namespace MVCWorkshop.Dtos
{
    public class JobDto
    {
        public Guid Id { get; set; }

        public string? Title { get; set; }

        public string? Description { get; set; }

        public string? Location { get; set; }

        public string? Experience { get; set; }

        public string? TypeOfWorkPlace { get; set; }

        public string? Salary { get; set; }
        public string? Company { get; set; }
        public Guid? CompanyId { get; set; }

        public JobDto(string title,string description,string location,string salary,Guid companyId,string company,Guid id) 
        {
            Id = id;
            Title = title;
            Description = description;
            Location = location;
            Salary = salary;
            CompanyId = companyId;
            Company = company;
        }

        public JobDto() { }
    }
}
