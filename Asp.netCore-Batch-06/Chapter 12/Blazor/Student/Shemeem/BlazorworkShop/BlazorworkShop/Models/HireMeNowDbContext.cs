using System;
using Microsoft.EntityFrameworkCore;

namespace BlazorworkShop.Models
{
	public class HireMeNowDbContext:DbContext
	{
        public HireMeNowDbContext()
        {
        }

        public HireMeNowDbContext(DbContextOptions<HireMeNowDbContext>options)
			: base(options)
		{
		}
		public virtual DbSet<Application> Applications { get; set; }

        public virtual DbSet<Company> Companies { get; set; }

        public virtual DbSet<Experience> Experiences { get; set; }

        public virtual DbSet<Interview> Interviews { get; set; }

       public virtual DbSet<Job> Jobs { get; set; }

       public virtual DbSet<Qualification> Qualifications { get; set; }

       public virtual DbSet<Skill> Skills { get; set; }

        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Interview>()
                .HasOne(i => i.CreatedUser)
                .WithMany(u => u.InterviewCreatedByNavigations)
                .HasForeignKey(i => i.CreatedBy);
        }

    }
}

