using Microsoft.EntityFrameworkCore;
using MVCExam.Dto;

namespace MVCExam.Models
{
    public class PersonDBContext : DbContext
    {
        public PersonDBContext() { }

        public PersonDBContext(DbContextOptions<PersonDBContext> options) : base(options)
        {
        }

        public virtual DbSet<Person> Persons { get; set; }  
        public DbSet<MVCExam.Dto.PersonDto> PersonDto { get; set; } = default!;
    }
}
