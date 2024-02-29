using EmailSenderApp.Domain.Entites.Models.AuthModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailSenderApp.Application.Services.Users
{
    public class UsersService
    {

        private readonly ApplicationDbContext _context;

        public UsersService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<string> CreateUser(User user)
        {
            var newUser = new User
            {
                FullName = user.FullName,
                Login = user.Login,
                Password = user.Password,
                Role = user.Role,
            };
            await _context.Users.AddAsync(newUser);
            await _context.SaveChangesAsync();
            return "Created";

        }
    }
}
