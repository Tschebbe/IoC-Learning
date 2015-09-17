using Interfaces;

namespace ConstructorInjection
{
    internal class LoggingEngine
    {
        private ILogger logger;

        public LoggingEngine(ILogger logger)
        {
            this.logger = logger;
        }

        public void Log(string logMessage)
        {
            this.logger.OpenLog();
            this.logger.Log(logMessage);
            this.logger.CloseLog();
        }
    }
}