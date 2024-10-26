using System.Net.Mail;

namespace mini_package_api.Services.Notifications
{
    public interface IEmailService
    {
        void Send(string customerEmail, string message);
    }
}
