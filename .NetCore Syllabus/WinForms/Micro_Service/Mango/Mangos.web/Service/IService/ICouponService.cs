
using Mangos.web.Models;

namespace Mangos.web.Service.IService
{
    public interface ICouponService
    {
        Task<ResponseDto?> GetCouponAsync(string couponcode);
        Task<ResponseDto?> GetAllCouponAsync();
        Task<ResponseDto?> GetCouponAsync();

        Task<ResponseDto?> CreateCouponAsync(CouponDto coupondto);

        Task<ResponseDto?> UpdateCouponAsync(CouponDto coupon);

        Task<ResponseDto?> DeleteCouponAsync(int id);
        Task<ResponseDto?> GetCouponByIdAsync(int couponId);
        Task<ResponseDto?> DeleteCouponsAsync(int couponId);
    }
}
