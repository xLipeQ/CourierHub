using mini_package_api.Models;
using System.Security.Claims;

namespace mini_package_api.Services.Auth
{
    public interface IAuthService
    {
        string GenerateUserToken(User user);

        string HashPasword(string password, out byte[] salt);

        bool VerifyPassword(string password, string hash, byte[] salt);

    }
}
