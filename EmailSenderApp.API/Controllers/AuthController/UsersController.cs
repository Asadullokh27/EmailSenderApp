using EmailSenderApp.API.Attributes;
using EmailSenderApp.Application.Services.Users;
using EmailSenderApp.Domain.Entites.Models.AuthModels;
using EmailSenderApp.Domain.Enums;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmailSenderApp.API.Controllers.AuthController
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    [Authorize]
    public class UsersController : ControllerBase
    {


        private readonly IUsersService _usersService;

        public UsersController(IUsersService usersService)
        {
            _usersService = usersService;
        }

        [HttpGet]
        [IdentityFilter(Permission.GetAllUsers)]
        public Task<List<User>> GetAllUsers()
        {
            var res = _usersService.GetAllUsers();
            return res;
        }
        [HttpGet]
        [IdentityFilter(Permission.GetUsersById)]
        public Task<User> GetUsersById(int id)
        {
            Task<User>? res = _usersService.GetUserById(id);
            return res;
        }
        [HttpPost]
        [IdentityFilter(Permission.CreateUser)]
        public Task<string> CreateUser(User user)
        {
            Task<string> res = _usersService.CreateUser(user);
            return res;
        }
        [HttpPut]
        [IdentityFilter(Permission.UpdateUser)]
        public Task<string> UpdateUser(int id, User user)
        {
            var res = _usersService.UpdateUser(id, user);
            return res;
        }
        [HttpDelete]
        [IdentityFilter(Permission.DeleteUser)]
        public Task<string> DeleteUser(int id)
        {
            Task<string> res = _usersService.DeleteUser(id);
            return res;
        }

    }
}
