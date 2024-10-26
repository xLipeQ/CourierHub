using MailKit.Net.Smtp;
using Microsoft.Extensions.Options;
using MimeKit;
using mini_package_api.Configuration;

using mini_package_api.Utils;
using Quartz;

namespace mini_package_api.Services.Notifications
{
    public class EmailService : IEmailService
    {
        private readonly IConfiguration _config;

        private readonly ILogger<EmailService> logger;
        private readonly ILogHelper logHelper;

        private const string MINI_PACKAGE_MAIL_TITLE = "Information on your inquiry in MiniPackage";
        private const string MINI_PACKAGE_MAIL_CONTENT = "<h1>You received this email, because your order status has changed.</h1>";
        private const string MINI_PACKAGE_MAIL_FOOTER = "Do not respond to this e-mail.";

        public EmailService(
            ILogger<EmailService> logger,
            ILogHelper logHelper,
            IConfiguration config)
        {
            this.logger = logger;
            this.logHelper = logHelper;
            _config = config;
        }

        public void Send(string customerEmail, string message)
        {
            var email = new MimeMessage();
            email.From.Add(MailboxAddress.Parse(_config["smtp_email"]));
            email.To.Add(MailboxAddress.Parse(customerEmail));
            email.Subject = MINI_PACKAGE_MAIL_TITLE;
            email.Body = new TextPart(MimeKit.Text.TextFormat.Html) { Text = MINI_PACKAGE_MAIL_CONTENT + "\n" + message + "\n" + MINI_PACKAGE_MAIL_FOOTER};

            try
            {
                logHelper.Info(logger, $"Sending email to: {customerEmail}");
                using var smtp = new SmtpClient();
                smtp.Connect("smtp.gmail.com", 587, MailKit.Security.SecureSocketOptions.StartTls);
                smtp.Authenticate(_config["smtp_username"], _config["smtp_gmail_password"]);
                smtp.Send(email);
                smtp.Disconnect(true);
            }
            catch (Exception e)  
            {
                Console.WriteLine(e.ToString());
            }
        }
    }
}
