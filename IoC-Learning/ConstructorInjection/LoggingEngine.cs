using Interfaces;

namespace ConstructorInjection
{
    internal class LoggingEngine
    {
        /// <summary>
        /// The logger
        /// </summary>
        private ILogger logger;

        /// <summary>
        /// Initializes a new instance of the <see cref="LoggingEngine"/> class.
        /// </summary>
        /// <param name="logger">The logger.</param>
        public LoggingEngine(ILogger logger)
        {
            this.logger = logger;
        }

        /// <summary>
        /// Logs the specified log message.
        /// </summary>
        /// <param name="logMessage">The log message.</param>
        public void Log(string logMessage)
        {
            this.logger.OpenLog();
            this.logger.Log(logMessage);
            this.logger.CloseLog();
        }
    }
}