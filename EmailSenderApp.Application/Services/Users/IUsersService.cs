using EmailSenderApp.Domain.Entites.Models.AuthModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailSenderApp.Application.Services.Users
{
    public interface IUsersService
    {
        Task<List<User>> GetAllUsers();
        Task<User> GetUserById(int id);
        Task<string> DeleteUser(int id);
        Task<string> UpdateUser(int id, User user);
        Task<string> CreateUser(User user);
    }
}
