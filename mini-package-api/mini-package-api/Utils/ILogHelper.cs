namespace mini_package_api.Utils
{
    public interface ILogHelper
    {
        public void Info(ILogger logger, string message);
        public void Error(ILogger logger, string message);
    }
}
