using Microsoft.Extensions.Options;
using mini_package_api.Models;
using mini_package_api.Options;
using mini_package_api.Services.Clients;
using mini_package_api.Services.Notifications;
using mini_package_api.Utils;
using Quartz;
using System.Collections.Specialized;

namespace mini_package_api.Services.Schedulers.Jobs
{
    public class EmailSenderJob : IJob
    {
        private readonly IClientService _clientService;
        private readonly IEmailService _emailService;

        private readonly ILogger<EmailSenderJob> logger;
        private readonly ILogHelper logHelper;

        public EmailSenderJob(
            IClientService clientService,
            IEmailService emailService,
            ILogger<EmailSenderJob> logger,
            ILogHelper logHelper)
        {
            _clientService = clientService;
            _emailService = emailService;
            this.logger = logger;
            this.logHelper = logHelper;
        }

        public async Task Execute(IJobExecutionContext context)
        {
            logHelper.Info(logger, "Checking to send emails");

            //List<Client> clients = await _clientService.FindClientsForEmailNotification();

            //foreach (Client client in clients)
            //{
            //    _emailService.Send(client.Email, Guid.NewGuid().ToString());
            //}

            await Task.CompletedTask;
        }
    }
}
