namespace mini_package_api.Utils
{
    public class LogHelper : ILogHelper
    {
        public void Error(ILogger logger, string message)
        {
            logger.LogError($"[{DateTime.Now}]: {message}");
        }

        public void Info(ILogger logger, string message)
        {
            logger.LogInformation($"[{DateTime.Now}]: {message}");
        }
    }
}
