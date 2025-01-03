using Microsoft.EntityFrameworkCore;
using Workshop.DTOs;

namespace Workshop.Models
{
    public class HireMeNowDbContext :DbContext
    {
        public HireMeNowDbContext()
        { 
        }
        public HireMeNowDbContext(DbContextOptions <HireMeNowDbContext> options) : base(options) { }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Interviews> Interviews { get; set; }
     
    }
}
