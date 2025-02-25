﻿using AutoMapper;
using HireMeNowWebApi.Dtos;
using HireMeNowWebApi.Exceptions;
using HireMeNowWebApi.Interfaces;
using HireMeNowWebApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HireMeNowWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly IMapper _mapper;

        public UserController(IUserService userService, IMapper mapper)
        {
            _userService = userService;
            _mapper = mapper;
        }
        [HttpPost("/account/register")]
        public IActionResult Register(UserDto userDto)
        {
            var user = _mapper.Map<User>(userDto);
            return Ok(_userService.register(user));
        }

        [HttpPost("/account/login")]
        public IActionResult Login(LoginDto loginDto)
        {
            //var user = _mapper.Map<User>(userDto);
            var user = _userService.login(loginDto.Email, loginDto.Password);
            if (user == null)
            {
                return BadRequest("Login Failed");
            }
            return Ok(_mapper.Map<UserDto>(user));
        }
        [HttpGet("/account/profile")]
        public IActionResult GetProfile(Guid userId)
        {
            User user = _userService.getById(userId);
            if (user == null)
            {
                return BadRequest("User with id : " + userId + " Not Found.");
                //  throw new NotFoundException("User with id : "+userId+ " Not Found.");
            }
            return Ok(user);
        }

    }
}
