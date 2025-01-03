using Microsoft.EntityFrameworkCore;

namespace Chapter10Exercise1.Models
{
    public class JobportalEx3CH10DbContext : DbContext
    {
        public JobportalEx3CH10DbContext(DbContextOptions<JobportalEx3CH10DbContext> options) : base(options) { }

        public virtual DbSet<Users> User {  get; set; }

        //how to update check
        public virtual DbSet<Users> Users { get; set; }
        
        public virtual DbSet<Job> Availablejobs { get; set; }
        public virtual DbSet<Job> Appliedjobs { get; set; }
    }
}
