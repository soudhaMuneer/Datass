using Microsoft.EntityFrameworkCore;

namespace Exercise2.Models
{
    public class HireMeNowDbContext:DbContext
    {
        public HireMeNowDbContext()
        {

        }
        public HireMeNowDbContext(DbContextOptions<HireMeNowDbContext>options) : base(options) { }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Job> Jobs { get; set; }
        public virtual DbSet<Interview> Interviews { get; set; }

    }
}
