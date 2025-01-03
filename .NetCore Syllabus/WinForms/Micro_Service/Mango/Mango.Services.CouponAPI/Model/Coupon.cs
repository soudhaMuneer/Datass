using System.ComponentModel.DataAnnotations;

namespace Mangos.Services.CouponAPI.Model
{
    public class Coupon
    {
        [Key]
        public int couponId { get; set; }
        [Required]
        public string couponCode { get; set; }
        [Required]
        public double DiscountAmount { get; set; }
        public int MinAmount { get; set; }

        public static implicit operator string(Coupon v)
        {
            throw new NotImplementedException();
        }
    }
}

