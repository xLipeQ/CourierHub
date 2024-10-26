using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using mini_package_api.Enums;
using mini_package_api.Models;
using mini_package_api.Models.Requests;
using mini_package_api.Models.Responses;
using mini_package_api.Services.Auth;
using mini_package_api.Services.Clients;
using mini_package_api.Services.Employees;
using mini_package_api.Services.Users;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace mini_package_api.Controllers
{
    [Route("api/auth")]
    [ApiController]
    public class LoginController : Controller
    {
        private readonly IUserService _userService;

        public LoginController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost, Route("login")]

        public IActionResult Login([FromBody] LoginRequest request)
        {
            LoginResponse response = _userService.Login(request);

            if (response == null)
                return Unauthorized("Given username/email or password is incorrect");

            return Ok(response);
        }

        [HttpPost, Route("loginGoogle")]

        public IActionResult LoginGoogle([FromBody] LoginGoogleRequest request)
        {
            LoginResponse response = _userService.LoginGoogle(request);

            return Ok(response);
        }
    }
}