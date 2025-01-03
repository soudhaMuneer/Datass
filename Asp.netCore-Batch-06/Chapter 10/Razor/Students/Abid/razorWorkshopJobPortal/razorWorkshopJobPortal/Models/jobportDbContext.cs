using Microsoft.EntityFrameworkCore;

namespace razorWorkshopJobPortal.Models
{
	public class jobportDbContext : DbContext
	{
		public jobportDbContext(DbContextOptions options) : base(options)
		{
		}

		public virtual DbSet<User> Users { get; set; }
	}
}
