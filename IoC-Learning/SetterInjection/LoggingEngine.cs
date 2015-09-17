using System;
using Interfaces;

namespace SetterInjection
{
    internal class LoggingEngine
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LoggingEngine"/> class.
        /// </summary>
        public LoggingEngine() { }

        /// <summary>
        /// Gets or sets the logger.
        /// </summary>
        /// <value>
        /// The logger.
        /// </value>
        public ILogger Logger { get; internal set; }

        /// <summary>
        /// Logs the specified log message.
        /// </summary>
        /// <param name="logMessage">The log message.</param>
        internal void Log(string logMessage)
        {
            Logger.OpenLog();
            Logger.Log(logMessage);
            Logger.CloseLog();
        }
    }
}