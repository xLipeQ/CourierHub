using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using mini_package_api.Configuration;
using mini_package_api.Enums;
using mini_package_api.Models;
using mini_package_api.Utils;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;

namespace mini_package_api.Services.Auth
{
    public class AuthService : IAuthService
    {
        private readonly ILogger<AuthService> logger;
        private readonly ILogHelper logHelper;

        private readonly IConfiguration config;

        private const int keySize = 64;
        private const int iterations = 350000;
        private readonly HashAlgorithmName hashAlgorithm = HashAlgorithmName.SHA512;

        public AuthService(
            ILogger<AuthService> logger,
            ILogHelper logHelper,
            IConfiguration config)
        {
            this.config = config;
            this.logger = logger;
            this.logHelper = logHelper;

        }

        public string HashPasword(string password, out byte[] salt)
        {
            salt = RandomNumberGenerator.GetBytes(keySize);
            var hash = Rfc2898DeriveBytes.Pbkdf2(
                Encoding.UTF8.GetBytes(password),
                salt,
                iterations,
                hashAlgorithm,
                keySize);
            return Convert.ToHexString(hash);
        }

        public bool VerifyPassword(string password, string hash, byte[] salt)
        {
            var hashToCompare = Rfc2898DeriveBytes.Pbkdf2(password, salt, iterations, hashAlgorithm, keySize);
            return CryptographicOperations.FixedTimeEquals(hashToCompare, Convert.FromHexString(hash));
        }
        public string GenerateUserToken(User user)
        {
            List<Claim> claims = new List<Claim>
            {
                new Claim("Name", user.Username ?? "EMPTY"),
                new Claim("Role", user.Role.ToString()),
                new Claim("Id", $"{user.Id}")
            };

            return GenerateToken(claims);
        }

        private string GenerateToken(List<Claim> claims)
        {
            logHelper.Info(logger, "Generating token for user");

            var secretKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(config["secretKey"]));
            var signingCredentials = new SigningCredentials(secretKey, SecurityAlgorithms.HmacSha256);

            var tokenOptions = new JwtSecurityToken(
                issuer: config["Audiences:api"],
                audience: config["Audiences:gui"],

                claims: claims,
                expires: DateTime.Now.AddHours(8),
                signingCredentials: signingCredentials
                );


            var tokenString = new JwtSecurityTokenHandler().WriteToken(tokenOptions);
            return tokenString;
        }
    }
}
