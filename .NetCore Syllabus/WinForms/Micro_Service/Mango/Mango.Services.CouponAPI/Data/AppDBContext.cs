using Mangos.Services.CouponAPI.Model;
using Microsoft.EntityFrameworkCore;

namespace Mangos.Services.CouponAPI.Data
{
    public class AppDBContext :DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options):base(options)
        {
            
        }
        public DbSet<Coupon> Coupons { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Coupon>().HasData(new Coupon
            {
                couponId = 1,
                couponCode = "ABC031",
                DiscountAmount = 10,
                MinAmount=20
            });
            modelBuilder.Entity<Coupon>().HasData(new Coupon
            {
                couponId = 2,
                couponCode = "ABC051",
                DiscountAmount = 10,
                MinAmount = 20
            });

        }
    }
}
