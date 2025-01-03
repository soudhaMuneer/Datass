using AutoMapper;
using Mangos.Services.CouponAPI.Model;
using Mangos.Services.CouponAPI.Model.Dto;

namespace Mangos.Services.CouponAPI
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMap()
        {
            var mapconfig = new MapperConfiguration(config =>
            {
                config.CreateMap<CouponDto,Coupon>().ReverseMap(); 
                
            });
            return mapconfig;
        }
    }
}
