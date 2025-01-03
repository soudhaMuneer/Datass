using AutoMapper;
using Azure;
using Mangos.Services.CouponAPI.Data;
using Mangos.Services.CouponAPI.Migrations;
using Mangos.Services.CouponAPI.Model;
using Mangos.Services.CouponAPI.Model.Dto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Mangos.Services.CouponAPI.Controllers
{
    [Route("api/coupon")]
    [ApiController]
    public class CouponAPIController : ControllerBase
    {
        private readonly AppDBContext db;
        private ResponseDto _response;
        private IMapper mapper;
        public CouponAPIController(AppDBContext d_b,IMapper _mapper)
        {
            db = d_b;
            mapper = _mapper;
            _response = new ResponseDto();
        }

        [HttpGet]
        public object Get()
        {
            try
            {
                IEnumerable<Coupon> objList = db.Coupons.ToList();
               _response.Result = mapper.Map<IEnumerable<CouponDto>>(objList);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message;
            }

        
            return _response;
        }
        [HttpGet]
        [Route("{id:int}")]
        public ResponseDto Get(int id)
        {
            try
            {
             Coupon obj = db.Coupons.First(e=>e.couponId == id);
                _response.Result = mapper.Map<CouponDto>(obj);
             
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message= ex.Message;
            }
            return _response;
        }
        [HttpGet]
        [Route("GetByCode/{code}")]
        public ResponseDto GetByCode(string code)
        {
            try
            {
                Coupon obj = db.Coupons.First(e => e.couponCode.ToLower() == code.ToLower());
              
                    //_response.IsSuccess = false;
 
                _response.Result = mapper.Map<CouponDto>(obj);

            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message;
            }
            return _response;
        }
        [HttpPost]
        public ResponseDto Post([FromBody] CouponDto couponDto) {
            try
            {
                Coupon obj = mapper.Map<Coupon>(couponDto);
                db.Coupons.Add(obj);
                db.SaveChanges();
                _response.Result = mapper.Map<CouponDto>(obj);
            }
            catch (Exception ex) {

                _response.IsSuccess = false;
                _response.Message = ex.Message;

            }

            return _response;

        }

        [HttpPut]
        public ResponseDto Put([FromBody] CouponDto couponDto)
        {
            try
            {
                Coupon obj = mapper.Map<Coupon>(couponDto);
                db.Coupons.Update(obj);
                db.SaveChanges();
                _response.Result = mapper.Map<CouponDto>(obj);
            }
            catch (Exception ex)
            {

                _response.IsSuccess = false;
                _response.Message = ex.Message;

            }

            return _response;

        }

        [HttpDelete]
        public ResponseDto Delete(int id)
        {
            try
            {
                Coupon obj = db.Coupons.First(u=>u.couponId == id);
                db.Coupons.Remove(obj);
                db.SaveChanges();
              
            }
            catch (Exception ex)
            {

                _response.IsSuccess = false;
                _response.Message = ex.Message;

            }

            return _response;

        }


    }
}
