using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using mini_package_api.Enums;
using mini_package_api.Models;
using mini_package_api.Services.Auth;

namespace mini_package_api.Configuration
{
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        private readonly IAuthService _authService;

        public EmployeeConfiguration(IAuthService authService)
        {
            _authService = authService;
        }

        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            // Custom database names
            builder.Property(e => e.Id)
                .HasColumnName("employee_id");

            builder.Property(e => e.Username)
                .HasColumnName("username");

            builder.Property(e => e.Email)
                .HasColumnName("email");

            builder.Property(e => e.FirstName)
                .HasColumnName("first_name");

            builder.Property(e => e.LastName)
                .HasColumnName("last_name");

            builder.Property(e => e.Role)
                .HasColumnName("role");

            builder.Property(e => e.Password)
                .HasColumnName("password");

            builder.Property(e => e.Salt)
                .HasColumnName("salt");

            // Convert enum to string
            builder.Property(e => e.Role)
               .HasConversion(new EnumToStringConverter<UserRoleEnum>());

            // Database default records
            byte[] salt;
            Employee employee1 = new Employee { Id = 1, Password = _authService.HashPasword("nowak", out salt), Salt = salt, Username = "janow", Email = "janow@gmail.com", FirstName = "Jan", LastName = "Nowak", Role = Enums.UserRoleEnum.OfficeWorker };
            Employee employee2 = new Employee { Id = 2, Password = _authService.HashPasword("wyszom", out salt), Salt = salt, Username = "frwys", Email = "frwys@gmail.com", FirstName = "Franek", LastName = "Wyszomierski", Role = Enums.UserRoleEnum.Courier };
            Employee employee3 = new Employee { Id = 3, Password = _authService.HashPasword("zalew", out salt), Salt = salt, Username = "igzal", Email = "igzal@gmail.com", FirstName = "Ignacy", LastName = "Zalewski", Role = Enums.UserRoleEnum.Courier };
            builder.HasData(
                employee1,
                employee2,
                employee3
            );
        }
    }
}
