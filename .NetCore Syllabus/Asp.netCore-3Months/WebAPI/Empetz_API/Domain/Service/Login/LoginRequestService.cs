using AutoMapper;
using Domain.Service.Login.DTOs;
using Domain.Service.Login.Interfaces;
using Domain.Service.User.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Service.Login
{
    public class LoginRequestService : ILoginRequestService
    {
        ILoginRequestRepository PublicUserRepository;
        IUserRepository UserRepository;
        IMapper mapper;
        public LoginRequestService(ILoginRequestRepository _PublicUserRepository, IMapper _mapper, IUserRepository _UserRepository)
        {
            PublicUserRepository = _PublicUserRepository;
                mapper = _mapper;
            UserRepository = _UserRepository;
        }
        public async Task<PublicUserLoginDto> login( string Phone)
        {
            var user = await PublicUserRepository.GetUserByPhone(Phone);
            if (user == null)
            {
                return null;
            }
            else
            {
                if ((Phone == user.Phone))
                {
                    var userReturn = mapper.Map<PublicUserLoginDto>(user);
                    userReturn.Token = UserRepository.CreateToken(user);
                    return userReturn;
                }
                return null;
            }
        }
    }
}
