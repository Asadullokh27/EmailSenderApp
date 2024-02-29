using EmailSenderApp.Domain.Entites.Models.AuthModels;

namespace EmailSenderApp.Application.Services.AuthServices
{
    public interface IAuthService
    {
        public interface IAuthService
        {
            Task<string> GenerateToken(string login, string password);
        }
    }
}
