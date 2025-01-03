using Microsoft.EntityFrameworkCore;
using RZExercise.Models;

namespace RZExercise.DAL
{
    public class SeekerDBContext : DbContext
    {
        public SeekerDBContext(DbContextOptions options) : base(options)
        {
        }

        public virtual DbSet<Apply> Applies { get; set; }

        public virtual DbSet<Interview> Interviews { get; set; }

        public virtual DbSet<Job> Jobs { get; set; }

        public virtual DbSet<User> Users { get; set; }


    }
}
