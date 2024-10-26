using mini_package_api.Models;

namespace mini_package_api.Services.Employees
{
    public interface IEmployeeService
    {
        Task<Employee> FindByUsernameAndPassword(string username, string password);

        Employee FindByUsername(string username);
        Employee FindByEmail(string email);
        Employee FindAvailableCourier();

    }
}
