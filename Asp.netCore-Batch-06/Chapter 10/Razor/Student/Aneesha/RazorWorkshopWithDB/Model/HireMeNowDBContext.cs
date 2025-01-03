using JobPortalApplication.Models;
using Microsoft.EntityFrameworkCore;

namespace RazorWorkshopWithDB.Model
{
    public class HireMeNowDBContext : DbContext
    {
        public HireMeNowDBContext(DbContextOptions options) : base(options)
        {
        }

        public virtual DbSet<User> Users { get; set; }
    }
}
