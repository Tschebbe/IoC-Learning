namespace Interfaces
{
    public interface ILogger
    {
        /// <summary>
        /// Opens the log.
        /// </summary>
        void OpenLog();

        /// <summary>
        /// Logs the specified log MSG.
        /// </summary>
        /// <param name="logMsg">The log MSG.</param>
        void Log(string logMsg);

        /// <summary>
        /// Closes the log.
        /// </summary>
        void CloseLog();
    }
}