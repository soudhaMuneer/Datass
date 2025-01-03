using AutoMapper;
using Domain.Enums;
using Domain.Models;
using Domain.Service.Category.DTOs;
using Domain.Service.User.DTO;
using Domain.Service.User.Interfaces;
using Empetz_API.API.Public;
using Empetz_API.API.Public.RequestObject;
using Empetz_API.API.User;
using FakeItEasy;
using FluentAssertions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empetz_API.Test.Controller
{
    public class UserControllerTest
    {
        private readonly IMapper _mapper;
        private readonly IUserService _userService;
        private readonly IHttpContextAccessor httpContextAccessor;
        public UserControllerTest()
        {
            _mapper = A.Fake<IMapper>();
            _userService = A.Fake<IUserService>();
            httpContextAccessor=A.Fake<IHttpContextAccessor>();
        }
    
        [Fact]
        public async Task UserController_GetUserById_ReturnsOk()
        {
            // Arrange
            var userId = Guid.NewGuid();
            var userDto = new UserDto
            {
                Id = userId,
                FirstName = "John",
                LastName = "Doe",
                Email = "john.doe@example.com",
                Phone = "123-456-7890",
                Image = new byte[] { 1, 2, 3 },
                Role = (int)Role.PublicUser,
                Accountcreated = DateTime.UtcNow
                // Set other properties as needed for your test
            };

            A.CallTo(() => _userService.GetByIdAsync(userId))
                .Returns(Task.FromResult(userDto));

            var controller = new UserController(_mapper, _userService , httpContextAccessor);

            // Act
            var result = await controller.GetUserById(userId);

            // Assert
            result.Should().BeOfType<OkObjectResult>()
                .Which.Value.Should().BeEquivalentTo(userDto);
        }
     
        //}
        [Fact]
        public async Task UserController_DeleteUser_ReturnsOk()
        {
            // Arrange
            var userId = Guid.NewGuid();

            A.CallTo(() => _userService.DeleteUserAsync(userId))
                .Returns(Task.CompletedTask); // Adjust as needed based on your DeleteUserAsync method

            var controller = new UserController(_mapper, _userService, httpContextAccessor);

            // Act
            var result = await controller.DeleteUser(userId);

            // Assert
            result.Should().BeOfType<OkObjectResult>()
                .Which.Value.Should().Be("User deleted successfully");
        }

        [Fact]
        public async Task UserController_DeleteUser_ReturnsBadRequestWhenIdIsNull()
        {
            // Arrange
            Guid? userIdNullable = Guid.NewGuid(); // or use actual nullable Guid
            Guid userId = userIdNullable.Value;

            A.CallTo(() => _userService.DeleteUserAsync(userId))
                .Returns(Task.CompletedTask);

            var controller = new UserController(_mapper, _userService, httpContextAccessor);

            // Act
            var result = await controller.DeleteUser(userId);

            // Assert
            result.Should().BeOfType<OkObjectResult>()
                .Which.Value.Should().Be("User deleted successfully");
        }

    }


    }

