using Microsoft.EntityFrameworkCore;
using mini_package_api.DbContexts;
using mini_package_api.Exceptions;
using mini_package_api.Models;
using mini_package_api.Services.Auth;
using mini_package_api.Utils;

namespace mini_package_api.Services.Employees
{
    public class EmployeeService : IEmployeeService
    {
        private readonly ILogger<IEmployeeService> logger;
        private readonly ILogHelper logHelper;

        private readonly MiniPackageDbContext _context;
        private readonly IAuthService _authService;

        public EmployeeService(MiniPackageDbContext context, IAuthService authService, ILogger<IEmployeeService> logger, ILogHelper logHelper)
        {
            _context = context;
            _authService = authService;
            this.logger = logger;
            this.logHelper = logHelper;
        }

        public Employee FindAvailableCourier()
        {
            Random random = new Random();
            var couriers = _context.Employees.Where(e => e.Role == Enums.UserRoleEnum.Courier).ToList();

            Employee employee = couriers[random.Next(0, couriers.Count)];
            if (employee == null)
            {
                logHelper.Error(logger, "Could not find available courier");
                throw new UserNotFoundException("Could not find available courier");
            }

            return employee;
        }

        public Employee FindByEmail(string email)
        {
            return _context.Employees
                .Where(e => e.Email == email)
                .FirstOrDefault();
        }

        public Employee FindByUsername(string username)
        {
            return _context.Employees
                .Where(e => e.Username == username)
                .FirstOrDefault();
        }

        public async Task<Employee> FindByUsernameAndPassword(string username, string password)
        {
            var employee = await _context.Employees
                .Where(e => e.Username == username)
                .Where(e => e.Password == password)
                .FirstOrDefaultAsync();

            if (employee == null)
            {
                throw new Exception("User not found");
            }
            return employee;
        }
    }
}
