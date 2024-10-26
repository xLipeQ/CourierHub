using mini_package_api.Enums;
using mini_package_api.Models;
using mini_package_api.Models.Requests;
using mini_package_api.Models.Responses;

namespace mini_package_api.Services.Users
{
    public interface IUserService
    {
        User FindUserByUsername(string username);
        User FindUserByEmail(string email);
        bool CheckUserCredentials(User user, string providedPassword);

        User FindGuestUser();

        LoginResponse Login(LoginRequest loginRequest);
        LoginResponse LoginGoogle(LoginGoogleRequest request);
        string AuthenticateUser(User user, string password);
        string AuthenticateUserGoogle(User user);
    }
}
