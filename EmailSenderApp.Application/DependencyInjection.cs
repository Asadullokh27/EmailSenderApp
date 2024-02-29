using EmailSenderApp.Application.Services.AuthServices;
using EmailSenderApp.Application.Services.Users;
using Microsoft.Extensions.DependencyInjection;

namespace EmailSenderApp.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddScoped<IUsersService, UsersService>();
            services.AddScoped<IAuthService, AuthService>();

            return services;
        }
    }
}
    