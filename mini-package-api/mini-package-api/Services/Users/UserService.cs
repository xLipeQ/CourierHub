using Microsoft.AspNetCore.Razor.TagHelpers;
using mini_package_api.Enums;
using mini_package_api.Models;
using mini_package_api.Models.Requests;
using mini_package_api.Models.Responses;
using mini_package_api.Services.Auth;
using mini_package_api.Services.Clients;
using mini_package_api.Services.Employees;
using mini_package_api.Utils;

namespace mini_package_api.Services.Users
{
    public class UserService : IUserService
    {
        private readonly IClientService _clientService;
        private readonly IEmployeeService _employeeService;
        private readonly IAuthService _authService;
        private readonly ILogger<UserService> logger;
        private readonly ILogHelper logHelper;

        public UserService(
            IClientService clientService,
            IEmployeeService employeeService,
            IAuthService authService,
            ILogger<UserService> logger,
            ILogHelper logHelper)
        {
            _clientService = clientService;
            _employeeService = employeeService;
            _authService = authService;
            this.logger = logger;
            this.logHelper = logHelper;
        }

        public string AuthenticateUser(User user, string password)
        {
            if (!CheckUserCredentials(user, password))
            {
                throw new Exception("Invalid credentials");
            }
            var tokenString = _authService.GenerateUserToken(user);
            return tokenString;
        }

        public string AuthenticateUserGoogle(User user)
        {
            return _authService.GenerateUserToken(user);
        }

        public bool CheckUserCredentials(User user, string providedPassword)
        {
            if (user.Id == 1) return true;
            if (providedPassword == null || providedPassword.Length == 0)
                return false;
            return _authService.VerifyPassword(providedPassword, user.Password, user.Salt);
        }

        public User FindGuestUser()
        {
            return _clientService.FindById(1);
        }

        public User FindUserByEmail(string email)
        {
            logHelper.Info(logger, "Finding user by email");
            if (email == null) return null;

            var client = _clientService.FindByEmail(email);
            if (client != null)
                return client;

            var employee = _employeeService.FindByEmail(email);
            if (employee != null)
                return employee;

            return null;
        }

        public User FindUserByUsername(string username)
        {
            logHelper.Info(logger, "Finding user by username");
            if (username == null) return null;

            var client = _clientService.FindByUsername(username);
            if (client != null)
                return client;

            var employee = _employeeService.FindByUsername(username);
            if (employee != null)
                return employee;

            return null;
        }

        public LoginResponse Login(LoginRequest request)
        {
            string loginName = request.isGuest ? "guest" : request.Username.Length > 0 ? request.Username : request.Email;
            logHelper.Info(logger, $"Trying to log in user {loginName}...");

            if (request == null)
                return null;

            User user = null;

            if (request.isGuest)
            {
                user = this.FindGuestUser();
                user.Role = UserRoleEnum.Guest;
            }
            else
            {
                if (request.Username != null && request.Username.Length > 0)
                {
                    user = this.FindUserByUsername(request.Username);
                }
                else if (request.Email != null && request.Email.Length > 0)
                {
                    user = this.FindUserByEmail(request.Email);
                }
                else
                    return null;
            }

            if (user == null)
                return null;

            string token = AuthenticateUser(user, request.Password);
            logHelper.Info(logger, $"User {user.Username} logged in");

            return new LoginResponse
            {
                User = user,
                Token = token
            };
        }

        public LoginResponse LoginGoogle(LoginGoogleRequest request)
        {
            logHelper.Info(logger, $"Trying to log in user {request.Email} with google");
            var user = this.FindUserByEmail(request.Email);

            if (user == null)
                user = _clientService.AddNewClient(request.Email, request.FirstName, request.LastName);

            string token = AuthenticateUserGoogle(user);
            logHelper.Info(logger, $"User {user.Email} logged in");

            return new LoginResponse
            {
                User = user,
                Token = token
            };
        }
    }
}
