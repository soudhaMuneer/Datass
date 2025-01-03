namespace Mangos.Services.CouponAPI.Model.Dto
{
    public class CouponDto
    {
        public int couponId { get; set; }
        public string couponCode { get; set; }
        public double DiscountAmount { get; set; }
        public int MinAmount { get; set; }
    }
}
